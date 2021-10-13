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
    public partial class OperatingRooms : Form
    {
        private ClassOperatingRoom operatingroom = new ClassOperatingRoom();
        public OperatingRooms()
        {
            InitializeComponent();
        }

        void listoperatingRooms()
        {
            dataGridViewOperatingRooms.DataSource = operatingroom.listoperatingRooms();
            dataGridViewOperatingRooms.Columns[1].HeaderText = "Numero de quirofano";
            dataGridViewOperatingRooms.Columns[2].HeaderText = "Estado Actual";
            dataGridViewOperatingRooms.Columns[0].Visible = false;
            dataGridViewOperatingRooms.Columns[3].Visible = false;
            dataGridViewOperatingRooms.RowHeadersWidth = 50;
            //dataGridViewOperatingRooms.AutoResizeColumns();
            //dataGridViewOperatingRooms.AutoResizeColumnHeadersHeight();
            //dataGridViewOperatingRooms.AutoResizeRows();
            dataGridViewOperatingRooms.Refresh();
        }

        void clearText()
        {
            groupBoxoperatingroomData.Enabled = true;
            textBoxNumber.Text = "";
            textBoxCurrentState.Text = "";
            comboStatus.Text = "";
        }

        private void OperatingRooms_Load(object sender, EventArgs e)
        {
            groupBoxoperatingroomData.Enabled = false;
            iconButtonUpdate.Enabled = false;
            iconButtonSave.Enabled = false;
            labelStatus.Visible = false;
            comboStatus.Visible = false;

            listoperatingRooms();
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = false;
            groupBoxoperatingroomData.Enabled = false;
            dataGridViewOperatingRooms.EnableHeadersVisualStyles = false;
        }

        private void iconButtonNew_Click(object sender, EventArgs e)
        {
            clearText();
            iconButtonSave.Enabled = true;
            iconButtonUpdate.Enabled = false;
            iconButtonNew.Enabled = false;
            labelStatus.Visible = false;
            comboStatus.Visible = false;
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            string resp;
            resp = operatingroom.newoperatingRoom(textBoxNumber.Text, textBoxCurrentState.Text);
            if (resp.ToUpper().Contains("ERROR"))
            {
                MessageBox.Show(resp, "Error al grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show(resp, "Nuevo quirofano añadido ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listoperatingRooms();
            }

            iconButtonNew.Enabled = true;
        }

        private void dataGridViewOperatingRooms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                labelStatus.Visible = true;
                comboStatus.Visible = true;
                groupBoxoperatingroomData.Enabled = true;
                iconButtonUpdate.Enabled = true;
                iconButtonSave.Enabled = false;
                labelID.Text = dataGridViewOperatingRooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNumber.Text = dataGridViewOperatingRooms.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxCurrentState.Text = dataGridViewOperatingRooms.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (dataGridViewOperatingRooms.Rows[e.RowIndex].Cells[3].Value.ToString() == "True")
                    comboStatus.Text = "Activo";
                else if (dataGridViewOperatingRooms.Rows[e.RowIndex].Cells[3].Value.ToString() == "False")
                    comboStatus.Text = "Inactivo";
            }

            catch (Exception)
            {
            }
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(labelID.Text);
            bool status = false;

            if (comboStatus.SelectedIndex == 0)
                status = true;
            else if (comboStatus.SelectedIndex == 1)
                status = false;

            string resp = operatingroom.editoperatingRoom(textBoxNumber.Text, textBoxCurrentState.Text, status, id);
            if (resp.ToUpper().Contains("ERROR"))
            {
                MessageBox.Show(resp, "Error al actualizar datos del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show(resp, "Datos del paciente actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listoperatingRooms();
            }
        }

        private void iconButtonList_Click(object sender, EventArgs e)
        {
           
            listoperatingRooms();
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = false;
            groupBoxoperatingroomData.Enabled = false;
            dataGridViewOperatingRooms.EnableHeadersVisualStyles = false;
        }

        private void OperatingRooms_Resize(object sender, EventArgs e)
        {
            listoperatingRooms();
        }
    }
}
