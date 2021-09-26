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
    public partial class searchName : Form
    {
        public string firstName { get; set; }

        public string secondName { get; set; }

        public string thirdName { get; set; }

        public string firstSurname { get; set; }

        public string secondSurname { get; set; }
        public searchName()
        {
            InitializeComponent();
        }

        private void iconButtonRequest_Click(object sender, EventArgs e)
        {
            if (textBoxfirstName.Text!="")
            {
                firstName = textBoxfirstName.Text;
                this.Close();
            }
          
            secondName = textBoxfirstName.Text;
            thirdName = textBoxfirstName.Text;
            firstSurname = textBoxfirstName.Text;
            secondSurname = textBoxfirstName.Text;
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
