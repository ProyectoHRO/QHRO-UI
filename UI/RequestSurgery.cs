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
        void listPatients(string param)
        {
            DataTable getPatient = patients.getPatientsByHistoryNumber(param);
            if (getPatient.Rows.Count==1)
            {
                groupBoxpatientData.Enabled = false;
                iconButtonRequest.Visible = true;
                foreach (DataRow item in getPatient.Rows)
                {
                    labelID.Text = item.Field<int>(0).ToString();
                    textBoxhistoryNumber.Text = item.Field<string>(1);
                    textBoxfirstName.Text = item.Field<string>(2);
                    textBoxsecondName.Text = item.Field<string>(3);
                    textBoxthirdName.Text = item.Field<string>(4);
                    textBoxfirstSurname.Text = item.Field<string>(5);
                    textBoxsecondSurname.Text = item.Field<string>(6);
                    textBoxAge.Text = item.Field<short>(7).ToString();
                    comboBoxGender.Text = item.Field<string>(8);
                }
               
            }
            else
            {
                if (textBoxSearch.Text != "Buscar paciente por No. Historia")
                {
                    if (MessageBox.Show("No existe ningun paciente con ese numero de historia, desea crearlo?", "No se encuentra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ClearTexts();
                        textBoxhistoryNumber.Text = textBoxSearch.Text;

                        groupBoxpatientData.Enabled = true;
                        iconButtonCreateAndRequest.Visible = true;
                    }
                }
              
            }
        }

        void ClearTexts()
        {
            textBoxhistoryNumber.Text = "";
            textBoxfirstName.Text = "";
            textBoxsecondName.Text = "";
            textBoxthirdName.Text = "";
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
                string response = requestSurgery.makeSurgeryRequest(userId,textBoxDiagnosis.Text, Convert.ToInt32(labelID.Text), serviceId);
                MessageBox.Show(response);
                iconButtonRequest.Enabled = false;
                iconButtonRequest.Visible = false;
                ClearTexts();
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
            if (textBoxhistoryNumber.Text != "" && textBoxfirstName.Text != "" && textBoxfirstSurname.Text != "" && textBoxDiagnosis.Text != "")
            {
                string response = requestSurgery.makeSurgeryRequestAndPatient(userId,textBoxDiagnosis.Text,3,textBoxhistoryNumber.Text,textBoxfirstName.Text,textBoxsecondName.Text,textBoxthirdName.Text,
                    textBoxfirstSurname.Text, textBoxsecondSurname.Text,Convert.ToInt16(textBoxAge.Text), comboBoxGender.Text);
                MessageBox.Show(response);
                iconButtonRequest.Enabled = false;
                iconButtonRequest.Visible = false;
                ClearTexts();
            }
            else
                MessageBox.Show("Porfavor llene los campos requeridos");
        }
    }
}
