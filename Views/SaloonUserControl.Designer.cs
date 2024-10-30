namespace cinemaAutomation.Views
{
    partial class SaloonUserControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaloonUserControlForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelSaloonName = new Label();
            labelSeatingCapacity = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 153, 153);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 95);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelSaloonName
            // 
            labelSaloonName.AutoSize = true;
            labelSaloonName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelSaloonName.ForeColor = Color.FromArgb(0, 153, 153);
            labelSaloonName.Location = new Point(112, 14);
            labelSaloonName.Name = "labelSaloonName";
            labelSaloonName.Size = new Size(53, 23);
            labelSaloonName.TabIndex = 2;
            labelSaloonName.Text = "label1";
            // 
            // labelSeatingCapacity
            // 
            labelSeatingCapacity.AutoSize = true;
            labelSeatingCapacity.Font = new Font("Segoe UI Semibold", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelSeatingCapacity.ForeColor = Color.HotPink;
            labelSeatingCapacity.Location = new Point(218, 57);
            labelSeatingCapacity.Name = "labelSeatingCapacity";
            labelSeatingCapacity.Size = new Size(15, 17);
            labelSeatingCapacity.TabIndex = 3;
            labelSeatingCapacity.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.5F);
            label1.ForeColor = Color.HotPink;
            label1.Location = new Point(112, 57);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 4;
            label1.Text = "Seating Number: ";
            // 
            // SaloonUserControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label1);
            Controls.Add(labelSeatingCapacity);
            Controls.Add(labelSaloonName);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "SaloonUserControlForm";
            Size = new Size(252, 95);
            MouseLeave += SaloonUserControl_MouseLeave;
            MouseHover += SaloonUserControl_MouseHover;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public Label labelSaloonName;
        public Label labelSeatingCapacity;
        private Label label1;
    }
}
