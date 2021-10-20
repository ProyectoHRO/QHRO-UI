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
    public partial class getDates : Form
    {
        public DateTime firstDate { get; set; }
        public DateTime secondDate { get; set; }
        public getDates()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.firstDate = dateTimePickerFirstDate.Value;
            this.secondDate = dateTimePickerSecondDate.Value;
            this.Close();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
