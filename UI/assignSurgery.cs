﻿using System;
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
    public partial class assignSurgery : Form
    {
        private ClassRequestSurgery surgeries = new ClassRequestSurgery();
        private ClassOperatingRoom operatingRooms = new ClassOperatingRoom();
        private Surgeries surgeriesLogic = new Surgeries();
        private ClassMail mail = new ClassMail();
        private ClassAnesthesia anesthesia = new ClassAnesthesia();
        private ClassDoctor doctorss = new ClassDoctor();
        int userId;
        public assignSurgery(int idUser)
        {
            InitializeComponent();
            userId = idUser;
        }

        void ListRequestedSugreries()
        {
            DataTable surgeriesInfo = surgeries.getRequestedSurgeries();
         
            if (surgeriesInfo.Rows.Count<1)
            {
               
            }
            else
            {
                dataGridView1.DataSource = surgeries.getRequestedSurgeries();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                dataGridView1.Refresh();
            }
        }

        void listAnesthesiaTypes()
        {
            DataTable anesthesiaList = anesthesia.getAnesthesia();
            foreach (DataRow item in anesthesiaList.Rows)
            {
                listBoxAnesthesiaId.Items.Add(Convert.ToInt32(item.Field<int>(0)));
                checkedListBoxAnesthesiaTypes.Items.Add(item.Field<string>(1).ToString());
            }
        }
        private void assignSurgery_Load(object sender, EventArgs e)
        {
            ListRequestedSugreries();
            listAnesthesiaTypes();
            DataTable infoOperatingRooms = operatingRooms.listoperatingRooms();
            comboBoxOperatingRooms.ValueMember = "idquirofano";
            comboBoxOperatingRooms.DisplayMember = "no_quirofano";
            comboBoxOperatingRooms.DataSource = infoOperatingRooms;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxHistory.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxName.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxLastName.Text= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                groupBoxpatientData.Enabled = true;
                groupBoxDocsData.Enabled = true;
                groupBoxAssistantsData.Enabled = true;
                groupBoxAnesthetistData.Enabled = true;
                groupBoxQuirfonanoData.Enabled = true;
                iconButtonConfirm.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void iconButtonAddAnesthetist_Click(object sender, EventArgs e)
        {
            selectPerson selectP = new selectPerson(1);
            selectP.ShowDialog();
            textBoxAnestethistName.Text = selectP.name;
            labelIdAnesthetist.Text = selectP.id.ToString();
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
            if (selectP.id!=0)
            {
                listBoxIds.Items.Add(selectP.id); 
                ListViewItem item = new ListViewItem(selectP.assistantType.ToString());
                item.SubItems.Add(selectP.name.ToString());
                listViewAssistants.Items.Add(item);
            }
            else { 
            
            }
        }

        private void groupBoxpatientData_Enter(object sender, EventArgs e)
        {

        }

        private void iconButtonConfirm_Click(object sender, EventArgs e)
        {

            if (checkedListBoxAnesthesiaTypes.CheckedItems.Count != 0)
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
                labelAnesthesiaTypesAsigned.Text = allTypes;
            }

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


            string response = surgeriesLogic.assignSurgery(
                userId,
                labelAnesthesiaTypesAsigned.Text,
                comboBoxSurgeryType.Text,
                dateTimeSurgeryDate.Value.Date,
                comboBoxHour.Text + ':' + comboBoxMin.Text + ' ' + comboBoxTime.Text,
                Convert.ToInt32(comboBoxOperatingRooms.SelectedValue),
                Convert.ToInt32(labelIdAnesthetist.Text),
                Convert.ToInt32(labelID.Text),
                comboBoxRelevance.Text,
                textBoxDiagnosis.Text,
               comboBoxHour.Text,
                assistantsList,
                doctorsList);
            if (response== "Se ha asignado la cirugía con éxito!")
            {
                for (int i = 0; i < listBoxDocId.Items.Count; i++)
                {
                    listBoxDocId.SelectedIndex = i;
                    string getMail = doctorss.getDoctorsById(Convert.ToInt32(listBoxDocId.SelectedItem));
                    response= mail.MakeMail(getMail,
                        "Se le ha asignado para una intervención el día: " + dateTimeSurgeryDate.Value.Day.ToString() + "/" + dateTimeSurgeryDate.Value.Month.ToString() + "/" + dateTimeSurgeryDate.Value.Year.ToString() + " a las: " + comboBoxHour.Text + ':' + comboBoxMin.Text + ' ' + comboBoxTime.Text
                       + " \n Del paciente: " + textBoxName.Text + " " + textBoxLastName.Text + " con numero de historia: "+ textBoxHistory.Text,"Intervención", "Se ha asignado la cirugía con éxito!");
                }
                MessageBox.Show(response);
            }
            else
            {
                MessageBox.Show(response);
            }
          
            this.Close();
        }

        private void iconButtonDeleteAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea eliminar al ayudante?","Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ayudante eliminado");
                if (listViewAssistants.Items.Count > 0)
                    listViewAssistants.Items.Remove(listViewAssistants.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
          
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewAssistants_Resize(object sender, EventArgs e)
        {
            listViewAssistants.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewAssistants.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewAssistants.Refresh();
        }

        private void iconButtonDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar al doctor?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Doctor eliminado");
                if (listViewDoctors.Items.Count > 0)
                    listViewDoctors.Items.Remove(listViewDoctors.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

            
        }
    }
}
