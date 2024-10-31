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
    public partial class SaloonRecordForm : Form
    {
        private DBConnection conn;
        private SaloonUserControlForm saloonUserControl;
        private string query;
        public SaloonRecordForm()
        {
            InitializeComponent();
            conn = new DBConnection();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saloonRecordButton_Click(object sender, EventArgs e)
        {
            if (saloonNameTextBox.Text != string.Empty && numericUpDownSeatingCapacity.Value > 0)
            {
                query = "INSERT INTO Saloons (saloonName, seatingCapacity) VALUES (@_saloonName, @_seatingCapacity);";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@_saloonName", SqlDbType.NVarChar) {Value = saloonNameTextBox.Text},
                    new SqlParameter("@_seatingCapacity", SqlDbType.Char) {Value = numericUpDownSeatingCapacity.Value}
                };
                int res = conn.ExecuteNonQuery(query, parameters);
                if (res > 0)
                {
                    MessageBox.Show("Saloon successfully added.",
                        "Saloon Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bringList();
                }
            }
            else
            {
                MessageBox.Show("Please fill the fields!\nSeating capacity must be greater than 0!",
                    "Saloon Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaloonRecordForm_Load(object sender, EventArgs e)
        {
            bringList();
        }
        private void bringList()
        {
            flowLayoutPanelSaloon.Controls.Clear();
            query = "SELECT * FROM Saloons ORDER BY saloonName ASC;";
            SqlDataReader reader = conn.ExecuteQueryWithReader(query);
            while (reader.Read())
            {
                saloonUserControl = new SaloonUserControlForm();
                saloonUserControl.saloonIDLabel.Text = reader["id"].ToString();
                saloonUserControl.labelSaloonName.Text = reader["saloonName"].ToString();
                saloonUserControl.labelSeatingCapacity.Text = reader["seatingCapacity"].ToString();
                // include Click event for each created saloonUserControl
                saloonUserControl.SaloonClicked += SaloonUserControl_SaloonClicked;
                flowLayoutPanelSaloon.Controls.Add(saloonUserControl);
            }
        }
        private void SaloonUserControl_SaloonClicked(object sender, EventArgs e)
        {
            // Access the clicked SaloonUserControlForm instance
            var clickedControl = sender as SaloonUserControlForm;
            if (clickedControl != null)
            {
                // update the datas clicked SaloonUserControlForm
                saloonIdLabel.Text = clickedControl.saloonIDLabel.Text;
                saloonNameTextBox.Text = clickedControl.labelSaloonName.Text;
                numericUpDownSeatingCapacity.Value = Convert.ToInt32(clickedControl.labelSeatingCapacity.Text);
            }
        }
        private void updateRecordButton_Click(object sender, EventArgs e)
        {
            if(saloonNameTextBox.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Are you sure update the saloon record?",
                    "Update Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) 
                {
                    query = "UPDATE Saloons SET saloonName=@_saloonName, seatingCapacity=@_seatingCapacity WHERE id=@_id";
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@_id",SqlDbType.SmallInt) {Value = saloonIdLabel.Text},
                        new SqlParameter("@_saloonName",SqlDbType.NVarChar) {Value = saloonNameTextBox.Text},
                        new SqlParameter("@_seatingCapacity",SqlDbType.Char) {Value = numericUpDownSeatingCapacity.Value.ToString()}
                    };
                    int res = conn.ExecuteNonQuery(query, parameters);
                    if (res > 0)
                    {
                        MessageBox.Show("Saloon record updated successfully!",
                                "Saloon Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bringList();
                    }
                }

            }else
                MessageBox.Show("Please, enter a saloon name!",
                        "Saloon Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
