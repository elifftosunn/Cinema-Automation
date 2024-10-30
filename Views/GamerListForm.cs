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
    public partial class GamerListForm : Form
    {
        private DBConnection conn;
        private SqlDataReader reader;
        private ListControl tool;
        public GamerListForm()
        {
            InitializeComponent();
            conn = new DBConnection();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void viewDatas(string query)
        {
            reader = conn.ExecuteQueryWithReader(query);
            while (reader.Read())
            {
                tool = new ListControl();
                tool.directorID.Text = reader["id"].ToString();
                tool.controlFullName.Text = reader.GetString(1);
                tool.controlImagePictureBox.ImageLocation = reader["image"].ToString();
                string gender = reader["gender"].ToString();
                if (gender != null)
                {
                    if (gender == "F")
                        tool.pictureBoxGender.Image = Image.FromFile("C:\\Users\\dptos\\Downloads\\female.png");
                    else
                        tool.pictureBoxGender.Image = Image.FromFile("C:\\Users\\dptos\\Downloads\\male.png");
                }
                listPanel.Controls.Add(tool);
            }
            conn.CloseConnection();
        }
        private void GamerListForm_Load(object sender, EventArgs e)
        {
            listPanel.Controls.Clear();
            string query = "SELECT * FROM Gamers;";
            viewDatas(query);
        }
        private void fullNameTextBoxForSearch_TextChanged_1(object sender, EventArgs e)
        {
            listPanel.Controls.Clear();
            string query = "SELECT * FROM Gamers WHERE fullName LIKE '%" + fullNameTextBoxForSearch.Text + "%' ORDER BY fullName ASC";
            viewDatas(query);
        }
    }
}
