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
    public partial class FormTypesOfAnesthesia : Form
    {
        private ClassAnesthesia anesthesia = new ClassAnesthesia();
        public FormTypesOfAnesthesia()
        {
            InitializeComponent();
        }

        void ListAnestesiaTypes()
        {
            DataTable AnestesiaTypeList = anesthesia.getAnesthesia();
            dataGridTypesAnesthesia.DataSource = AnestesiaTypeList;
            dataGridTypesAnesthesia.Columns[0].Visible = false;
            dataGridTypesAnesthesia.Columns[1].HeaderText = "Tipo de Anestesia";
            dataGridTypesAnesthesia.AutoResizeColumns();
            dataGridTypesAnesthesia.Refresh();
        }


        private void FormTypesOfAnesthesia_Load(object sender, EventArgs e)
        {
            ListAnestesiaTypes();
        }

        private void FormTypesOfAnesthesia_Resize(object sender, EventArgs e)
        {
            ListAnestesiaTypes();
        }

        private void iconButtonNew_Click(object sender, EventArgs e)
        {
            groupBoxAnesthesia.Enabled = true;
            textBoxNameAnesthesia.Clear();
            iconButtonSave.Enabled = true;
            iconButtonNew.Enabled = false;
            iconButtonUpdate.Enabled = false;
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNameAnesthesia.Text != null)
            {
                string resp;
                resp = anesthesia.newAnesthesiaType(textBoxNameAnesthesia.Text);
                if (resp.ToUpper().Contains("ERROR"))
                    MessageBox.Show(resp, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show(resp, "Registro Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBoxAnesthesia.Enabled = false;
                    textBoxNameAnesthesia.Clear();
                    iconButtonSave.Enabled = true;
                    iconButtonNew.Enabled = false;
                    ListAnestesiaTypes();
                }

            }
            else
                MessageBox.Show("Por favor llena los campos");
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            string resp = anesthesia.updateAnesthesiaType(textBoxNameAnesthesia.Text, Convert.ToInt16(labelID.Text));
            if (resp.ToUpper().Contains("ERROR"))
                MessageBox.Show(resp, "Error al Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(resp, "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBoxAnesthesia.Enabled = false;
            textBoxNameAnesthesia.Clear();
            ListAnestesiaTypes();
            iconButtonUpdate.Enabled = false;
            iconButtonSave.Enabled = false;
            iconButtonNew.Enabled = true;
        }

        private void dataGridTypesAnesthesia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            bool status;
            try
            {
                labelID.Text = dataGridTypesAnesthesia.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNameAnesthesia.Text = dataGridTypesAnesthesia.Rows[e.RowIndex].Cells[1].Value.ToString();
                groupBoxAnesthesia.Enabled = true;
                iconButtonNew.Enabled = true;
                iconButtonSave.Enabled = false;
                iconButtonUpdate.Enabled = true;
            }
            catch (Exception)
            {
            }
        }
    }
}
