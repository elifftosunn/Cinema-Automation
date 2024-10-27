namespace cinemaAutomation.Views
{
    partial class GamerRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamerRecordForm));
            updateRecordButton = new Button();
            completeRegistrationButton = new Button();
            groupBox3 = new GroupBox();
            max300CharacterLabel = new Label();
            characterNumberLabel = new Label();
            biographyTextBox = new TextBox();
            groupBox2 = new GroupBox();
            uploadImageButton = new Button();
            biographyLabel = new Label();
            imagePictureBox = new PictureBox();
            groupBox1 = new GroupBox();
            directorIDLabel = new Label();
            genderLabel = new Label();
            genderComboBox = new ComboBox();
            DateOfBirthDateTimePicker = new DateTimePicker();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            dateOfBirthLabel = new Label();
            lastNameLabel = new Label();
            FirstNameLabel = new Label();
            headerPanel = new Panel();
            exitButton = new Button();
            title = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).BeginInit();
            groupBox1.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // updateRecordButton
            // 
            updateRecordButton.BackColor = Color.Silver;
            updateRecordButton.FlatAppearance.BorderColor = Color.Black;
            updateRecordButton.FlatAppearance.BorderSize = 100;
            updateRecordButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            updateRecordButton.Location = new Point(282, 442);
            updateRecordButton.Name = "updateRecordButton";
            updateRecordButton.Size = new Size(271, 56);
            updateRecordButton.TabIndex = 13;
            updateRecordButton.Text = "Update Record";
            updateRecordButton.UseVisualStyleBackColor = false;
            // 
            // completeRegistrationButton
            // 
            completeRegistrationButton.BackColor = Color.FromArgb(0, 153, 153);
            completeRegistrationButton.FlatAppearance.BorderColor = Color.Black;
            completeRegistrationButton.FlatAppearance.BorderSize = 100;
            completeRegistrationButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            completeRegistrationButton.Location = new Point(26, 442);
            completeRegistrationButton.Name = "completeRegistrationButton";
            completeRegistrationButton.Size = new Size(250, 56);
            completeRegistrationButton.TabIndex = 12;
            completeRegistrationButton.Text = "Complete Registration";
            completeRegistrationButton.UseVisualStyleBackColor = false;
            completeRegistrationButton.Click += completeRegistrationButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(max300CharacterLabel);
            groupBox3.Controls.Add(characterNumberLabel);
            groupBox3.Controls.Add(biographyTextBox);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.FromArgb(0, 153, 153);
            groupBox3.Location = new Point(26, 316);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(530, 125);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Biography";
            // 
            // max300CharacterLabel
            // 
            max300CharacterLabel.AutoSize = true;
            max300CharacterLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            max300CharacterLabel.Location = new Point(362, 0);
            max300CharacterLabel.Name = "max300CharacterLabel";
            max300CharacterLabel.Size = new Size(150, 23);
            max300CharacterLabel.TabIndex = 11;
            max300CharacterLabel.Text = "Max 300 character";
            // 
            // characterNumberLabel
            // 
            characterNumberLabel.AutoSize = true;
            characterNumberLabel.Location = new Point(484, 89);
            characterNumberLabel.Name = "characterNumberLabel";
            characterNumberLabel.Size = new Size(40, 23);
            characterNumberLabel.TabIndex = 10;
            characterNumberLabel.Text = "300";
            // 
            // biographyTextBox
            // 
            biographyTextBox.Dock = DockStyle.Fill;
            biographyTextBox.Location = new Point(3, 26);
            biographyTextBox.MaxLength = 300;
            biographyTextBox.Multiline = true;
            biographyTextBox.Name = "biographyTextBox";
            biographyTextBox.Size = new Size(524, 96);
            biographyTextBox.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(uploadImageButton);
            groupBox2.Controls.Add(biographyLabel);
            groupBox2.Controls.Add(imagePictureBox);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(0, 153, 153);
            groupBox2.Location = new Point(324, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 239);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Image";
            // 
            // uploadImageButton
            // 
            uploadImageButton.BackColor = Color.IndianRed;
            uploadImageButton.Dock = DockStyle.Bottom;
            uploadImageButton.FlatAppearance.BorderColor = Color.Black;
            uploadImageButton.FlatAppearance.BorderSize = 100;
            uploadImageButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            uploadImageButton.ForeColor = Color.White;
            uploadImageButton.Location = new Point(3, 180);
            uploadImageButton.Name = "uploadImageButton";
            uploadImageButton.Size = new Size(229, 56);
            uploadImageButton.TabIndex = 4;
            uploadImageButton.Text = "Upload Image";
            uploadImageButton.UseVisualStyleBackColor = false;
            uploadImageButton.Click += uploadImageButton_Click;
            // 
            // biographyLabel
            // 
            biographyLabel.AutoSize = true;
            biographyLabel.ForeColor = Color.FromArgb(0, 153, 153);
            biographyLabel.Location = new Point(21, 176);
            biographyLabel.Name = "biographyLabel";
            biographyLabel.Size = new Size(136, 23);
            biographyLabel.TabIndex = 3;
            biographyLabel.Text = "biographyLabel";
            // 
            // imagePictureBox
            // 
            imagePictureBox.ErrorImage = (Image)resources.GetObject("imagePictureBox.ErrorImage");
            imagePictureBox.Image = (Image)resources.GetObject("imagePictureBox.Image");
            imagePictureBox.Location = new Point(21, 32);
            imagePictureBox.Name = "imagePictureBox";
            imagePictureBox.Size = new Size(194, 142);
            imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imagePictureBox.TabIndex = 2;
            imagePictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(directorIDLabel);
            groupBox1.Controls.Add(genderLabel);
            groupBox1.Controls.Add(genderComboBox);
            groupBox1.Controls.Add(DateOfBirthDateTimePicker);
            groupBox1.Controls.Add(lastNameTextBox);
            groupBox1.Controls.Add(firstNameTextBox);
            groupBox1.Controls.Add(dateOfBirthLabel);
            groupBox1.Controls.Add(lastNameLabel);
            groupBox1.Controls.Add(FirstNameLabel);
            groupBox1.Location = new Point(21, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 239);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // directorIDLabel
            // 
            directorIDLabel.AutoSize = true;
            directorIDLabel.Location = new Point(23, 12);
            directorIDLabel.Name = "directorIDLabel";
            directorIDLabel.Size = new Size(0, 20);
            directorIDLabel.TabIndex = 8;
            directorIDLabel.Visible = false;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            genderLabel.ForeColor = Color.FromArgb(0, 153, 153);
            genderLabel.Location = new Point(19, 176);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(60, 20);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender";
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "F", "M" });
            genderComboBox.Location = new Point(130, 173);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(125, 28);
            genderComboBox.TabIndex = 6;
            genderComboBox.Text = "F";
            // 
            // DateOfBirthDateTimePicker
            // 
            DateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short;
            DateOfBirthDateTimePicker.Location = new Point(131, 129);
            DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            DateOfBirthDateTimePicker.Size = new Size(124, 27);
            DateOfBirthDateTimePicker.TabIndex = 5;
            DateOfBirthDateTimePicker.Value = new DateTime(2024, 10, 24, 0, 0, 0, 0);
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(130, 78);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(125, 27);
            lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(130, 32);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(125, 27);
            firstNameTextBox.TabIndex = 3;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateOfBirthLabel.ForeColor = Color.FromArgb(0, 153, 153);
            dateOfBirthLabel.Location = new Point(19, 130);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(100, 20);
            dateOfBirthLabel.TabIndex = 2;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lastNameLabel.ForeColor = Color.FromArgb(0, 153, 153);
            lastNameLabel.Location = new Point(19, 78);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(84, 20);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FirstNameLabel.ForeColor = Color.FromArgb(0, 153, 153);
            FirstNameLabel.Location = new Point(19, 32);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(86, 20);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 153, 153);
            headerPanel.Controls.Add(exitButton);
            headerPanel.Controls.Add(title);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(571, 56);
            headerPanel.TabIndex = 8;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Firebrick;
            exitButton.Dock = DockStyle.Right;
            exitButton.FlatAppearance.BorderColor = Color.Black;
            exitButton.FlatAppearance.BorderSize = 100;
            exitButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            exitButton.Location = new Point(518, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(53, 56);
            exitButton.TabIndex = 1;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.Control;
            title.Location = new Point(36, 9);
            title.Name = "title";
            title.Size = new Size(200, 45);
            title.TabIndex = 0;
            title.Text = "Gamer Record";
            // 
            // GamerRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 498);
            Controls.Add(updateRecordButton);
            Controls.Add(completeRegistrationButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(headerPanel);
            Location = new Point(500, 200);
            Name = "GamerRecordForm";
            StartPosition = FormStartPosition.Manual;
            Text = "GamerRecordForm";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button updateRecordButton;
        private Button completeRegistrationButton;
        private GroupBox groupBox3;
        private Label max300CharacterLabel;
        private Label characterNumberLabel;
        public TextBox biographyTextBox;
        private GroupBox groupBox2;
        private Button uploadImageButton;
        private Label biographyLabel;
        public PictureBox imagePictureBox;
        private GroupBox groupBox1;
        public Label directorIDLabel;
        private Label genderLabel;
        public ComboBox genderComboBox;
        public DateTimePicker DateOfBirthDateTimePicker;
        public TextBox lastNameTextBox;
        public TextBox firstNameTextBox;
        private Label dateOfBirthLabel;
        private Label lastNameLabel;
        private Label FirstNameLabel;
        private Panel headerPanel;
        private Button exitButton;
        private Label title;
    }
}