using cinemaAutomation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaAutomation
{
    public partial class MainForm : Form
    {
        public string fullName = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void recordDirectorButton_Click(object sender, EventArgs e)
        {
            DirectorRecordForm directorRecordForm = new DirectorRecordForm();
            directorRecordForm.ShowDialog();
            //this.Close();
        }

        private void directorListButton_Click(object sender, EventArgs e)
        {
            DirectorListForm directorListForm = new DirectorListForm();
            directorListForm.ShowDialog();
        }

        private void gamerRecordButton_Click_1(object sender, EventArgs e)
        {
            GamerRecordForm gamerRecordForm = new GamerRecordForm();
            gamerRecordForm.ShowDialog();
        }

        private void gamerListButton_Click(object sender, EventArgs e)
        {
            GamerListForm gamerListForm = new GamerListForm();
            gamerListForm.ShowDialog();
        }

        private void saloonRecordButton_Click(object sender, EventArgs e)
        {
            SaloonRecordForm saloonRecordForm = new SaloonRecordForm(); 
            saloonRecordForm.ShowDialog();  
        }
    }
}   
