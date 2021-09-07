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
    public partial class Patient : Form
    {
        private ClassPatient patients;
        public Patient()
        {
            InitializeComponent();
            patients = new ClassPatient();
        }

        void list()
        {
            dataGridView1.DataSource = patients.listPatients();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Refresh();
        }

        void clearText()
        {
            groupBoxpatientData.Enabled = true;
            textBoxhistoryNumber.Text = "";
            textBoxfirstName.Text = "";
            textBoxsecondName.Text = "";
            textBoxthirdName.Text = "";
            textBoxfirstSurname.Text = "";
            textBoxsecondSurname.Text = "";
            textBoxAge.Text = "";
            textBoxDiagnosis.Text = "";
            comboBoxGender.Text = "";
            comboBoxStatus.Text = "";
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            groupBoxpatientData.Enabled = false;
            iconButtonUpdate.Enabled = false;
            iconButtonSave.Enabled = false;
            labelStatus.Visible = false;
            comboBoxStatus.Visible = false;
        }

        private void iconButtonList_Click_1(object sender, EventArgs e)
        {
            list();
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = false;
            groupBoxpatientData.Enabled = false;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void iconButtonNew_Click_1(object sender, EventArgs e)
        {
            iconButtonSave.Enabled = true;
            iconButtonUpdate.Enabled = false;
            clearText();
            iconButtonNew.Enabled = false;
            labelStatus.Visible = false;
            comboBoxStatus.Visible = false;
        }

        private void iconButtonSave_Click_1(object sender, EventArgs e)
        {
            string resp;
            resp = patients.newPatient(textBoxhistoryNumber.Text, textBoxfirstName.Text, textBoxsecondName.Text,
                textBoxthirdName.Text, textBoxfirstSurname.Text, textBoxsecondSurname.Text, Convert.ToInt16(textBoxAge.Text),
                textBoxDiagnosis.Text, comboBoxGender.SelectedItem.ToString(),
            true);
            if (resp.ToUpper().Contains("ERROR"))
            {
                MessageBox.Show(resp, "Error al grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show(resp, "Nuevo paciente añadido ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
            }

            iconButtonNew.Enabled = true;
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                labelStatus.Visible = true;
                comboBoxStatus.Visible = true;
                groupBoxpatientData.Enabled = true;
                iconButtonUpdate.Enabled = true;
                iconButtonSave.Enabled = false;
                labelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxhistoryNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxfirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxsecondName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxthirdName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxfirstSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxsecondSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBoxAge.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBoxDiagnosis.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                comboBoxGender.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString() == "True")
                    comboBoxStatus.Text = "Activo";
                else if (dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString() == "False")
                    comboBoxStatus.Text = "Inactivo";
            }
            catch (Exception)
            {
            }
        }

        private void iconButtonUpdate_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(labelID.Text);
            bool status = false;
            if (comboBoxStatus.SelectedIndex == 0)
                status = true;
            else if (comboBoxStatus.SelectedIndex == 1)
            {
                status = false;
            }
            string resp = patients.editPatient(textBoxhistoryNumber.Text, textBoxfirstName.Text, textBoxsecondName.Text,
                textBoxthirdName.Text, textBoxfirstSurname.Text, textBoxsecondSurname.Text, Convert.ToInt16(textBoxAge.Text), 
                textBoxDiagnosis.Text, comboBoxGender.SelectedItem.ToString(),
            status, id);
            if (resp.ToUpper().Contains("ERROR"))
            {
                MessageBox.Show(resp, "Error al actualizar datos del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show(resp, "Datos del paciente actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxfirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxsecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxthirdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxfirstSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxsecondSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
