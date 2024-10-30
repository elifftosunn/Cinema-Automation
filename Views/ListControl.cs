using cinemaAutomation.Models;
using System;
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

namespace cinemaAutomation.Views
{
    public partial class ListControl : UserControl
    {
        private DBConnection connection;
        private DirectorListForm directorListForm;
        private DirectorRecordForm directorRecordForm;

        public ListControl()
        {
            InitializeComponent();
            connection = new DBConnection();

        }

        private void directorDetailButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT age, biography FROM Directors WHERE id = @_id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@_id", SqlDbType.Char) {Value = directorID.Text.ToString()}
            };
            SqlDataReader reader = connection.ExecuteQueryWithReader(query, parameters);
            if (reader.Read())
            {
                MessageBox.Show("Age: " + reader["age"].ToString() + "\nBiography: " + reader["biography"].ToString(),
                    controlFullName.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteDirectorButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete the record?", "Delete Record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // remove from directorListForm
                directorListForm = new DirectorListForm();
                foreach (Control control in directorListForm.Controls)
                {
                    Debug.WriteLine("***************************************");
                    if (control is ListControl directorControl && directorControl.directorID.Text == directorID.Text)
                    {
                        Debug.WriteLine("directorControl.directorID.Text: " + directorControl.directorID.Text);
                        Debug.WriteLine("directorID.Text: " + directorID.Text);
                        directorListForm.Controls.Remove(control); // remove the delete record
                        break;
                    }
                }
                string query = "DELETE FROM Directors WHERE id = @_id";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@_id", SqlDbType.SmallInt) {Value = directorID.Text.ToString()}
                };
                int res = connection.ExecuteNonQuery(query, parameters);
                if (res > 0)
                    MessageBox.Show("The record named " + controlFullName.Text + " was deleted successfully!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                controlFullName.Text = "";
                pictureBoxGender.Image = null;
                controlImagePictureBox.Image = null;
                directorID.Text = string.Empty;
                deleteDirectorButton.Visible = false;
                directorDetailButton.Visible = false;
                directorUpdateButton.Visible = false;   
               
            }
            else
                MessageBox.Show("Record not deleted", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void directorUpdateButton_Click(object sender, EventArgs e)
        {
            directorRecordForm = new DirectorRecordForm();
            directorListForm = new DirectorListForm();
            directorListForm.Close();
            directorRecordForm.Show();
            string query = "SELECT * FROM Directors WHERE id = @_id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@_id", SqlDbType.SmallInt) {Value = directorID.Text}
            };
            SqlDataReader reader = connection.ExecuteQueryWithReader(query, parameters);
            if (reader.Read())
            {
                string[] fullName = reader["fullName"].ToString().Split(" ");
                Debug.WriteLine("**************************************");
                Debug.WriteLine(fullName.Length);
                if (fullName.Length >= 2)
                {
                    directorRecordForm.firstNameTextBox.Text = fullName[0];
                    directorRecordForm.lastNameTextBox.Text = fullName[1];
                }else if (fullName.Length == 1)
                    directorRecordForm.firstNameTextBox.Text= fullName[0];
                else
                {
                    directorRecordForm.firstNameTextBox = null;
                    directorRecordForm.lastNameTextBox = null;
                }
                directorRecordForm.directorIDLabel.Text = reader["id"].ToString();
                directorRecordForm.genderComboBox.Text = reader["gender"].ToString() != "" ? reader["gender"].ToString() : "";
                directorRecordForm.biographyTextBox.Text = reader["biography"].ToString() != "" ? reader["biography"].ToString() : "";
                directorRecordForm.imagePictureBox.Image = reader["image"].ToString() != "" ? Image.FromFile(reader["image"].ToString()) : Image.FromFile("C:\\Users\\dptos\\Downloads\\uploadImage.jpg");
                if (reader["dateOfBirth"] != DBNull.Value)
                {
                    DateTime parsedDate = ((DateTime)reader["dateOfBirth"]).Date;
                    directorRecordForm.DateOfBirthDateTimePicker.Value = parsedDate;
                }
                else
                    directorRecordForm.DateOfBirthDateTimePicker.Value = DateTime.Now;
            }
        }
    }
}
