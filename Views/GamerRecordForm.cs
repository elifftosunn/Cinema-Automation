using cinemaAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaAutomation.Views
{
    public partial class GamerRecordForm : Form
    {
        DirectorRecordForm directorRecordForm;
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
        public GamerRecordForm()
        {
            InitializeComponent();
            directorRecordForm = new DirectorRecordForm();
        }

        private void completeRegistrationButton_Click(object sender, EventArgs e)
        {

        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            directorRecordForm.uploadImageButton_Click(sender, e);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
