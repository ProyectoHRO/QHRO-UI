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
    public partial class assignSurgery : Form
    {
        private ClassRequestSurgery surgeries = new ClassRequestSurgery();
        private ClassOperatingRoom operatingRooms = new ClassOperatingRoom();
        private Surgeries surgeriesLogic = new Surgeries();
        public assignSurgery()
        {
            InitializeComponent();
        }

        void ListRequestedSugreries()
        {
            dataGridView1.DataSource = surgeries.getRequestedSurgeries();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView1.Refresh();
        }
        private void assignSurgery_Load(object sender, EventArgs e)
        {
            ListRequestedSugreries();
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
                ListViewItem item = new ListViewItem(selectP.name.ToString());
                item.SubItems.Add(selectP.assistantType.ToString());
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
                comboBoxAnesthesiaType.Text,
                comboBoxSurgeryType.Text,
                dateTimeSurgeryDate.Value,
                Convert.ToInt32(comboBoxOperatingRooms.SelectedValue),
                Convert.ToInt32(labelIdAnesthetist.Text),
                Convert.ToInt32(labelID.Text),
                comboBoxRelevance.Text,
                textBoxDiagnosis.Text,
                assistantsList,
                doctorsList);
            MessageBox.Show(response);
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
    }
}
