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
    public partial class Services : Form
    {
        private ClassServices services = new ClassServices();
        public Services()
        {
            InitializeComponent();
        }
        void ListServices()
        {
            DataTable servicesList = services.getServices();
            dataGridViewOperatingRooms.DataSource = servicesList;
            dataGridViewOperatingRooms.Columns[0].Visible = false;
            dataGridViewOperatingRooms.Columns[1].HeaderText = "Servicio";
            dataGridViewOperatingRooms.AutoResizeColumns();
            dataGridViewOperatingRooms.Refresh();
        }
        private void iconButtonList_Click(object sender, EventArgs e)
        {
            ListServices();
            ListServices();
        }

        private void Services_Resize(object sender, EventArgs e)
        {
            ListServices();
        } //added

        private void iconButtonNew_Click(object sender, EventArgs e)
        {
            groupBoxServices.Enabled = true;
            textBoxNameService.Clear();
            iconButtonSave.Enabled = true;
            iconButtonNew.Enabled = false;
            iconButtonUpdate.Enabled = false;
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            //int state = 0;
            //if (label1.Text == "v" || textBoxNameService.Text == "")
            //{
            //    state = 1;
            //}
            //if (state == 1)
            //{
                if (textBoxNameService.Text != null )
                {
                    string resp;
                    resp = services.newService(textBoxNameService.Text);
                    if (resp.ToUpper().Contains("ERROR"))
                        MessageBox.Show(resp, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show(resp, "Registro Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBoxServices.Enabled = false;
                        textBoxNameService.Clear();
                        iconButtonSave.Enabled = true;
                        iconButtonNew.Enabled = false;
                        ListServices();
                    }
                       
                }
                else
                    MessageBox.Show("Porfavor llena los campos");
             
            //state = 0;

            //}
            //else
            //{
            //    MessageBox.Show("Datos incompletos o erroneos. Por Favor revisar la informacion");
            //}
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {

            //int state = 0;
            //if (label1.Text == "v" || textBoxNameService.Text == "")
            //    state = 1;
            //if (state == 1)
            //{
                string resp = services.updateAssistant(textBoxNameService.Text,Convert.ToInt16(labelID.Text));
                if (resp.ToUpper().Contains("ERROR"))
                    MessageBox.Show(resp, "Error al Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                MessageBox.Show(resp, "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBoxServices.Enabled = false;
                textBoxNameService.Clear();
                ListServices();
                iconButtonUpdate.Enabled = false;
                iconButtonSave.Enabled = false;
                iconButtonNew.Enabled = true;
                //state = 0;
            //}
            //else
            //    MessageBox.Show("Datos incompletos o erroneos. Por Favor revisar la informacion");
        }

        private void dataGridViewOperatingRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBoxServices.Enabled = true;
            iconButtonNew.Enabled = true;
            iconButtonSave.Enabled = false;
            iconButtonUpdate.Enabled = true;
            bool status;
            try
            {
                labelID.Text = dataGridViewOperatingRooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNameService.Text= dataGridViewOperatingRooms.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void Services_Load(object sender, EventArgs e)
        {
            ListServices();
            ListServices();
        }
    }
}
