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
        DBConnection conn;
        SaloonUserControlForm saloonUserControl;
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
                string query = "INSERT INTO Saloons (saloonName, seatingCapacity) VALUES (@_saloonName, @_seatingCapacity);";
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
            string query = "SELECT * FROM Saloons ORDER BY saloonName ASC;";
            SqlDataReader reader = conn.ExecuteQueryWithReader(query);
            while (reader.Read())
            {
                saloonUserControl = new SaloonUserControlForm();
                saloonUserControl.labelSaloonName.Text = reader["saloonName"].ToString();
                saloonUserControl.labelSeatingCapacity.Text = reader["seatingCapacity"].ToString();
                flowLayoutPanelSaloon.Controls.Add(saloonUserControl);
            }
        }
    }
}
