using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class Patient : Form
    {
        private ClassPatient patients= new ClassPatient();
        public Patient()
        {
            InitializeComponent();
            
        }

        void listPatients()
        {
            dataGridView1.DataSource = patients.listPatients();
            dataGridView1.Columns[1].HeaderText = "Numero de historia";
            dataGridView1.Columns[2].HeaderText = "Primer nombre";
            dataGridView1.Columns[3].HeaderText = "Segundo nombre";
            dataGridView1.Columns[4].HeaderText = "Tercer nombre";
            dataGridView1.Columns[5].HeaderText = "Primer apellido";
            dataGridView1.Columns[6].HeaderText = "Segundo apellido";
            dataGridView1.Columns[7].HeaderText = "Edad";
            dataGridView1.Columns[8].HeaderText = "Genero";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
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

            listPatients();
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = false;
            groupBoxpatientData.Enabled = false;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void iconButtonList_Click_1(object sender, EventArgs e)
        {
            listPatients();
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
            int state = 0;
            if (label1.Text == "v")
                state = 1;
            if (state == 1)
            {
                string resp;
                resp = patients.newPatient(textBoxhistoryNumber.Text, textBoxfirstName.Text, textBoxsecondName.Text,
                    textBoxthirdName.Text, textBoxfirstSurname.Text, textBoxsecondSurname.Text, Convert.ToInt16(textBoxAge.Text),
                    comboBoxGender.SelectedItem.ToString());
                if (resp.ToUpper().Contains("ERROR"))
                {
                    MessageBox.Show(resp, "Error al grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show(resp, "Nuevo paciente añadido ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listPatients();
                }

                iconButtonNew.Enabled = true;
            }
           
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
                comboBoxGender.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString() == "True")
                    comboBoxStatus.Text = "Activo";
                else if (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString() == "False")
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
                comboBoxGender.SelectedItem.ToString(),
                status, id);
            if (resp.ToUpper().Contains("ERROR"))
            {
                MessageBox.Show(resp, "Error al actualizar datos del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show(resp, "Datos del paciente actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listPatients();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Patient_Resize(object sender, EventArgs e)
        {
            listPatients();
        }

        private void textBoxhistoryNumber_TextChanged(object sender, EventArgs e)
        {
            regeXp("[A-Za-z0-9-]+", textBoxhistoryNumber);
        }

        public void regeXp(string re, TextBox tb)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                label1.Text = "v";
            }
            else
            {
                label1.Text = "f";
            }
        }
    }
}
