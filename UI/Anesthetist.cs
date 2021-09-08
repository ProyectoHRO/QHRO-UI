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
    public partial class Anesthetist : Form
    {
        private ClassAnesthetist anes;
        public Anesthetist()
        {
            InitializeComponent();
            anes = new ClassAnesthetist();
        }

        void list()
        {
            dataGridView1.DataSource = anes.listAnesthetist();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Refresh();
        }

        void clearText()
        {
            groupBoxanesthetistData.Enabled = true;
            textBoxDPI.Text = "";
            textBoxfirstName.Text = "";
            textBoxsecondName.Text = "";
            textBoxthirdName.Text = "";
            textBoxfirstSurname.Text = "";
            textBoxsecondSurname.Text = "";
            textBoxphoneNumber.Text = "";
            textBoxEmail.Text = "";
            comboBoxStatus.Text = "";
        }

        private void Anesthetist_Load(object sender, EventArgs e)
        {
            groupBoxanesthetistData.Enabled = false;
            iconButtonUpdate.Enabled = false;
            iconButtonSave.Enabled = false;
            labelStatus.Visible = false;
            comboBoxStatus.Visible = false;
        }

        private void iconButtonNew_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void iconButtonList_Click(object sender, EventArgs e)
        {
           
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
            if (label1.Text == "v" || textBoxEmail.Text == "")
            {
                state = 1;
            }
            if (state == 1)
            {
                string resp;
                resp = anes.newAnesthetist(textBoxDPI.Text, textBoxfirstName.Text, textBoxsecondName.Text, textBoxthirdName.Text,
                    textBoxfirstSurname.Text, textBoxsecondSurname.Text, textBoxphoneNumber.Text, textBoxEmail.Text);
                if (resp.ToUpper().Contains("ERROR"))
                {
                    MessageBox.Show(resp, "Error al grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show(resp, "Nuevo anestesista añadido ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    state = 0;
                }

                iconButtonNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("Datos incompletos o erroneos. Por Favor revisar la informacion");
            }
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                labelStatus.Visible = true;
                comboBoxStatus.Visible = true;
                groupBoxanesthetistData.Enabled = true;
                iconButtonUpdate.Enabled = true;
                iconButtonSave.Enabled = false;
                ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxDPI.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxfirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxsecondName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxthirdName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxfirstSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxsecondSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBoxphoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
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
            int state = 0;
            if (label1.Text == "v" || textBoxEmail.Text == "")
            {
                state = 1;
            }
            if (state == 1)
            {
                int id = Convert.ToInt32(ID.Text);
                bool status = false;
                if (comboBoxStatus.SelectedIndex == 0)
                    status = true;
                else if (comboBoxStatus.SelectedIndex == 1)
                {
                    status = false;
                }
                string resp = anes.editAnesthetist(textBoxDPI.Text, textBoxfirstName.Text, textBoxsecondName.Text, textBoxthirdName.Text,
                    textBoxfirstSurname.Text, textBoxsecondSurname.Text, textBoxphoneNumber.Text, textBoxEmail.Text, status, id);
                if (resp.ToUpper().Contains("ERROR"))
                {
                    MessageBox.Show(resp, "Error al actualizar datos del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show(resp, "Datos del anestesista actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    state = 0;
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos o erroneos. Por Favor revisar la informacion");
            }
        }

        private void iconButtonList_Click_1(object sender, EventArgs e)
        {
            list();
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = false;
            groupBoxanesthetistData.Enabled = false;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconButtonNew_MouseHover(object sender, EventArgs e)
        {
            iconButtonNew.IconColor = Color.White;
            iconButtonNew.ForeColor = Color.White;
        }

        private void iconButtonNew_MouseLeave(object sender, EventArgs e)
        {
            iconButtonNew.IconColor = ColorTranslator.FromHtml("#001578");
            iconButtonNew.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            iconButtonSave.IconColor = Color.White;
            iconButtonSave.ForeColor = Color.White;
        }

        private void iconButtonSave_MouseLeave_1(object sender, EventArgs e)
        {
            iconButtonSave.IconColor = ColorTranslator.FromHtml("#001578");
            iconButtonSave.ForeColor = Color.Black;
        }

        private void iconButtonList_MouseHover_2(object sender, EventArgs e)
        {
            iconButtonList.IconColor = Color.White;
            iconButtonList.ForeColor = Color.White;
        }

        private void iconButtonList_MouseLeave_1(object sender, EventArgs e)
        {
            iconButtonList.IconColor = ColorTranslator.FromHtml("#001578");
            iconButtonList.ForeColor = Color.Black;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            regeXp(@"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", textBoxEmail, boxValidateMail);
        }

        private void textBoxphoneNumber_KeyPress(object sender,
          KeyPressEventArgs e)
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
