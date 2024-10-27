namespace cinemaAutomation.Views
{
    partial class DirectorListForm
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
            panel1 = new Panel();
            fullNameTextBoxForSearch = new TextBox();
            fullNameLabelForSearch = new Label();
            panel2 = new Panel();
            listPanel = new FlowLayoutPanel();
            headerPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            headerPanel.TabIndex = 3;
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
            title.Size = new Size(193, 45);
            title.TabIndex = 0;
            title.Text = "Director List";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(fullNameTextBoxForSearch);
            panel1.Controls.Add(fullNameLabelForSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 56);
            panel1.TabIndex = 4;
            // 
            // fullNameTextBoxForSearch
            // 
            fullNameTextBoxForSearch.Location = new Point(234, 16);
            fullNameTextBoxForSearch.Name = "fullNameTextBoxForSearch";
            fullNameTextBoxForSearch.Size = new Size(208, 27);
            fullNameTextBoxForSearch.TabIndex = 1;
            fullNameTextBoxForSearch.TextChanged += fullNameTextBoxForSearch_TextChanged;
            // 
            // fullNameLabelForSearch
            // 
            fullNameLabelForSearch.AutoSize = true;
            fullNameLabelForSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            fullNameLabelForSearch.ForeColor = Color.FromArgb(0, 153, 153);
            fullNameLabelForSearch.Location = new Point(87, 16);
            fullNameLabelForSearch.Name = "fullNameLabelForSearch";
            fullNameLabelForSearch.Size = new Size(83, 23);
            fullNameLabelForSearch.TabIndex = 0;
            fullNameLabelForSearch.Text = "FullName";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(listPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 386);
            panel2.TabIndex = 5;
            // 
            // listPanel
            // 
            listPanel.AutoScroll = true;
            listPanel.Dock = DockStyle.Fill;
            listPanel.Location = new Point(0, 0);
            listPanel.Name = "listPanel";
            listPanel.Size = new Size(571, 386);
            listPanel.TabIndex = 0;
            // 
            // DirectorListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 498);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(headerPanel);
            Location = new Point(500, 200);
            Name = "DirectorListForm";
            StartPosition = FormStartPosition.Manual;
            Text = "DirectorListForm";
            Load += DirectorListForm_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Button exitButton;
        private Label title;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel listPanel;
        private Label fullNameLabelForSearch;
        private TextBox fullNameTextBoxForSearch;
    }
}