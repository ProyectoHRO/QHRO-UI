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
    public partial class FormEditInterventios : Form
    {
        int selectionMode = 0;
        private ClassRequestSurgery surgeries = new ClassRequestSurgery();
        private ClassOperatingRoom operatingRooms = new ClassOperatingRoom();
        private Surgeries surgeriesLogic = new Surgeries();
        private ClassMail mail = new ClassMail();
        private ClassAnesthesia anesthesia = new ClassAnesthesia();
        private ClassDoctor doctorss = new ClassDoctor();
        private ClassAssistants assists = new ClassAssistants();
        private ClassGetStrings strings = new ClassGetStrings();
        int userId;
        string time;
        public FormEditInterventios(int idUser)
        {
            InitializeComponent();
            userId = idUser;
        }
        void ListRequestedSugreries()
        {
            
            DataTable surgeriesWithoutAnesInfo = surgeries.GetSurgeriesWithoutAnesthetist();

            if (surgeriesWithoutAnesInfo.Rows.Count < 1)
            {

            }
            else
            {
                dataGridView1.DataSource = surgeriesWithoutAnesInfo;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                dataGridView1.Refresh();
            }
        }

        private void FormEditInterventios_Load(object sender, EventArgs e)
        {
            ListRequestedSugreries();
            DataTable infoOperatingRooms = operatingRooms.listoperatingRooms();
            comboBoxOperatingRooms.ValueMember = "idquirofano";
            comboBoxOperatingRooms.DisplayMember = "no_quirofano";
            comboBoxOperatingRooms.DataSource = infoOperatingRooms;
        }
        private void tableLayoutPanel14_Paint(object sender, PaintEventArgs e)
        {

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectionMode = 1;
            try
            {
                listViewDoctors.Items.Clear();
                iconButtonConfirm.Enabled = true;             
                labelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable infoAnesthetist = surgeries.getInfoAnesthetist(Convert.ToInt32(labelID.Text));
                foreach (DataRow item in infoAnesthetist.Rows)
                {
                    textBoxHistory.Text = item.Field<string>(0).ToString();
                    textBoxName.Text = item.Field<string>(1).ToString();
                    textBoxLastName.Text = item.Field<string>(2).ToString();
                    string surgeryType = item.Field<string>(3).ToString();
                    if (surgeryType == "Selectiva")
                    {
                        comboBoxSurgeryType.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBoxSurgeryType.SelectedIndex = 1;
                    }
                    textBoxDiagnosis.Text = item.Field<string>(4).ToString();
                    string surgeryRelevance = item.Field<string>(5).ToString();
                    if (surgeryRelevance == "Mayor")
                    {
                        comboBoxRelevance.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBoxRelevance.SelectedIndex = 1;
                    }
                    dateTimeSurgeryDate.Value = Convert.ToDateTime(item.Field<System.DateTime>(6));
                    time = item.Field<string>(7).ToString();
                    string[] response = strings.getStrings(time, new char[] { ':', ' ' });
                    comboBoxHour.Text = response[0];
                    comboBoxMin.Text = response[1];
                    comboBoxTime.Text = response[2];
                    comboBoxOperatingRooms.SelectedValue = item.Field<int>(8);
                    labelIdProgram.Text = item.Field<int>(9).ToString();

                    groupBoxpatientData.Enabled = false;
                    groupBoxDocsData.Enabled = false;
                    groupBoxAssistantsData.Enabled = false;
                    DataTable docs = surgeriesLogic.ObtenerDoctoresAsignados(Convert.ToInt32(labelID.Text));
                    foreach (DataRow item2 in docs.Rows)
                    {
                        ListViewItem itemList2 = new ListViewItem(item2.Field<string>(1).ToString());
                        listViewDoctors.Items.Add(itemList2);
                        listBoxDocId.Items.Add(item2.Field<int>(0));
                    }
                    groupBoxAssistantsData.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void iconButtonAddAnesthetist_Click(object sender, EventArgs e)
        {
            selectPerson selectP = new selectPerson(1);
            selectP.ShowDialog();
        }

        private void iconButtonConfirm_Click(object sender, EventArgs e)
        {
            
            List<ClassDtoAssistants> assistantsList = new List<ClassDtoAssistants>();
            ClassDtoAssistants assistant;
            for (int i = 0; i < listBoxIds.Items.Count; i++)
            {
                listBoxIds.SelectedIndex = i;
                assistant = new ClassDtoAssistants();
                assistant.AssistandId = Convert.ToInt32(listBoxIds.SelectedItem);
                assistantsList.Add(assistant);
            }

            string response = surgeriesLogic.AssignAssist(
                Convert.ToInt32(labelID.Text),
                assistantsList);
            if (response == "Se ha asignado la cirugía con éxito!")
            {
                for (int i = 0; i < listBoxDocId.Items.Count; i++)
                {
                    listBoxDocId.SelectedIndex = i;
                    string getMail = assists.getAssistantById(Convert.ToInt32(listBoxDocId.SelectedItem));
                    response = mail.MakeMail(getMail,
                        "Se le ha asignado para una intervención el día: " + dateTimeSurgeryDate.Value.Day.ToString() + "/" + dateTimeSurgeryDate.Value.Month.ToString() + "/" + dateTimeSurgeryDate.Value.Year.ToString() + " a las: " + comboBoxHour.Text + ':' + comboBoxMin.Text + ' ' + comboBoxTime.Text
                       + " \n Del paciente: " + textBoxName.Text + " " + textBoxLastName.Text + " con numero de historia: " + textBoxHistory.Text, "Intervención", "Se ha asignado la cirugía con éxito!");
                }
                MessageBox.Show(response);
            }
            else
            {
                MessageBox.Show(response);
            }
            ListRequestedSugreries();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButtonAddAnesthetist_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void iconButtonAddAssistant_Click_1(object sender, EventArgs e)
        {
            selectPerson selectP = new selectPerson(3);
            selectP.ShowDialog();

            listBoxIds.Items.Add(selectP.id);
            ListViewItem item = new ListViewItem(selectP.assistantType.ToString());
            item.SubItems.Add(selectP.name.ToString());
            listViewAssistants.Items.Add(item);
        }
    }
}
