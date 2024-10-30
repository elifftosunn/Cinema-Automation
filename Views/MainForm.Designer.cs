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
            panel2 = new Panel();
            gamerListButton = new Button();
            panel1 = new Panel();
            gamerRecordButton = new Button();
            listDirectorPanel = new Panel();
            directorListButton = new Button();
            recordDirectorPanel = new Panel();
            recordDirectorButton = new Button();
            footerPanel = new Panel();
            panel3 = new Panel();
            saloonRecordButton = new Button();
            headerPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            listDirectorPanel.SuspendLayout();
            recordDirectorPanel.SuspendLayout();
            panel3.SuspendLayout();
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
            leftPanel.Controls.Add(panel3);
            leftPanel.Controls.Add(panel2);
            leftPanel.Controls.Add(panel1);
            leftPanel.Controls.Add(listDirectorPanel);
            leftPanel.Controls.Add(recordDirectorPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 56);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(225, 399);
            leftPanel.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(gamerListButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 41);
            panel2.TabIndex = 4;
            // 
            // gamerListButton
            // 
            gamerListButton.AccessibleRole = AccessibleRole.None;
            gamerListButton.BackColor = Color.FromArgb(0, 153, 153);
            gamerListButton.Dock = DockStyle.Top;
            gamerListButton.FlatAppearance.BorderSize = 0;
            gamerListButton.FlatStyle = FlatStyle.Flat;
            gamerListButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gamerListButton.Location = new Point(0, 0);
            gamerListButton.Name = "gamerListButton";
            gamerListButton.Padding = new Padding(5);
            gamerListButton.Size = new Size(225, 38);
            gamerListButton.TabIndex = 0;
            gamerListButton.Text = "Gamer List";
            gamerListButton.UseVisualStyleBackColor = false;
            gamerListButton.Click += gamerListButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(gamerRecordButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 41);
            panel1.TabIndex = 3;
            // 
            // gamerRecordButton
            // 
            gamerRecordButton.AccessibleRole = AccessibleRole.None;
            gamerRecordButton.BackColor = Color.FromArgb(0, 153, 153);
            gamerRecordButton.Dock = DockStyle.Top;
            gamerRecordButton.FlatAppearance.BorderSize = 0;
            gamerRecordButton.FlatStyle = FlatStyle.Flat;
            gamerRecordButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gamerRecordButton.Location = new Point(0, 0);
            gamerRecordButton.Name = "gamerRecordButton";
            gamerRecordButton.Padding = new Padding(5);
            gamerRecordButton.Size = new Size(225, 38);
            gamerRecordButton.TabIndex = 0;
            gamerRecordButton.Text = "Gamer Record";
            gamerRecordButton.UseVisualStyleBackColor = false;
            gamerRecordButton.Click += gamerRecordButton_Click_1;
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(saloonRecordButton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 41);
            panel3.TabIndex = 5;
            // 
            // saloonRecordButton
            // 
            saloonRecordButton.AccessibleRole = AccessibleRole.None;
            saloonRecordButton.BackColor = Color.FromArgb(0, 153, 153);
            saloonRecordButton.Dock = DockStyle.Top;
            saloonRecordButton.FlatAppearance.BorderSize = 0;
            saloonRecordButton.FlatStyle = FlatStyle.Flat;
            saloonRecordButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            saloonRecordButton.Location = new Point(0, 0);
            saloonRecordButton.Name = "saloonRecordButton";
            saloonRecordButton.Padding = new Padding(5);
            saloonRecordButton.Size = new Size(225, 38);
            saloonRecordButton.TabIndex = 0;
            saloonRecordButton.Text = "Saloon Record";
            saloonRecordButton.UseVisualStyleBackColor = false;
            saloonRecordButton.Click += saloonRecordButton_Click;
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
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            listDirectorPanel.ResumeLayout(false);
            recordDirectorPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private Panel panel2;
        private Button gamerListButton;
        private Panel panel1;
        private Button gamerRecordButton;
        private Panel panel3;
        private Button saloonRecordButton;
    }
}