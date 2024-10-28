using cinemaAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemaAutomation.Controllers
{
    public abstract class RecordFormBaseController: Form
    {
        protected OpenFileDialog ofd;
        protected DBConnection conn;
        protected string gender = "F";
        protected string age = "";
        protected string image = "";
        protected DateTime birthDate;

        public string Gender { get => gender; set => gender = value; }
        public string Age { get => age; set => age = value; }
        public string Image { get => image; set => image = value; }

        protected RecordFormBaseController()
        {
            conn = new DBConnection();
        }

        protected void UploadImage(PictureBox imagePictureBox)
        {
            ofd = new OpenFileDialog { Title = "Choose Image", Filter = "PNG | *.png |JPG-JPEG | *.jpg;*.jpeg |All Files | *.*" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = new Bitmap(ofd.FileName);
                Image = ofd.FileName;
            }
        }
        protected void genderComboBoxSelectedIndex(ComboBox genderComboBox)
        {
            Gender = genderComboBox.SelectedItem.ToString();
        }
        protected void CalculateAge(DateTimePicker dateOfBirthPicker)
        {
            birthDate = dateOfBirthPicker.Value;
            int calculatedAge = DateTime.Now.Year - birthDate.Year;
            Age = calculatedAge > 0 ? calculatedAge.ToString() : "Invalid age";
        }

        protected void ShowCharacterCount(TextBox biographyTextBox, Label characterNumberLabel, int maxCharacters = 300)
        {
            int characterNumber = biographyTextBox.Text.Length;
            characterNumberLabel.Text = (maxCharacters - characterNumber).ToString();
            if (characterNumber >= maxCharacters)
                MessageBox.Show($"Max character number is {maxCharacters}");
        }

        public abstract void SaveRecord();  // Abstract to allow custom logic in derived classes
        public abstract void UpdateRecord(); // Abstract to allow custom logic in derived classes
    }
}
