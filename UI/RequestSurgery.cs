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
    public partial class RequestSurgery : Form
    {
        private ClassPatient patients=new ClassPatient();
        private ClassPHro patientsHro = new ClassPHro();
        private ClassRequestSurgery requestSurgery = new ClassRequestSurgery();
        int serviceId;
        int userId;
        public RequestSurgery(int idService, int idUser)
        {
            InitializeComponent();
            userId = idUser;
            if (idService > 0)
                serviceId = idService;
            else
                serviceId = 22;    
        }
        int band =0;
        void listPatients(string param)
        {
            DataTable infoPatientsHro = patientsHro.getPatientsByHistoryNumber(param);
            string historyNumber = "";
            if (infoPatientsHro.Rows.Count < 1)
            {
                if (MessageBox.Show("No se encuentra el numero de historia, ¿Desea crearlo ahora mismo?", "Alerta",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textBoxhistoryNumber.Enabled = false;
                    groupBoxpatientData.Enabled = true;
                    iconButtonCreateAndRequest.Visible = true;
                    iconButtonRequest.Visible = false;

                }
            }
            else
            {
                foreach (DataRow item in infoPatientsHro.Rows)
                {
                    historyNumber = item.Field<string>(0);
                    textBoxhistoryNumber.Text = item.Field<string>(0);
                    textBoxfirstName.Text = item.Field<string>(1);
                    textBoxsecondName.Text = item.Field<string>(2);
                    textBoxfirstSurname.Text = item.Field<string>(3);
                    textBoxsecondSurname.Text = item.Field<string>(4);
                    string sex = item.Field<string>(5);
                    if (sex == "0")
                    {
                        comboBoxGender.Text = "Masculino";
                    }
                    else if (sex == "1")
                    {
                        comboBoxGender.Text = "Femenino";
                    }
                    textBoxAge.Text = item.Field<int>(6).ToString();
                }
                DataTable getPatient = patients.getPatientsByHistoryNumber(historyNumber);
                if (getPatient.Rows.Count < 1)
                {
                    band = 1;
                }
                else
                {
                    band = 2;
                    foreach (DataRow item in getPatient.Rows)
                    {
                        labelID.Text = item.Field<int>(0).ToString();

                    }
                }
                iconButtonRequest.Visible = true;
            }
        }

        void ClearTexts()
        {
            textBoxhistoryNumber.Text = "";
            textBoxfirstName.Text = "";
            textBoxsecondName.Text = "";
            //textBoxthirdName.Text = "";
            textBoxfirstSurname.Text = "";
            textBoxsecondSurname.Text = "";
            textBoxAge.Text = "";
            textBoxDiagnosis.Text = "";
            comboBoxGender.Text = "";
            textBoxDiagnosis.Text = "";
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Buscar paciente por No. Historia")
                textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                textBoxSearch.Text = "Buscar paciente por No. Historia";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            listPatients(textBoxSearch.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
       
        private void iconButtonRequest_Click(object sender, EventArgs e)
        {
            if (textBoxDiagnosis.Text!="")
            {
                if (band==1)
                {
                    string response = requestSurgery.makeSurgeryRequestAndPatient(userId, textBoxDiagnosis.Text, serviceId, textBoxhistoryNumber.Text,textBoxfirstName.Text, textBoxsecondName.Text,
                    textBoxfirstSurname.Text, textBoxsecondSurname.Text, Convert.ToInt16(textBoxAge.Text), comboBoxGender.Text);
                    MessageBox.Show(response);
                }
                else if (band == 2)
                {
                    string response = requestSurgery.makeSurgeryRequest(
                        userId, 
                        textBoxDiagnosis.Text,
                        textBoxfirstName.Text, 
                        textBoxsecondName.Text,
                    textBoxfirstSurname.Text,
                    textBoxsecondSurname.Text,
                    Convert.ToInt16(textBoxAge.Text),
                    comboBoxGender.Text,
                       Convert.ToInt32(labelID.Text), 
                       serviceId);
                    MessageBox.Show(response);
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Porfavor llene el cambio de diagnostico");
            }
        }

        private void textBoxDiagnosis_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDiagnosis.Text != "")
                iconButtonRequest.Enabled = true;
        }

        private void iconButtonCreateAndRequest_Click(object sender, EventArgs e)
        {
            if (textBoxDiagnosis.Text != "")
            {
                string response = requestSurgery.makeSurgeryRequestAndPatient(userId, textBoxDiagnosis.Text, serviceId,"NULL", textBoxfirstName.Text, textBoxsecondName.Text,
                textBoxfirstSurname.Text, textBoxsecondSurname.Text, Convert.ToInt16(textBoxAge.Text), comboBoxGender.Text);
                MessageBox.Show(response);
                this.Close();
            }
            else
            {
                MessageBox.Show("Porfavor llene el cambio de diagnostico");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
