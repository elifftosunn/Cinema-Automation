namespace cinemaAutomation
{
    partial class MainForm
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
            headerPanel = new Panel();
            exitButton = new Button();
            title = new Label();
            leftPanel = new Panel();
            gamerRecordButton = new Button();
            listDirectorPanel = new Panel();
            directorListButton = new Button();
            recordDirectorPanel = new Panel();
            recordDirectorButton = new Button();
            footerPanel = new Panel();
            headerPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            listDirectorPanel.SuspendLayout();
            recordDirectorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 153, 153);
            headerPanel.BorderStyle = BorderStyle.Fixed3D;
            headerPanel.Controls.Add(exitButton);
            headerPanel.Controls.Add(title);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(663, 56);
            headerPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Firebrick;
            exitButton.Dock = DockStyle.Right;
            exitButton.FlatAppearance.BorderColor = Color.Black;
            exitButton.FlatAppearance.BorderSize = 100;
            exitButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            exitButton.Location = new Point(606, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(53, 52);
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
            title.Size = new Size(173, 45);
            title.TabIndex = 0;
            title.Text = "MovieSync";
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(0, 153, 153);
            leftPanel.Controls.Add(gamerRecordButton);
            leftPanel.Controls.Add(listDirectorPanel);
            leftPanel.Controls.Add(recordDirectorPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 56);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(225, 399);
            leftPanel.TabIndex = 2;
            // 
            // gamerRecordButton
            // 
            gamerRecordButton.AccessibleRole = AccessibleRole.None;
            gamerRecordButton.BackColor = Color.FromArgb(0, 153, 153);
            gamerRecordButton.Dock = DockStyle.Top;
            gamerRecordButton.FlatAppearance.BorderSize = 0;
            gamerRecordButton.FlatStyle = FlatStyle.Flat;
            gamerRecordButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gamerRecordButton.Location = new Point(0, 82);
            gamerRecordButton.Name = "gamerRecordButton";
            gamerRecordButton.Padding = new Padding(5);
            gamerRecordButton.Size = new Size(225, 38);
            gamerRecordButton.TabIndex = 2;
            gamerRecordButton.Text = "Gamer Record";
            gamerRecordButton.UseVisualStyleBackColor = false;
            gamerRecordButton.Click += gamerRecordButton_Click;
            // 
            // listDirectorPanel
            // 
            listDirectorPanel.BackColor = Color.White;
            listDirectorPanel.Controls.Add(directorListButton);
            listDirectorPanel.Dock = DockStyle.Top;
            listDirectorPanel.Location = new Point(0, 41);
            listDirectorPanel.Name = "listDirectorPanel";
            listDirectorPanel.Size = new Size(225, 41);
            listDirectorPanel.TabIndex = 1;
            // 
            // directorListButton
            // 
            directorListButton.AccessibleRole = AccessibleRole.None;
            directorListButton.BackColor = Color.FromArgb(0, 153, 153);
            directorListButton.Dock = DockStyle.Top;
            directorListButton.FlatAppearance.BorderSize = 0;
            directorListButton.FlatStyle = FlatStyle.Flat;
            directorListButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            directorListButton.Location = new Point(0, 0);
            directorListButton.Name = "directorListButton";
            directorListButton.Padding = new Padding(5);
            directorListButton.Size = new Size(225, 38);
            directorListButton.TabIndex = 0;
            directorListButton.Text = "Director List";
            directorListButton.UseVisualStyleBackColor = false;
            directorListButton.Click += directorListButton_Click;
            // 
            // recordDirectorPanel
            // 
            recordDirectorPanel.BackColor = Color.White;
            recordDirectorPanel.Controls.Add(recordDirectorButton);
            recordDirectorPanel.Dock = DockStyle.Top;
            recordDirectorPanel.Location = new Point(0, 0);
            recordDirectorPanel.Name = "recordDirectorPanel";
            recordDirectorPanel.Size = new Size(225, 41);
            recordDirectorPanel.TabIndex = 0;
            // 
            // recordDirectorButton
            // 
            recordDirectorButton.AccessibleRole = AccessibleRole.None;
            recordDirectorButton.BackColor = Color.FromArgb(0, 153, 153);
            recordDirectorButton.Dock = DockStyle.Top;
            recordDirectorButton.FlatAppearance.BorderSize = 0;
            recordDirectorButton.FlatStyle = FlatStyle.Flat;
            recordDirectorButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            recordDirectorButton.Location = new Point(0, 0);
            recordDirectorButton.Name = "recordDirectorButton";
            recordDirectorButton.Padding = new Padding(5);
            recordDirectorButton.Size = new Size(225, 38);
            recordDirectorButton.TabIndex = 0;
            recordDirectorButton.Text = "Director Record";
            recordDirectorButton.UseVisualStyleBackColor = false;
            recordDirectorButton.Click += recordDirectorButton_Click;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(0, 153, 153);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(225, 415);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(438, 40);
            footerPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 455);
            Controls.Add(footerPanel);
            Controls.Add(leftPanel);
            Controls.Add(headerPanel);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            listDirectorPanel.ResumeLayout(false);
            recordDirectorPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Button exitButton;
        private Label title;
        private Panel leftPanel;
        private Panel footerPanel;
        private Panel recordDirectorPanel;
        private Button recordDirectorButton;
        private Panel listDirectorPanel;
        private Button directorListButton;
        private Button gamerRecordButton;
    }
}