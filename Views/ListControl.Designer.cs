namespace cinemaAutomation.Views
{
    partial class ListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListControl));
            panel1 = new Panel();
            controlFullName = new Label();
            controlImagePictureBox = new PictureBox();
            directorID = new Label();
            directorDetailButton = new Button();
            pictureBoxGender = new PictureBox();
            deleteDirectorButton = new Button();
            directorUpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)controlImagePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGender).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 153, 153);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 85);
            panel1.TabIndex = 0;
            // 
            // controlFullName
            // 
            controlFullName.AutoSize = true;
            controlFullName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            controlFullName.ForeColor = Color.FromArgb(0, 153, 153);
            controlFullName.Location = new Point(146, 8);
            controlFullName.Name = "controlFullName";
            controlFullName.Size = new Size(48, 20);
            controlFullName.TabIndex = 1;
            controlFullName.Text = "label1";
            // 
            // controlImagePictureBox
            // 
            controlImagePictureBox.Image = (Image)resources.GetObject("controlImagePictureBox.Image");
            controlImagePictureBox.Location = new Point(14, 3);
            controlImagePictureBox.Name = "controlImagePictureBox";
            controlImagePictureBox.Size = new Size(81, 82);
            controlImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            controlImagePictureBox.TabIndex = 2;
            controlImagePictureBox.TabStop = false;
            // 
            // directorID
            // 
            directorID.AutoSize = true;
            directorID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            directorID.ForeColor = Color.FromArgb(0, 153, 153);
            directorID.Location = new Point(146, 50);
            directorID.Name = "directorID";
            directorID.Size = new Size(48, 20);
            directorID.TabIndex = 3;
            directorID.Text = "label1";
            // 
            // directorDetailButton
            // 
            directorDetailButton.BackColor = Color.Gray;
            directorDetailButton.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            directorDetailButton.ForeColor = SystemColors.Window;
            directorDetailButton.Location = new Point(278, 18);
            directorDetailButton.Margin = new Padding(0);
            directorDetailButton.Name = "directorDetailButton";
            directorDetailButton.Size = new Size(128, 52);
            directorDetailButton.TabIndex = 4;
            directorDetailButton.Text = "Detail";
            directorDetailButton.UseVisualStyleBackColor = false;
            directorDetailButton.Click += directorDetailButton_Click;
            // 
            // pictureBoxGender
            // 
            pictureBoxGender.Location = new Point(101, 3);
            pictureBoxGender.Name = "pictureBoxGender";
            pictureBoxGender.Size = new Size(30, 25);
            pictureBoxGender.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGender.TabIndex = 5;
            pictureBoxGender.TabStop = false;
            // 
            // deleteDirectorButton
            // 
            deleteDirectorButton.BackColor = Color.DarkRed;
            deleteDirectorButton.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            deleteDirectorButton.ForeColor = SystemColors.Window;
            deleteDirectorButton.Location = new Point(409, 50);
            deleteDirectorButton.Name = "deleteDirectorButton";
            deleteDirectorButton.Size = new Size(128, 35);
            deleteDirectorButton.TabIndex = 6;
            deleteDirectorButton.Text = "Delete";
            deleteDirectorButton.UseVisualStyleBackColor = false;
            deleteDirectorButton.Click += deleteDirectorButton_Click;
            // 
            // directorUpdateButton
            // 
            directorUpdateButton.BackColor = Color.MediumAquamarine;
            directorUpdateButton.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            directorUpdateButton.ForeColor = SystemColors.Window;
            directorUpdateButton.Location = new Point(409, 9);
            directorUpdateButton.Margin = new Padding(0);
            directorUpdateButton.Name = "directorUpdateButton";
            directorUpdateButton.Size = new Size(128, 38);
            directorUpdateButton.TabIndex = 7;
            directorUpdateButton.Text = "Update";
            directorUpdateButton.UseVisualStyleBackColor = false;
            directorUpdateButton.Click += directorUpdateButton_Click;
            // 
            // DirectorListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(directorUpdateButton);
            Controls.Add(deleteDirectorButton);
            Controls.Add(pictureBoxGender);
            Controls.Add(directorDetailButton);
            Controls.Add(directorID);
            Controls.Add(controlImagePictureBox);
            Controls.Add(controlFullName);
            Controls.Add(panel1);
            Name = "DirectorListControl";
            Size = new Size(540, 88);
            ((System.ComponentModel.ISupportInitialize)controlImagePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGender).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label controlFullName;
        public PictureBox controlImagePictureBox;
        public Label directorID;
        public Button directorDetailButton;
        public PictureBox pictureBoxGender;
        public Button deleteDirectorButton;
        public Button directorUpdateButton;
    }
}
