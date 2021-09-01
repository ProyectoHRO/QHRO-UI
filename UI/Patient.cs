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
        private ClassPatient pat;
        public Patient()
        {
            InitializeComponent();
            pat = new ClassPatient();
        }

        void list()
        {
            dataGridView1.DataSource = pat.listPatients();
            dataGridView1.Refresh();
        }

        void clearText()
        {
            groupBox1.Enabled = true;
            textBox1.Text = "";
            textBoxFirstName.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            iconButtonUpdate.Enabled = false;
            iconButtonSave.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonList_Click(object sender, EventArgs e)
        {
           
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

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButtonList_Click_1(object sender, EventArgs e)
        {
            list();
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void iconButtonNew_Click_1(object sender, EventArgs e)
        {
            iconButtonSave.Enabled = true;
            iconButtonUpdate.Enabled = false;
            clearText();
            iconButtonNew.Enabled = false;
        }

        private void iconButtonSave_Click_1(object sender, EventArgs e)
        {
            string resp;
            resp = pat.newPatient(textBox1.Text, textBoxFirstName.Text, textBox3.Text, textBox4.Text, textBox5.Text,
            textBox6.Text, Convert.ToInt16(textBox7.Text), textBox8.Text, comboBox1.SelectedItem.ToString(),
            Convert.ToBoolean(comboBox2.SelectedItem));
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
            groupBox1.Enabled = true;
            iconButtonUpdate.Enabled = true;
            iconButtonSave.Enabled = false;
            ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void iconButtonUpdate_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID.Text);
            string resp = pat.editPatient(textBox1.Text, textBoxFirstName.Text, textBox3.Text, textBox4.Text, textBox5.Text,
            textBox6.Text, Convert.ToInt16(textBox7.Text), textBox8.Text, comboBox1.SelectedItem.ToString(),
            Convert.ToBoolean(comboBox2.SelectedItem), id);
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
    }
}
