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
        private Surgeries surgeries = new Surgeries();
        int typeA, idSurgerie;
        public FormDiffers(int typeAction, int idSurgeriee, string pacientName)
        {
            InitializeComponent();
            idSurgerie = idSurgeriee;
            typeA = typeAction;
            textBoxName.Text = pacientName;
            textBoxName.ReadOnly = true; 
            if (typeAction==1)
            {
                NewDate.Visible = true;
                dateTimePickerNewDate.Visible = true;
            
                label1.Text = "Reprogramar";
            }
            else
            {
                label1.Text = "Diferir";
                labelDiff.Visible = true;
                textBoxDetail.Visible = true;
            }
        }

        private void iconButtonContinue_Click(object sender, EventArgs e)
        {
            if (typeA==1)
            {//ReSchedule
                string resp = surgeries.reSchedule(idSurgerie,dateTimePickerNewDate.Value);
                MessageBox.Show(resp);
                this.Close();
            }
            else
            {//Diff
                string resp = surgeries.diffSurgerie(idSurgerie, textBoxDetail.Text);
                MessageBox.Show(resp);
                this.Close();
            }
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDiffers_Load(object sender, EventArgs e)
        {

        }
    }
}
