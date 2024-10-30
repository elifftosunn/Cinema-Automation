namespace cinemaAutomation.Views
{
    partial class SaloonRecordForm
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
            updateRecordButton = new Button();
            groupBoxSaloonRecord = new GroupBox();
            saloonRecordButton = new Button();
            saloonNameTextBox = new TextBox();
            numericUpDownSeatingCapacity = new NumericUpDown();
            seatingCapacityLabel = new Label();
            directorIDLabel = new Label();
            saloonNameLabel = new Label();
            headerPanel = new Panel();
            exitButton = new Button();
            title = new Label();
            saloonRecordGroupBox = new GroupBox();
            flowLayoutPanelSaloon = new FlowLayoutPanel();
            groupBoxSaloonRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeatingCapacity).BeginInit();
            headerPanel.SuspendLayout();
            saloonRecordGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // updateRecordButton
            // 
            updateRecordButton.BackColor = Color.Silver;
            updateRecordButton.FlatAppearance.BorderColor = Color.Black;
            updateRecordButton.FlatAppearance.BorderSize = 100;
            updateRecordButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            updateRecordButton.Location = new Point(268, 69);
            updateRecordButton.Name = "updateRecordButton";
            updateRecordButton.Size = new Size(255, 35);
            updateRecordButton.TabIndex = 13;
            updateRecordButton.Text = "Update Record";
            updateRecordButton.UseVisualStyleBackColor = false;
            // 
            // groupBoxSaloonRecord
            // 
            groupBoxSaloonRecord.Controls.Add(saloonRecordButton);
            groupBoxSaloonRecord.Controls.Add(updateRecordButton);
            groupBoxSaloonRecord.Controls.Add(saloonNameTextBox);
            groupBoxSaloonRecord.Controls.Add(numericUpDownSeatingCapacity);
            groupBoxSaloonRecord.Controls.Add(seatingCapacityLabel);
            groupBoxSaloonRecord.Controls.Add(directorIDLabel);
            groupBoxSaloonRecord.Controls.Add(saloonNameLabel);
            groupBoxSaloonRecord.Location = new Point(12, 62);
            groupBoxSaloonRecord.Name = "groupBoxSaloonRecord";
            groupBoxSaloonRecord.Size = new Size(547, 124);
            groupBoxSaloonRecord.TabIndex = 9;
            groupBoxSaloonRecord.TabStop = false;
            // 
            // saloonRecordButton
            // 
            saloonRecordButton.BackColor = Color.FromArgb(0, 153, 153);
            saloonRecordButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            saloonRecordButton.Location = new Point(6, 69);
            saloonRecordButton.Name = "saloonRecordButton";
            saloonRecordButton.Size = new Size(231, 38);
            saloonRecordButton.TabIndex = 14;
            saloonRecordButton.Text = "Complete Record";
            saloonRecordButton.UseVisualStyleBackColor = false;
            saloonRecordButton.Click += saloonRecordButton_Click;
            // 
            // saloonNameTextBox
            // 
            saloonNameTextBox.Location = new Point(114, 32);
            saloonNameTextBox.Name = "saloonNameTextBox";
            saloonNameTextBox.Size = new Size(123, 27);
            saloonNameTextBox.TabIndex = 12;
            // 
            // numericUpDownSeatingCapacity
            // 
            numericUpDownSeatingCapacity.Location = new Point(398, 30);
            numericUpDownSeatingCapacity.Name = "numericUpDownSeatingCapacity";
            numericUpDownSeatingCapacity.Size = new Size(125, 27);
            numericUpDownSeatingCapacity.TabIndex = 11;
            // 
            // seatingCapacityLabel
            // 
            seatingCapacityLabel.AutoSize = true;
            seatingCapacityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            seatingCapacityLabel.ForeColor = Color.FromArgb(0, 153, 153);
            seatingCapacityLabel.Location = new Point(268, 32);
            seatingCapacityLabel.Name = "seatingCapacityLabel";
            seatingCapacityLabel.Size = new Size(124, 20);
            seatingCapacityLabel.TabIndex = 10;
            seatingCapacityLabel.Text = "Seating Capacity";
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
            // saloonNameLabel
            // 
            saloonNameLabel.AutoSize = true;
            saloonNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            saloonNameLabel.ForeColor = Color.FromArgb(0, 153, 153);
            saloonNameLabel.Location = new Point(6, 32);
            saloonNameLabel.Name = "saloonNameLabel";
            saloonNameLabel.Size = new Size(102, 20);
            saloonNameLabel.TabIndex = 0;
            saloonNameLabel.Text = "Saloon Name";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 153, 153);
            headerPanel.Controls.Add(exitButton);
            headerPanel.Controls.Add(title);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(561, 56);
            headerPanel.TabIndex = 8;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Firebrick;
            exitButton.Dock = DockStyle.Right;
            exitButton.FlatAppearance.BorderColor = Color.Black;
            exitButton.FlatAppearance.BorderSize = 100;
            exitButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            exitButton.Location = new Point(508, 0);
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
            title.Size = new Size(209, 45);
            title.TabIndex = 0;
            title.Text = "Saloon Record";
            // 
            // saloonRecordGroupBox
            // 
            saloonRecordGroupBox.Controls.Add(flowLayoutPanelSaloon);
            saloonRecordGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            saloonRecordGroupBox.ForeColor = Color.FromArgb(0, 153, 153);
            saloonRecordGroupBox.Location = new Point(12, 203);
            saloonRecordGroupBox.Name = "saloonRecordGroupBox";
            saloonRecordGroupBox.Size = new Size(547, 352);
            saloonRecordGroupBox.TabIndex = 14;
            saloonRecordGroupBox.TabStop = false;
            saloonRecordGroupBox.Text = "Saloon Record List";
            // 
            // flowLayoutPanelSaloon
            // 
            flowLayoutPanelSaloon.AutoScroll = true;
            flowLayoutPanelSaloon.Dock = DockStyle.Fill;
            flowLayoutPanelSaloon.Location = new Point(3, 23);
            flowLayoutPanelSaloon.Name = "flowLayoutPanelSaloon";
            flowLayoutPanelSaloon.Size = new Size(541, 326);
            flowLayoutPanelSaloon.TabIndex = 0;
            // 
            // SaloonRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 561);
            Controls.Add(saloonRecordGroupBox);
            Controls.Add(groupBoxSaloonRecord);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 200);
            Name = "SaloonRecordForm";
            StartPosition = FormStartPosition.Manual;
            Text = "SaloonRecordForm";
            Load += SaloonRecordForm_Load;
            groupBoxSaloonRecord.ResumeLayout(false);
            groupBoxSaloonRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeatingCapacity).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            saloonRecordGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button updateRecordButton;
        private GroupBox groupBox3;
        private Label max300CharacterLabel;
        private Label characterNumberLabel;
        public TextBox biographyTextBox;
        private GroupBox groupBox2;
        private Button uploadImageButton;
        private Label biographyLabel;
        public PictureBox imagePictureBox;
        private GroupBox groupBoxSaloonRecord;
        public Label directorIDLabel;
        private Label genderLabel;
        public ComboBox genderComboBox;
        public DateTimePicker DateOfBirthDateTimePicker;
        public TextBox lastNameTextBox;
        public TextBox firstNameTextBox;
        private Label dateOfBirthLabel;
        private Label lastNameLabel;
        private Label saloonNameLabel;
        private Panel headerPanel;
        private Button exitButton;
        private Label title;
        private NumericUpDown numericUpDownSeatingCapacity;
        private Label seatingCapacityLabel;
        private TextBox saloonNameTextBox;
        private Button saloonRecordButton;
        private GroupBox saloonRecordGroupBox;
        private FlowLayoutPanel flowLayoutPanelSaloon;
    }
}