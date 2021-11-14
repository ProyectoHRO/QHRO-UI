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
    public partial class FormReschedule : Form
    {
        private ClassOperatingRoom operatingRooms = new ClassOperatingRoom();
        private Surgeries surgeries = new Surgeries();
        int typeA, idSurgerie;
        public FormReschedule(int idSurgeriee, string pacientName)
        {
            InitializeComponent();
            idSurgerie = idSurgeriee;
            textBoxName.Text = pacientName;
            textBoxName.ReadOnly = true;

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonContinue_Click(object sender, EventArgs e)
        {
            string resp = surgeries.reSchedule(idSurgerie, Convert.ToInt32(comboBoxOperatingRooms.SelectedValue), dateTimePickerNewDate.Value, comboBoxHour.Text + ':' + comboBoxMin.Text + ' ' + comboBoxTime.Text);
            MessageBox.Show(resp);
            this.Close();
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReschedule_Load(object sender, EventArgs e)
        {
            DataTable infoOperatingRooms = operatingRooms.listoperatingRooms();
            comboBoxOperatingRooms.ValueMember = "idquirofano";
            comboBoxOperatingRooms.DisplayMember = "no_quirofano";
            comboBoxOperatingRooms.DataSource = infoOperatingRooms;
        }
    }
}
