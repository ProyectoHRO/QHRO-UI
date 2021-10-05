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
    public partial class FormUserPermits : Form
    {
        public FormUserPermits()
        {
            InitializeComponent();
        }

        private void FormUserPermits_Load(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = 1;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 0)
            {
                textBoxSearch.Text = "BUSCAR POR USUARIO";
            }else if (comboBoxFilter.SelectedIndex == 1)
            {
                textBoxSearch.Text = "BUSCAR POR CORREO";
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != " ")
                textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 0)
            {
                textBoxSearch.Text = "BUSCAR POR USUARIO";
            }
            else if (comboBoxFilter.SelectedIndex == 1)
            {
                textBoxSearch.Text = "BUSCAR POR CORREO";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
