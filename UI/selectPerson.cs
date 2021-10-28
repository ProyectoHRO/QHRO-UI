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
    public partial class selectPerson : Form
    {
        private ClassAnesthetist anesthetist = new ClassAnesthetist();
        private ClassDoctor doctor = new ClassDoctor();
        private ClassAssistants assistant = new ClassAssistants();

        public string name { get; set; }
        public int id { get; set; }

        public string assistantType { get; set; }

        int typePerson;

        void confirmPerson()
        {
            if (dataGridViewSearchPerson.Rows.Count < 2)
            {
                id = Convert.ToInt32(dataGridViewSearchPerson.Rows[0].Cells[0].Value);
              
                    name = dataGridViewSearchPerson.Rows[0].Cells[2].Value.ToString() + ' ' + dataGridViewSearchPerson.Rows[0].Cells[3].Value.ToString() + ' ' +
                  dataGridViewSearchPerson.Rows[0].Cells[4].Value.ToString() + ' ' + dataGridViewSearchPerson.Rows[0].Cells[5].Value.ToString() + ' ' +
                      dataGridViewSearchPerson.Rows[0].Cells[6].Value.ToString();
              
                if (typePerson != 1 && typePerson != 2)
                {
                    int type = Convert.ToInt32(dataGridViewSearchPerson.Rows[0].Cells[9].Value);
                    if (type == 1)
                        assistantType = "Instrumentista";
                    else
                        assistantType = "Circulante";
                }
               
            }
            else
                this.Close();
        }
        void listAnesthetist(DataTable anesthetist)
        {
            dataGridViewSearchPerson.DataSource = anesthetist;
            dataGridViewSearchPerson.Columns[0].Visible = false;
            dataGridViewSearchPerson.Columns[1].HeaderText = "CUI";
            dataGridViewSearchPerson.Columns[2].HeaderText = "Primer nombre";
            dataGridViewSearchPerson.Columns[3].HeaderText = "Segundo nombre";
            dataGridViewSearchPerson.Columns[4].HeaderText = "Tercer nombre";
            dataGridViewSearchPerson.Columns[5].HeaderText = "Primer apellido";
            dataGridViewSearchPerson.Columns[6].HeaderText = "Segundo apellido";
            dataGridViewSearchPerson.Columns[7].HeaderText = "Telefono";
            dataGridViewSearchPerson.Columns[8].HeaderText = "Correo";
            dataGridViewSearchPerson.Columns[0].Visible = false;
            dataGridViewSearchPerson.Columns[9].Visible = false;
            dataGridViewSearchPerson.AutoResizeColumns();
            dataGridViewSearchPerson.AutoResizeRows();
            dataGridViewSearchPerson.Refresh();

        }
        void listDoctors(DataTable doctor)
        {
            dataGridViewSearchPerson.DataSource = doctor;
            dataGridViewSearchPerson.Columns[1].HeaderText = "CUI";
            dataGridViewSearchPerson.Columns[2].HeaderText = "Primer nombre";
            dataGridViewSearchPerson.Columns[3].HeaderText = "Segundo nombre";
            dataGridViewSearchPerson.Columns[4].HeaderText = "Tercer nombre";
            dataGridViewSearchPerson.Columns[5].HeaderText = "Primer apellido";
            dataGridViewSearchPerson.Columns[6].HeaderText = "Segundo apellido";
            dataGridViewSearchPerson.Columns[7].HeaderText = "Telefono";
            dataGridViewSearchPerson.Columns[10].HeaderText = "Especialidad";
            dataGridViewSearchPerson.Columns[0].Visible = false;
            dataGridViewSearchPerson.Columns[9].Visible = false;
            dataGridViewSearchPerson.Refresh();
            dataGridViewSearchPerson.AutoResizeColumns();
            dataGridViewSearchPerson.AutoResizeRows();
        }
        void listAssistants(DataTable assistant)
        {
            dataGridViewSearchPerson.DataSource = assistant;
            dataGridViewSearchPerson.Columns[1].HeaderText = "CUI";
            dataGridViewSearchPerson.Columns[2].HeaderText = "Primer nombre";
            dataGridViewSearchPerson.Columns[3].HeaderText = "Segundo nombre";
            dataGridViewSearchPerson.Columns[4].HeaderText = "Tercer nombre";
            dataGridViewSearchPerson.Columns[5].HeaderText = "Primer apellido";
            dataGridViewSearchPerson.Columns[6].HeaderText = "Segundo apellido";
            dataGridViewSearchPerson.Columns[7].HeaderText = "Correo";
            dataGridViewSearchPerson.Columns[8].HeaderText = "Telefono";
            dataGridViewSearchPerson.Columns[0].Visible = false;
            dataGridViewSearchPerson.Columns[9].Visible = false;
            dataGridViewSearchPerson.Columns[10].Visible = false;
            dataGridViewSearchPerson.AutoResizeColumns();
            dataGridViewSearchPerson.AutoResizeRows();
            dataGridViewSearchPerson.Refresh();
        }
        public selectPerson(int type)
        {
            InitializeComponent();
            typePerson = type;
            comboBoxFilter.Items.Add("DPI");
            comboBoxFilter.Items.Add("Nombre");
            if (typePerson==1)
            {
                label1.Text = "Anestesista";
                listAnesthetist(anesthetist.listAnesthetist());
            }
            else if (typePerson == 2)
            {
                label1.Text = "Doctor";
                listDoctors(doctor.getDoctors());
            }
            else
            {
                label1.Text = "Ayudante";
                listAssistants(assistant.getAssistants());
            }
            dataGridViewSearchPerson.AutoResizeColumns();
            dataGridViewSearchPerson.AutoResizeRows();
            dataGridViewSearchPerson.Refresh();
            comboBoxFilter.SelectedIndex = 0;

        }

        private void selectPerson_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            if (comboBoxFilter.Text=="Nombre")
            {
                textBoxSearch.Enabled = true;
            }
            else
            {
                textBoxSearch.Enabled = true;
            }
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text== "BUSCAR")
            {
                if (typePerson == 1)
                {
                    label1.Text = "Anestesista";
                    listAnesthetist(anesthetist.listAnesthetist());
                }
                else if (typePerson == 2)
                {
                    label1.Text = "Doctor";
                    listDoctors(doctor.getDoctors());
                }
                else
                {
                    label1.Text = "Ayudante";
                    listAssistants(assistant.getAssistants());
                }
                dataGridViewSearchPerson.AutoResizeColumns();
                dataGridViewSearchPerson.AutoResizeRows();
                dataGridViewSearchPerson.Refresh();
                comboBoxFilter.SelectedIndex = 0;

            }
            else
            {
                if (comboBoxFilter.Text == "Nombre")
                {
                    if (typePerson == 1)
                        listAnesthetist(anesthetist.getAnesthetistByname(textBoxSearch.Text));
                    else if (typePerson == 2)
                        listDoctors(doctor.getDoctorByName(textBoxSearch.Text));
                    else
                        listAssistants(assistant.getAssistantByName(textBoxSearch.Text));

                    if (dataGridViewSearchPerson.Rows.Count < 2)
                    {
                        iconButtonContinue.Enabled = true;
                    }
                }
                else
                {
                    if (typePerson == 1)
                        listAnesthetist(anesthetist.getAnesthetistByDpi(textBoxSearch.Text));
                    else if (typePerson == 2)
                        listDoctors(doctor.getDoctorByDpi(textBoxSearch.Text));
                    else
                        listAssistants(assistant.getAssistantByDpi(textBoxSearch.Text));
                    if (dataGridViewSearchPerson.Rows.Count < 2)
                    {
                        iconButtonContinue.Enabled = true;
                    }
                }
            }
            
        }

        private void dataGridViewSearchPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iconButtonContinue.Enabled = true;
            try
            {
                id = Convert.ToInt32(dataGridViewSearchPerson.Rows[e.RowIndex].Cells[0].Value);
              
                    name = dataGridViewSearchPerson.Rows[e.RowIndex].Cells[2].Value.ToString() + ' ' + dataGridViewSearchPerson.Rows[e.RowIndex].Cells[3].Value.ToString() + ' ' +
                  dataGridViewSearchPerson.Rows[e.RowIndex].Cells[4].Value.ToString() + ' ' + dataGridViewSearchPerson.Rows[e.RowIndex].Cells[5].Value.ToString() + ' ' +
                      dataGridViewSearchPerson.Rows[e.RowIndex].Cells[6].Value.ToString();
             
                if(typePerson!=1 && typePerson!=2)
                {
                    int type = Convert.ToInt32(dataGridViewSearchPerson.Rows[e.RowIndex].Cells[9].Value);
                    if (type == 1)
                        assistantType = "Instrumentista";
                    else
                        assistantType = "Circulante";
                }
              
            }
            catch (Exception)
            {

            }
        }

        private void iconButtonContinue_Click(object sender, EventArgs e)
        {
                confirmPerson();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "BUSCAR")
                textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                textBoxSearch.Text = "BUSCAR";
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            id = 0;
              this.Close();
        }

        private void dataGridViewSearchPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSearchPerson_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            confirmPerson();
        }
    }
}
