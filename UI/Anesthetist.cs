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
            groupBox1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.Text = "";
        }

        private void Anesthetist_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            iconButtonUpdate.Enabled = false;
            iconButtonSave.Enabled = false;
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
        }

        private void iconButtonSave_Click_1(object sender, EventArgs e)
        {
            string resp;
            resp = anes.newAnesthetist(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
            textBox6.Text, textBox7.Text, textBox8.Text, Convert.ToBoolean(comboBox1.SelectedItem));
            if (resp.ToUpper().Contains("ERROR"))
            {
                MessageBox.Show(resp, "Error al grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show(resp, "Nuevo anestesista añadido ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void iconButtonUpdate_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID.Text);
            string resp = anes.editAnesthetist(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
            textBox6.Text, textBox7.Text, textBox8.Text, Convert.ToBoolean(comboBox1.SelectedItem), id);
            if (resp.ToUpper().Contains("ERROR"))
            {
                MessageBox.Show(resp, "Error al actualizar datos del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show(resp, "Datos del anestesista actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
            }
        }

        private void iconButtonList_Click_1(object sender, EventArgs e)
        {
            list();
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = false;
            groupBox1.Enabled = false;
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
    }
}
