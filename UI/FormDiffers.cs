using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace UI
{
    public partial class FormDiffers : Form
    {
        private ClassOperatingRoom operatingRooms = new ClassOperatingRoom();
        private Surgeries surgeries = new Surgeries();
        int typeA, idSurgerie;
        public FormDiffers(int idSurgeriee, string pacientName)
        {
            InitializeComponent();
            idSurgerie = idSurgeriee;
            textBoxName.Text = pacientName;
            textBoxName.ReadOnly = true;
           
        }

        private void iconButtonContinue_Click(object sender, EventArgs e)
        {
                string resp = surgeries.diffSurgerie(idSurgerie, textBoxDetail.Text);
                MessageBox.Show(resp);
                this.Close();
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDiffers_Load(object sender, EventArgs e)
        {

        }
    }
}
