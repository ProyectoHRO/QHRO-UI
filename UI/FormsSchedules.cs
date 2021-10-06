using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormsSchedules : Form
    {
        public FormsSchedules()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void iconButtonDiffer_Click(object sender, EventArgs e)
        {
            FormDiffers fDiffers = new FormDiffers();
            fDiffers.Show();
        }
    }
}
