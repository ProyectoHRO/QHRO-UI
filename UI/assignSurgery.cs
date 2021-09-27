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
        public assignSurgery()
        {
            InitializeComponent();
        }

        private void assignSurgery_Load(object sender, EventArgs e)
        {
            DataTable infoSurgeries = surgeries.getRequestedSurgeries();
            dataGridView1.DataSource = infoSurgeries;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView1.Refresh();

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
              
            }
            catch (Exception)
            {
            }
        }

        private void iconButtonAddAnesthetist_Click(object sender, EventArgs e)
        {
            selectPerson selectP = new selectPerson(1);
            selectP.ShowDialog();
        }

        private void iconButtonAddDoctor_Click(object sender, EventArgs e)
        {
            selectPerson selectP = new selectPerson(2);
            selectP.ShowDialog();
        }

        private void iconButtonAddAssistant_Click(object sender, EventArgs e)
        {
            selectPerson selectP = new selectPerson(3);
            selectP.ShowDialog();
        }
    }
}
