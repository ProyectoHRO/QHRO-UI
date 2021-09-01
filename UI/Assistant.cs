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
    public partial class Assistant : Form
    {
        private ClassAssistants assistants;
        public Assistant()
        {
            InitializeComponent();
            assistants = new ClassAssistants();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataTable infoAssistants = assistants.getAssistants();
            dataGridView1.DataSource = infoAssistants;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Refresh();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            textFirstName.Clear();
            textSecondName.Clear();
            textThirdName.Clear();
            textFirstLastName.Clear();
            textSecondLastName.Clear();
            textEmail.Clear();
            textPhone.Clear();
            textCui.Clear();
            comboStatus.SelectedIndex = 0;
            buttonSave.Enabled = true;
            buttonNew.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textFirstName.Text != null && textFirstLastName.Text != null && textCui.Text != null && textEmail.Text != null && textPhone.Text != null)
            {
                string resp;
                resp = assistants.newAssistant(textFirstName.Text,textSecondName.Text,textThirdName.Text,textFirstLastName.Text,textSecondLastName.Text,textEmail.Text,
                    textPhone.Text,Convert.ToInt32(comboTypeAssistant.SelectedValue),textCui.Text);
                if (resp.ToUpper().Contains("ERROR"))
                    MessageBox.Show(resp, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(resp, "Registro Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Porfavor llena los campos");
            groupBox1.Enabled = false;
            textFirstName.Clear();
            textSecondName.Clear();
            textThirdName.Clear();
            textFirstLastName.Clear();
            textSecondLastName.Clear();
            textEmail.Clear();
            textPhone.Clear();
            textCui.Clear();
            comboStatus.SelectedIndex = 0;
            buttonSave.Enabled = true;
            buttonNew.Enabled = false;
        }

        private void Assistant_Load(object sender, EventArgs e)
        {
            DataTable infoTypeAssistant = assistants.getTypeAssistants();
            comboTypeAssistant.ValueMember = "id_tipo";
            comboTypeAssistant.DisplayMember = "nombre_tipo";
            comboTypeAssistant.DataSource = infoTypeAssistant;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Enabled = true;
            buttonNew.Enabled = true;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = true;
            groupBox2.Visible = true;
            bool status;
            try
            {
                labelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textFirstName.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textSecondName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textThirdName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textFirstLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textSecondLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                status= (bool)dataGridView1.Rows[e.RowIndex].Cells[8].Value;
                if (status == true)
                    comboStatus.SelectedIndex = 1;
                else
                    comboStatus.SelectedIndex = 2;
                comboTypeAssistant.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[9].Value;
                textCui.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch (Exception error)
            {
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool status=false;
            if (comboStatus.SelectedIndex != 0)
            {
                if (comboStatus.SelectedIndex == 1)
                    status = true;
                else if (comboStatus.SelectedIndex == 2)
                    status = false;
                string resp = assistants.updateAssistant(textFirstName.Text,textSecondName.Text,textThirdName.Text,textFirstLastName.Text,textSecondLastName.Text,textEmail.Text,
                    textPhone.Text, status, Convert.ToInt32(comboTypeAssistant.SelectedValue),textCui.Text,Convert.ToInt32(labelID.Text));
                if (resp.ToUpper().Contains("ERROR"))
                    MessageBox.Show(resp, "Error al Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(resp, "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Porfavor eleccione un estado (Activo/Inactivo)");
        }
    }
}
