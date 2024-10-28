using cinemaAutomation.Controllers;
using cinemaAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaAutomation.Views
{
    public partial class GamerRecordForm : RecordFormBaseController
    {
        private string fullName;
        public GamerRecordForm()
        {
            InitializeComponent();
        }
        public override void SaveRecord()
        {
            fullName = string.Concat(firstNameTextBox.Text[0].ToString().ToUpper(), firstNameTextBox.Text.AsSpan(1))
    + " " + string.Concat(lastNameTextBox.Text[0].ToString().ToUpper(), lastNameTextBox.Text.AsSpan(1));
            string query = "INSERT INTO Gamers (fullName, gender, age, biography, image, dateOfBirth) VALUES (@_fullName, @_gender, @_age, @_biography, @_image, @_dateOfBirth);";
            SqlParameter[] parameters =
            {
                new SqlParameter("@_fullName", SqlDbType.VarChar) {Value = fullName},
                new SqlParameter("@_gender", SqlDbType.Char) {Value = Gender},
                new SqlParameter("@_age", SqlDbType.Char) {Value = Age},
                new SqlParameter("@_biography", SqlDbType.NVarChar) {Value = biographyTextBox.Text},
                new SqlParameter("@_image", SqlDbType.NVarChar) {Value = Image},
                new SqlParameter("@_dateOfBirth", SqlDbType.Date) {Value = birthDate}
            };
            int res = conn.ExecuteNonQuery(query, parameters);
            if (res > 0)
            {
                MessageBox.Show("Record added successfully!", "Add Record",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanFields();
            }
        }

        private void Save(object sender, EventArgs e)
        {
            SaveRecord();
        }
        public override void UpdateRecord()
        {
            fullName = string.Concat(firstNameTextBox.Text[0].ToString().ToUpper(), firstNameTextBox.Text.AsSpan(1))
    + " " + string.Concat(lastNameTextBox.Text[0].ToString().ToUpper(), lastNameTextBox.Text.AsSpan(1));
            string query = "UPDATE Gamers SET fullName = @_fullName, gender=@_gender, age=@_age, biography=@_biography, image=@_image, dateOfBirth=@_dateOfBirth WHERE id=@_id;";
            DialogResult dialogResult = MessageBox.Show("Are you sure update the record?", "Update Record",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@_id", SqlDbType.SmallInt) {Value = directorIDLabel.Text},
                    new SqlParameter("@_fullName", SqlDbType.VarChar) {Value = fullName},
                    new SqlParameter("@_gender", SqlDbType.Char) {Value = Gender},
                    new SqlParameter("@_age", SqlDbType.Char) {Value = Age},
                    new SqlParameter("@_biography", SqlDbType.NVarChar) {Value = biographyTextBox.Text},
                    new SqlParameter("@_image", SqlDbType.NVarChar) {Value = Image},
                    new SqlParameter("@_dateOfBirth", SqlDbType.Date) {Value = birthDate}
                };
                int res = conn.ExecuteNonQuery(query, parameters);
                if (res > 0)
                {
                    MessageBox.Show("Record updated successfully!", "Update Record",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanFields();
                }
            }
            else
                MessageBox.Show("Record not updated!", "Update Record",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cleanFields()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            DateOfBirthDateTimePicker.Text = string.Empty;
            biographyTextBox.Text = string.Empty;
            //imagePictureBox.Image = new Bitmap(Resources.uploadImage.ToString());
            imagePictureBox.Image = null;
            genderComboBox.Text = string.Empty;
            firstNameTextBox.Focus();

        }
        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            UploadImage(imagePictureBox);
        }
        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            genderComboBoxSelectedIndex(genderComboBox);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Update()
        {
            UpdateRecord();
        }
        private void biographyTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowCharacterCount(biographyTextBox, characterNumberLabel);
        }
    }
}
