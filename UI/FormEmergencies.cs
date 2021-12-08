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
    public partial class FormEmergencies : Form
    {
        int Qx;
        private Surgeries surgeries = new Surgeries();
        private ClassGetStrings strings = new ClassGetStrings();
        private ClassOperatingRoom operatingRooms = new ClassOperatingRoom();
        private Surgeries surgeriesLogic = new Surgeries();
        private ClassMail mail = new ClassMail();
        private ClassAnesthesia anesthesia = new ClassAnesthesia();
        private ClassDoctor doctorss = new ClassDoctor();
        private ClassPatient patients = new ClassPatient();
        private ClassPHro patientsHro = new ClassPHro();
        private ClassRequestSurgery requestSurgery = new ClassRequestSurgery();
        int userId;
        int serviceId;
        public FormEmergencies(int IdUser, int idService)
        {
            InitializeComponent();
            userId = IdUser;
            serviceId = idService;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormEmergencies_Load(object sender, EventArgs e)
        {

            DataTable surgeriesInfo = surgeries.GetEmergencySurgeries();

            if (surgeriesInfo.Rows.Count < 1)
            {

            }
            else
            {
                comboBoxSurgeryType.SelectedIndex = 1;
                dataGridView1.DataSource = surgeries.GetEmergencySurgeries();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                dataGridView1.Refresh();
            }
            DataTable anesthesiaList = anesthesia.getAnesthesia();
            foreach (DataRow item in anesthesiaList.Rows)
            {
                listBoxAnesthesiaId.Items.Add(Convert.ToInt32(item.Field<int>(0)));
                checkedListBoxAnesthesiaTypes.Items.Add(item.Field<string>(1).ToString());
            }
            DataTable infoOperatingRooms = operatingRooms.listoperatingRooms();
            comboBoxOperatingRooms.ValueMember = "idquirofano";
            comboBoxOperatingRooms.DisplayMember = "no_quirofano";
            comboBoxOperatingRooms.DataSource = infoOperatingRooms;

            textBoxSearch.Enabled = false;
            iconButtonSearchNames.Enabled = false;
            tableLayoutPanel17.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                labelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dateTimeSurgeryDate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                string hora = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string[] response = strings.getStrings(hora, new char[] { ':', ' ' });
                if (response[0].StartsWith("0"))
                {
                    string[] response1 = strings.getStrings(response[0], new char[] { '0' });
                    comboBoxHour.Text = response1[0];
                }
                else
                {
                    comboBoxHour.Text = response[0];
                }

                comboBoxMin.Text = response[1];
                if (response[2].Contains("A"))
                {
                    comboBoxTime.SelectedIndex = 0;
                }
                else
                {
                    comboBoxTime.SelectedIndex = 1;
                }

                Qx = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                comboBoxOperatingRooms.SelectedValue = Qx;
                textBoxSearch.Enabled = true;
                iconButtonSearchNames.Enabled = true;
                tableLayoutPanel17.Enabled = false;

            }
            catch (Exception)
            {
            }
        }

        int band = 0;
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
                    tableLayoutPanel17.Enabled = true;
                    band = 3;
                    groupBoxpatientData.Enabled = true;
                    groupBoxDocsData.Enabled = true;
                    groupBoxAssistantsData.Enabled = true;
                    groupBoxAnesthetistData.Enabled = true;
                    iconButtonConfirm.Enabled = true;
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
                    groupBoxpatientData.Enabled = true;
                    groupBoxDocsData.Enabled = true;
                    groupBoxAssistantsData.Enabled = true;
                    groupBoxAnesthetistData.Enabled = true;
                    iconButtonConfirm.Enabled = true;
                }
                else
                {
                    band = 2;
                    groupBoxpatientData.Enabled = true;
                    groupBoxDocsData.Enabled = true;
                    groupBoxAssistantsData.Enabled = true;
                    groupBoxAnesthetistData.Enabled = true;
                    iconButtonConfirm.Enabled = true;
                    foreach (DataRow item in getPatient.Rows)
                    {
                        labelDpacient.Text = item.Field<int>(0).ToString();
                    }
                }
            }
        }
        private void iconButtonSearchNames_Click(object sender, EventArgs e)
        {
            listPatients(textBoxSearch.Text);
            
        }

        private void iconButtonAddDoctor_Click(object sender, EventArgs e)
        {

            selectPerson selectP = new selectPerson(2);
            selectP.ShowDialog();
            if (selectP.id != 0)
            {
                listBoxDocId.Items.Add(selectP.id);
                ListViewItem item = new ListViewItem(selectP.name.ToString());
                listViewDoctors.Items.Add(item);
            }
            else
            {

            }
        }

        private void iconButtonDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar al doctor?", "Confirmar",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Doctor eliminado");
                if (listViewDoctors.Items.Count > 0)
                {
                    listBoxDocId.Items.RemoveAt(listViewDoctors.SelectedIndices[0]);
                    listViewDoctors.Items.Remove(listViewDoctors.SelectedItems[0]);

                }

            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void iconButtonAddAssistant_Click(object sender, EventArgs e)
        {

            selectPerson selectP = new selectPerson(3);
            selectP.ShowDialog();
            if (selectP.id != 0)
            {
                listBoxIds.Items.Add(selectP.id);
                ListViewItem item = new ListViewItem(selectP.assistantType.ToString());
                item.SubItems.Add(selectP.name.ToString());
                listViewAssistants.Items.Add(item);
            }
            else
            {

            }
        }

        private void iconButtonDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar al asistente?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Asistente eliminado");
                if (listViewAssistants.Items.Count > 0)
                {
                    listBoxIds.Items.RemoveAt(listViewAssistants.SelectedIndices[0]);
                    listViewAssistants.Items.Remove(listViewAssistants.SelectedItems[0]);

                }

            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void iconButtonAddAnesthetist_Click(object sender, EventArgs e)
        {

            selectPerson selectP = new selectPerson(1);
            selectP.ShowDialog();
            //textBoxAnestethistName.Text = selectP.name;
            //labelIdAnesthetist.Text = selectP.id.ToString();
        }

        private void iconButtonConfirm_Click(object sender, EventArgs e)
        {
            if (band==3)
            {
                string allTypes = "";
                for (int i = 0; i < checkedListBoxAnesthesiaTypes.CheckedItems.Count; i++)
                {
                    if (i == (checkedListBoxAnesthesiaTypes.CheckedItems.Count - 1))
                    {
                        allTypes = allTypes + checkedListBoxAnesthesiaTypes.CheckedItems[i].ToString();
                    }
                    else
                    {
                        allTypes = allTypes + checkedListBoxAnesthesiaTypes.CheckedItems[i].ToString() + "-";
                    }
                }
                string anesTypes = allTypes;

                string finalHour = "";

                if (comboBoxFinalTime.Text == "A.M")
                {
                    if (comboBoFinalHour.Text == "12")
                    {
                        finalHour = "00";
                    }
                }
                else if (comboBoxFinalTime.Text == "P.M")
                {
                    finalHour = ((Convert.ToInt32(comboBoFinalHour.Text) % 12) + 12).ToString();
                }

                string finalTime = finalHour + ":" + comboBoxFinalMin.Text + ":00";


                List<ClassDtoAssistants> assistantsList = new List<ClassDtoAssistants>();
                ClassDtoAssistants assistant;
                for (int i = 0; i < listBoxIds.Items.Count; i++)
                {
                    listBoxIds.SelectedIndex = i;
                    assistant = new ClassDtoAssistants();
                    assistant.AssistandId = Convert.ToInt32(listBoxIds.SelectedItem);
                    assistantsList.Add(assistant);
                }

                List<ClassDtoDoctors> doctorsList = new List<ClassDtoDoctors>();
                ClassDtoDoctors doctors;
                for (int i = 0; i < listBoxDocId.Items.Count; i++)
                {
                    listBoxDocId.SelectedIndex = i;
                    doctors = new ClassDtoDoctors();
                    doctors.DoctorId = Convert.ToInt32(listBoxDocId.SelectedItem);
                    doctorsList.Add(doctors);
                }


                string response = surgeriesLogic.EmergencyAndPatientNew(
                    textBoxfirstName.Text,
                    textBoxsecondName.Text,
                    textBoxfirstSurname.Text,
                    textBoxsecondSurname.Text,
                    Convert.ToInt16(textBoxAge.Text),
                    comboBoxGender.Text,
                    serviceId,
                    Convert.ToInt32(labelID.Text),
                    userId,
                    finalTime,
                    dateTimePickerFinalDate.Value,
                    anesTypes,
                    comboBoxSurgeryType.Text,
                    dateTimeSurgeryDate.Value.Date,
                    comboBoxHour.Text + ':' + comboBoxMin.Text + ' ' + comboBoxTime.Text,
                    Convert.ToInt32(comboBoxOperatingRooms.SelectedValue),
                    //Convert.ToInt32(labelIdAnesthetist.Text),
                    comboBoxRelevance.Text,
                    textBoxDiagnosis.Text,
                    assistantsList,
                    doctorsList);
                MessageBox.Show(response);

                this.Close();
            }
            if (band==1)
            {
                string allTypes = "";
                for (int i = 0; i < checkedListBoxAnesthesiaTypes.CheckedItems.Count; i++)
                {
                    if (i == (checkedListBoxAnesthesiaTypes.CheckedItems.Count - 1))
                    {
                        allTypes = allTypes + checkedListBoxAnesthesiaTypes.CheckedItems[i].ToString();
                    }
                    else
                    {
                        allTypes = allTypes + checkedListBoxAnesthesiaTypes.CheckedItems[i].ToString() + "-";
                    }
                }
                string anesTypes = allTypes;

                string finalHour = "";

                if (comboBoxFinalTime.Text == "A.M")
                {
                    if (comboBoFinalHour.Text == "12")
                    {
                        finalHour = "00";
                    }
                }
                else if (comboBoxFinalTime.Text == "P.M")
                {
                    finalHour = ((Convert.ToInt32(comboBoFinalHour.Text) % 12) + 12).ToString();
                }

                string finalTime = finalHour + ":" + comboBoxFinalMin.Text + ":00";


                List<ClassDtoAssistants> assistantsList = new List<ClassDtoAssistants>();
                ClassDtoAssistants assistant;
                for (int i = 0; i < listBoxIds.Items.Count; i++)
                {
                    listBoxIds.SelectedIndex = i;
                    assistant = new ClassDtoAssistants();
                    assistant.AssistandId = Convert.ToInt32(listBoxIds.SelectedItem);
                    assistantsList.Add(assistant);
                }

                List<ClassDtoDoctors> doctorsList = new List<ClassDtoDoctors>();
                ClassDtoDoctors doctors;
                for (int i = 0; i < listBoxDocId.Items.Count; i++)
                {
                    listBoxDocId.SelectedIndex = i;
                    doctors = new ClassDtoDoctors();
                    doctors.DoctorId = Convert.ToInt32(listBoxDocId.SelectedItem);
                    doctorsList.Add(doctors);
                }


                string response = surgeriesLogic.EmergencyBasicAndPatient(
                    textBoxhistoryNumber.Text,
                    textBoxfirstName.Text,
                    textBoxsecondName.Text,
                    textBoxfirstSurname.Text,
                    textBoxsecondSurname.Text,
                    Convert.ToInt16(textBoxAge.Text),
                    comboBoxGender.Text,
                    serviceId,
                    Convert.ToInt32(labelID.Text),
                    userId,
                    finalTime,
                    dateTimePickerFinalDate.Value,
                    anesTypes,
                    comboBoxSurgeryType.Text,
                    dateTimeSurgeryDate.Value.Date,
                    comboBoxHour.Text + ':' + comboBoxMin.Text + ' ' + comboBoxTime.Text,
                    Convert.ToInt32(comboBoxOperatingRooms.SelectedValue),
                    //Convert.ToInt32(labelIdAnesthetist.Text),
                    comboBoxRelevance.Text,
                    textBoxDiagnosis.Text,
                    assistantsList,
                    doctorsList);
                MessageBox.Show(response);

                this.Close();
            }
            if (band==2)
            {
                string allTypes = "";
                for (int i = 0; i < checkedListBoxAnesthesiaTypes.CheckedItems.Count; i++)
                {
                    if (i == (checkedListBoxAnesthesiaTypes.CheckedItems.Count - 1))
                    {
                        allTypes = allTypes + checkedListBoxAnesthesiaTypes.CheckedItems[i].ToString();
                    }
                    else
                    {
                        allTypes = allTypes + checkedListBoxAnesthesiaTypes.CheckedItems[i].ToString() + "-";
                    }
                }
                string anesTypes = allTypes;

                string finalHour = "";

                if (comboBoxFinalTime.Text == "A.M")
                {
                    if (comboBoFinalHour.Text == "12")
                    {
                        finalHour = "00";
                    }
                }
                else if (comboBoxFinalTime.Text == "P.M")
                {
                    finalHour = ((Convert.ToInt32(comboBoFinalHour.Text) % 12) + 12).ToString();
                }

                string finalTime = finalHour + ":" + comboBoxFinalMin.Text + ":00";


                List<ClassDtoAssistants> assistantsList = new List<ClassDtoAssistants>();
                ClassDtoAssistants assistant;
                for (int i = 0; i < listBoxIds.Items.Count; i++)
                {
                    listBoxIds.SelectedIndex = i;
                    assistant = new ClassDtoAssistants();
                    assistant.AssistandId = Convert.ToInt32(listBoxIds.SelectedItem);
                    assistantsList.Add(assistant);
                }

                List<ClassDtoDoctors> doctorsList = new List<ClassDtoDoctors>();
                ClassDtoDoctors doctors;
                for (int i = 0; i < listBoxDocId.Items.Count; i++)
                {
                    listBoxDocId.SelectedIndex = i;
                    doctors = new ClassDtoDoctors();
                    doctors.DoctorId = Convert.ToInt32(listBoxDocId.SelectedItem);
                    doctorsList.Add(doctors);
                }


                string response = surgeriesLogic.EmergencyBasic(
                    Convert.ToInt32(labelDpacient.Text),
                    serviceId,
                    Convert.ToInt32(labelID.Text),
                    userId,
                    finalTime,
                    dateTimePickerFinalDate.Value,
                    anesTypes,
                    comboBoxSurgeryType.Text,
                    dateTimeSurgeryDate.Value.Date,
                    comboBoxHour.Text + ':' + comboBoxMin.Text + ' ' + comboBoxTime.Text,
                    Convert.ToInt32(comboBoxOperatingRooms.SelectedValue),
                    //Convert.ToInt32(labelIdAnesthetist.Text),
                    comboBoxRelevance.Text,
                    textBoxDiagnosis.Text,
                    assistantsList,
                    doctorsList);
                MessageBox.Show(response);

                this.Close();
            }
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

        private void iconButtonConfirm_Click_1(object sender, EventArgs e)
        {

        }
    }
}
