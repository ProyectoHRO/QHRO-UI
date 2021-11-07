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
    public partial class FormSpecialtiesDoctors : Form
    {
        private ClassSpecialitie specialitie = new ClassSpecialitie();
        public FormSpecialtiesDoctors()
        {
            InitializeComponent();
        }

        void ListSpecialities()
        {
            DataTable specialitiesList = specialitie.getSpecialities();
            dataGridViewSpecialties.DataSource = specialitiesList;
            dataGridViewSpecialties.Columns[0].Visible = false;
            dataGridViewSpecialties.Columns[1].HeaderText = "Especialidad";
            dataGridViewSpecialties.AutoResizeColumns();
            dataGridViewSpecialties.Refresh();
        }

        private void iconButtonNew_Click(object sender, EventArgs e)
        {
            groupBoxSpecialities.Enabled = true;
            textBoxNameSpecialties.Clear();
            iconButtonSave.Enabled = true;
            iconButtonNew.Enabled = false;
            iconButtonUpdate.Enabled = false;
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNameSpecialties.Text != null)
            {
                string resp;
                resp = specialitie.insertSpecialitie(textBoxNameSpecialties.Text);
                if (resp.ToUpper().Contains("ERROR"))
                    MessageBox.Show(resp, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show(resp, "Registro Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBoxSpecialities.Enabled = false;
                    textBoxNameSpecialties.Clear();
                    iconButtonSave.Enabled = true;
                    iconButtonNew.Enabled = false;
                    ListSpecialities();
                }

            }
            else
                MessageBox.Show("Por favor llena los campos");
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            string resp = specialitie.updateSpecialitie(textBoxNameSpecialties.Text, Convert.ToInt16(labelID.Text));
            if (resp.ToUpper().Contains("ERROR"))
                MessageBox.Show(resp, "Error al Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(resp, "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBoxSpecialities.Enabled = false;
            textBoxNameSpecialties.Clear();
            ListSpecialities();
            iconButtonUpdate.Enabled = false;
            iconButtonSave.Enabled = false;
            iconButtonNew.Enabled = true;
        }

        private void dataGridViewSpecialties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBoxSpecialities.Enabled = true;
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = true;
            bool status;
            try
            {
                labelID.Text = dataGridViewSpecialties.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNameSpecialties.Text = dataGridViewSpecialties.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void FormSpecialtiesDoctors_Load(object sender, EventArgs e)
        {
            ListSpecialities();
        }
    }
}
