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
    public partial class FormHro : Form
    {
        private ClassPHro patient = new ClassPHro();
        public FormHro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable infoPatient = patient.getPatientsByHistoryNumber(textBox1.Text);
            dataGridView1.DataSource = infoPatient;
            dataGridView1.Refresh();
        }
    }
}
