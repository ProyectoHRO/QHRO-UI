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
    public partial class Doctors : Form
    {
        private ClassDoctor doctors = new ClassDoctor();
        private ClassSpecialitie specialitie = new ClassSpecialitie();
        int userId;
        public Doctors(int idUser)
        {
            InitializeComponent();
            userId = idUser;
        }
        void listDoctors()
        {
            DataTable infoDoctors = doctors.getDoctors();
            dataGridView1.DataSource = infoDoctors;
            dataGridView1.Columns[1].HeaderText = "CUI";
            dataGridView1.Columns[2].HeaderText = "Primer nombre";
            dataGridView1.Columns[3].HeaderText = "Segundo nombre";
            dataGridView1.Columns[4].HeaderText = "Tercer nombre";
            dataGridView1.Columns[5].HeaderText = "Primer apellido";
            dataGridView1.Columns[6].HeaderText = "Segundo apellido";
            dataGridView1.Columns[7].HeaderText = "Telefono";
            dataGridView1.Columns[8].HeaderText = "Correo";
            dataGridView1.Columns[10].HeaderText = "Especialidad";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Refresh();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            
        }
        
        private void buttonNew_Click(object sender, EventArgs e)
        {
            groupBoxDoctorsData.Enabled = true;
            textFirstName.Clear();
            textSecondName.Clear();
            textThirdName.Clear();
            textFirstLastName.Clear();
            textSecondLastName.Clear();
            textEmail.Clear();
            textPhone.Clear();
            textCui.Clear();
            comboStatus.SelectedIndex = 0;
            iconButtonSave.Enabled = true;
            iconButtonNew.Enabled = false;
            iconButtonUpdate.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {         
            bool status;
            try
            {
                labelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textCui.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textSecondName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textThirdName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textFirstLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textSecondLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                status = (bool)dataGridView1.Rows[e.RowIndex].Cells[9].Value;
                if (status == true)
                    comboStatus.SelectedIndex = 1;
                else
                    comboStatus.SelectedIndex = 2;
                comboBoxSpecialty.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

                groupBoxDoctorsData.Enabled = true;
                iconButtonNew.Enabled = true;
                iconButtonSave.Enabled = false;
                iconButtonUpdate.Enabled = true;
                comboStatus.Visible = true;
                labelStatus.Visible = true;
            }
            catch (Exception)
            {
            }
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            groupBoxDoctorsData.Enabled = false;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = false;
            listDoctors();
            DataTable infoSpecialities = specialitie.getSpecialities();
            comboBoxSpecialty.ValueMember = "id_especialidad";
            comboBoxSpecialty.DisplayMember = "nombre_especialidad";
            comboBoxSpecialty.DataSource = infoSpecialities;
            comboBoxSpecialty.Text = " ";
        }
        public void regeXp(string re, TextBox tb, PictureBox pc)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.check;
                label1.Text = "v";
            }
            else
            {
                pc.Image = Properties.Resources.x;
                label1.Text = "f";
            }
        }
        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            regeXp(@"^[aA-zZ0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[aA-zZ0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[aA-zZ0-9](?:[aA-zZ0-9-]*[aA-zZ0-9])?\.)+[aA-zZ0-9](?:[aA-zZ0-9-]*[aA-zZ0-9])?$", textEmail, boxValidateMail);
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void iconButtonNew_Click(object sender, EventArgs e)
        {
            groupBoxDoctorsData.Enabled = true;
            textFirstName.Clear();
            textSecondName.Clear();
            textThirdName.Clear();
            textFirstLastName.Clear();
            textSecondLastName.Clear();
            textEmail.Clear();
            textPhone.Clear();
            textCui.Clear();
            comboStatus.SelectedIndex = 0;
            iconButtonSave.Enabled = true;
            iconButtonNew.Enabled = false;
            iconButtonUpdate.Enabled = false;
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            int state=0;
            if (label1.Text=="v" || textEmail.Text=="")
            {
                state = 1;
            }
            if (state==1)
            {
                if (textFirstName.Text != null && textFirstLastName.Text != null && textCui.Text != null && textEmail.Text != null && textPhone.Text != null)
                {
                    string resp;
                    resp = doctors.newDoctor(userId,textCui.Text, textFirstName.Text, textSecondName.Text, textThirdName.Text, textFirstLastName.Text, textSecondLastName.Text,
                        textPhone.Text, textEmail.Text,comboBoxSpecialty.Text);
                    if (resp.ToUpper().Contains("ERROR"))
                        MessageBox.Show(resp, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(resp, "Registro Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Porfavor llena los campos");
                groupBoxDoctorsData.Enabled = false;
                textFirstName.Clear();
                textSecondName.Clear();
                textThirdName.Clear();
                textFirstLastName.Clear();
                textSecondLastName.Clear();
                textEmail.Clear();
                textPhone.Clear();
                textCui.Clear();
                listDoctors();
                comboStatus.SelectedIndex = 0;
                iconButtonSave.Enabled = false;
                iconButtonNew.Enabled = true;
                labelStatus.Visible = false;
                comboStatus.Visible = false;
                dataGridView1.Refresh();
                state = 0;
            }
            else
            {
                MessageBox.Show("Datos incompletos o erroneos. Por Favor revisar la informacion");
            }
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            int state = 0;
            if (label1.Text == "v" || textEmail.Text == "")
                state = 1;
            if (state == 1)
            {
                bool status = false;
                if (comboStatus.SelectedIndex != 0)
                {
                    if (comboStatus.SelectedIndex == 1)
                        status = true;
                    else if (comboStatus.SelectedIndex == 2)
                        status = false;
                    string resp = doctors.updateDoctor(userId,textCui.Text, textFirstName.Text, textSecondName.Text, textThirdName.Text, textFirstLastName.Text,
                        textSecondLastName.Text, textPhone.Text, textEmail.Text, status, comboBoxSpecialty.Text, Convert.ToInt32(labelID.Text));
                    if (resp.ToUpper().Contains("ERROR"))
                        MessageBox.Show(resp, "Error al Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(resp, "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    groupBoxDoctorsData.Enabled = false;
                    textFirstName.Clear();
                    textSecondName.Clear();
                    textThirdName.Clear();
                    textFirstLastName.Clear();
                    textSecondLastName.Clear();
                    textEmail.Clear();
                    textPhone.Clear();
                    textCui.Clear();
                    listDoctors();
                    iconButtonUpdate.Enabled = false;
                    comboStatus.SelectedIndex = 0;
                    iconButtonSave.Enabled = false;
                    iconButtonNew.Enabled = true;
                    labelStatus.Visible = false;
                    comboStatus.Visible = false;
                    state = 0;
                }
                else
                    MessageBox.Show("Porfavor eleccione un estado (Activo/Inactivo)");
            }
            else
                MessageBox.Show("Datos incompletos o erroneos. Por Favor revisar la informacion");
        }

        private void iconButtonList_Click(object sender, EventArgs e)
        {
            listDoctors();
            listDoctors();
        }

        private void textFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textThirdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textFirstLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textSecondLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Doctors_Resize(object sender, EventArgs e)
        {
            listDoctors();
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxDoctorsData_Enter(object sender, EventArgs e)
        {

        }

        private void textCui_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
