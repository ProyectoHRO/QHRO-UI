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
        int userId;
        public FormEmergencies()
        {
            InitializeComponent();
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                labelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dateTimeSurgeryDate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                string hora = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string[] response = strings.getStrings(hora,new char[] { ':', ' '});
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
                textBoxSearch.Enabled = false;
                iconButtonSearchNames.Enabled = false;
               
        }

        private void iconButtonSearchNames_Click(object sender, EventArgs e)
        {

            groupBoxpatientData.Enabled = true;
            groupBoxDocsData.Enabled = true;
            groupBoxAssistantsData.Enabled = true;
            groupBoxAnesthetistData.Enabled = true;
            iconButtonConfirm.Enabled = true;
        }
    }
}
