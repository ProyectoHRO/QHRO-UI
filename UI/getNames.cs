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
    public partial class getNames : Form
    {
        public string firstName { get; set; }

        public string secondName { get; set; }
        public string thirdName { get; set; }
        public string firstSurname { get; set; }
        public string secondSurname { get; set; }
        public getNames()
        {
            InitializeComponent();
        }

        private void iconButtonContinue_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            secondName = textBoxSecondName.Text;
            thirdName = textBoxThirdName.Text;
            firstSurname = textBoxFirstSurname.Text;
            secondSurname = textBoxSecondSurname.Text;
            this.Close();
        }
    }
}
