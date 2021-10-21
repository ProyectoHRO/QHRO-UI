using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
namespace UI
{
    public partial class Assistant : Form
    {
        private ClassAssistants assistants = new ClassAssistants();
        public Assistant()
        {
            InitializeComponent();
        }

        void listAsistants()
        {
            DataTable infoAssistants = assistants.getAssistants();
            dataGridView2.DataSource = infoAssistants;
            dataGridView2.Columns[1].HeaderText = "CUI";
            dataGridView2.Columns[2].HeaderText = "Primer nombre";
            dataGridView2.Columns[3].HeaderText = "Segundo nombre";
            dataGridView2.Columns[4].HeaderText = "Tercer nombre";
            dataGridView2.Columns[5].HeaderText = "Primer apellido";
            dataGridView2.Columns[6].HeaderText = "Segundo apellido";
            dataGridView2.Columns[7].HeaderText = "Correo";
            dataGridView2.Columns[8].HeaderText = "Telefono";
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();
            dataGridView2.Refresh();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataTable infoAssistants = assistants.getAssistants();
            dataGridView2.DataSource = infoAssistants;
            dataGridView2.AutoResizeColumns();
            dataGridView2.Refresh();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            comboStatus.Visible = false;
            groupBoxAssistantData.Enabled = true;
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
            groupBoxAssistantData.Enabled = false;
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
        }

        private void Assistant_Load(object sender, EventArgs e)
        {
            DataTable infoTypeAssistant = assistants.getTypeAssistants();
            comboTypeAssistant.ValueMember = "id_tipo";
            comboTypeAssistant.DisplayMember = "nombre_tipo";
            comboTypeAssistant.DataSource = infoTypeAssistant;

            comboStatus.Visible = false;
            groupBoxAssistantData.Enabled = false;
            labelStatus.Visible = false;
            iconButtonUpdate.Enabled = false;
            iconButtonSave.Enabled = false;

            listAsistants();
            listAsistants();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelStatus.Visible = true;
            comboStatus.Visible = true;
            groupBoxAssistantData.Enabled = true;
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = true;
            bool status;
            try
            {
                labelID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                textFirstName.Text= dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                textSecondName.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                textThirdName.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                textFirstLastName.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                textSecondLastName.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                textEmail.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                textPhone.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
                status= (bool)dataGridView2.Rows[e.RowIndex].Cells[9].Value;
                if (status == true)
                    comboStatus.SelectedIndex = 1;
                else
                    comboStatus.SelectedIndex = 2;
                comboTypeAssistant.SelectedValue = dataGridView2.Rows[e.RowIndex].Cells[10].Value;
                textCui.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
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

        private void textCui_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonNew_Click(object sender, EventArgs e)
        {
            comboStatus.Visible = false;
            groupBoxAssistantData.Enabled = true;
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

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            int state = 0;
            if (label1.Text == "v" || textEmail.Text == "")
                state = 1;
            if (state==1)
            {
                bool status = false;
                if (comboStatus.SelectedIndex != 0)
                {
                    if (comboStatus.SelectedIndex == 1)
                        status = true;
                    else if (comboStatus.SelectedIndex == 2)
                        status = false;
                    string resp = assistants.updateAssistant(textFirstName.Text, textSecondName.Text, textThirdName.Text, textFirstLastName.Text, textSecondLastName.Text, textEmail.Text,
                        textPhone.Text, status, Convert.ToInt32(comboTypeAssistant.SelectedValue), textCui.Text, Convert.ToInt32(labelID.Text));
                    if (resp.ToUpper().Contains("ERROR"))
                        MessageBox.Show(resp, "Error al Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(resp, "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBoxAssistantData.Enabled = false;
                    textFirstName.Clear();
                    textSecondName.Clear();
                    textThirdName.Clear();
                    textFirstLastName.Clear();
                    textSecondLastName.Clear();
                    textEmail.Clear();
                    textPhone.Clear();
                    textCui.Clear();
                    listAsistants();
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

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            int state = 0;
            if (label1.Text == "v" || textEmail.Text == "")
            {
                state = 1;
            }
            if (state == 1)
            {
                if (textFirstName.Text != null && textFirstLastName.Text != null && textCui.Text != null && textEmail.Text != null && textPhone.Text != null)
                {
                    string resp;
                    resp = assistants.newAssistant(
                        textFirstName.Text,
                        textSecondName.Text,
                        textThirdName.Text, 
                        textFirstLastName.Text,
                        textSecondLastName.Text,
                        textEmail.Text,
                        textPhone.Text,
                        Convert.ToInt32(comboTypeAssistant.SelectedValue),
                        textCui.Text);
                    if (resp.ToUpper().Contains("ERROR"))
                        MessageBox.Show(resp, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(resp, "Registro Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Porfavor llena los campos");
                groupBoxAssistantData.Enabled = false;
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
                state = 0;
                listAsistants();
            }
            else
            {
                MessageBox.Show("Datos incompletos o erroneos. Por Favor revisar la informacion");
            }
               
        }

        private void iconButtonList_Click(object sender, EventArgs e)
        {
            listAsistants();
            listAsistants();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboStatus.Visible = true;
            groupBoxAssistantData.Enabled = true;
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = true;
            labelStatus.Visible = true;
            bool status;
            try
            {
                labelID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                textFirstName.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                textSecondName.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                textThirdName.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                textFirstLastName.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                textSecondLastName.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                textEmail.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                textPhone.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                status = (bool)dataGridView2.Rows[e.RowIndex].Cells[8].Value;
                if (status == true)
                    comboStatus.SelectedIndex = 1;
                else
                    comboStatus.SelectedIndex = 2;
                comboTypeAssistant.SelectedValue = dataGridView2.Rows[e.RowIndex].Cells[9].Value;
                textCui.Text = dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch (Exception)
            {
            }
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
            regeXp(@"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", textEmail, boxValidateMail);
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

        private void iconButtonNew_MouseHover(object sender, EventArgs e)
        {
            iconButtonUpdate.IconColor = Color.White;
            iconButtonUpdate.ForeColor = Color.White;
        }

        private void iconButtonNew_MouseLeave(object sender, EventArgs e)
        {
            iconButtonUpdate.IconColor = ColorTranslator.FromHtml("#001578");
            iconButtonUpdate.ForeColor = Color.Black;
        }

        private void iconButtonUpdate_MouseHover(object sender, EventArgs e)
        {
            iconButtonUpdate.IconColor = Color.White;
            iconButtonUpdate.ForeColor = Color.White;
        }

        private void iconButtonUpdate_MouseLeave(object sender, EventArgs e)
        {
            iconButtonUpdate.IconColor = ColorTranslator.FromHtml("#001578");
            iconButtonUpdate.ForeColor = Color.Black;
        }

        private void iconButtonSave_MouseHover(object sender, EventArgs e)
        {
            iconButtonUpdate.IconColor = Color.White;
            iconButtonUpdate.ForeColor = Color.White;
        }

        private void iconButtonSave_MouseLeave(object sender, EventArgs e)
        {
            iconButtonUpdate.IconColor = ColorTranslator.FromHtml("#001578");
            iconButtonUpdate.ForeColor = Color.Black;
        }

        private void iconButtonList_MouseHover(object sender, EventArgs e)
        {
            iconButtonUpdate.IconColor = Color.White;
            iconButtonUpdate.ForeColor = Color.White;
        }

        private void iconButtonList_MouseLeave(object sender, EventArgs e)
        {
            iconButtonUpdate.IconColor = ColorTranslator.FromHtml("#001578");
            iconButtonUpdate.ForeColor = Color.Black;
        }

        private void Assistant_Resize(object sender, EventArgs e)
        {
            listAsistants();
        }

        private void textCui_KeyPress(object sender, KeyPressEventArgs e)
        {
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
