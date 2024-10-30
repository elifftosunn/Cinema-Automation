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
    public partial class SaloonUserControlForm : UserControl
    {
        public SaloonUserControlForm()
        {
            InitializeComponent();
        }

        private void SaloonUserControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void SaloonUserControl_MouseLeave(object sender, EventArgs e)
        {
            //labelSaloonName.ForeColor = Color.FromArgb(0, 153, 153);
            this.BackColor= Color.WhiteSmoke;
        }
    }
}
