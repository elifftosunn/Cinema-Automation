using cinemaAutomation.Models;
using cinemaAutomation.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaAutomation
{
    public partial class DirectorRecordForm : Form
    {
        private OpenFileDialog ofd;
        private DBConnection conn;
        private string gender = "F";
        private string age = "";
        private string image = "";
        private string fullName = "";
        DateTime birthDate;

        public string Gender { get => gender; set => gender = value; }
        public string Age { get => age; set => age = value; }
        public string Image { get => image; set => image = value; }

        public DirectorRecordForm()
        {
            InitializeComponent();
            conn = new DBConnection();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void uploadImageButton_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Screen the Choose Image";
            ofd.Filter = "PNG | *.png |JPG-JPEG | *.jpg;*.jpeg |All Files | *.*";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = new Bitmap(ofd.FileName);
                Image = ofd.FileName;
            }
        }
        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gender = genderComboBox.SelectedItem.ToString();
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            birthDate = DateOfBirthDateTimePicker.Value;
            DateTime today = DateTime.Now;
            int _age = today.Year - birthDate.Year;
            if (_age < 0)
                MessageBox.Show("Age cannot be negative", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Age = _age.ToString();
        }
        private void completeRegistrationButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Gender: " + gender + "\nAge: " + _age,
            //    "Registration Information",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            fullName = string.Concat(firstNameTextBox.Text[0].ToString().ToUpper(), firstNameTextBox.Text.AsSpan(1))
                + " " + string.Concat(lastNameTextBox.Text[0].ToString().ToUpper(), lastNameTextBox.Text.AsSpan(1));
            string query = "INSERT INTO Directors (fullName, gender, age, biography, image, dateOfBirth) VALUES (@_fullName, @_gender, @_age, @_biography, @_image, @_dateOfBirth);";
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
        private void biographyTextBox_TextChanged(object sender, EventArgs e)
        {
            int characterNumber = biographyTextBox.Text.Length;
            characterNumberLabel.Text = (300 - characterNumber).ToString();
            if (characterNumber >= 300)
                MessageBox.Show("Max character number is 300");
        }

        private void updateRecordButton_Click(object sender, EventArgs e)
        {
            fullName = string.Concat(firstNameTextBox.Text[0].ToString().ToUpper(), firstNameTextBox.Text.AsSpan(1))
                + " " + string.Concat(lastNameTextBox.Text[0].ToString().ToUpper(), lastNameTextBox.Text.AsSpan(1));
            string query = "UPDATE Directors SET fullName = @_fullName, gender=@_gender, age=@_age, biography=@_biography, image=@_image, dateOfBirth=@_dateOfBirth WHERE id=@_id;";
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
    }
}
