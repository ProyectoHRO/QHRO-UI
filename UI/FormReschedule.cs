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
        private ClassGetStrings stringsClass = new ClassGetStrings();
        private Surgeries surgeries = new Surgeries();
        int Qid, idSurgerie;
        string qx, hour;
        public FormReschedule(int idSurgeriee, string pacientName, string numberQ, string Hour, int idQ)
        {
            InitializeComponent();
            idSurgerie = idSurgeriee;
            qx = numberQ;
            Qid = idQ;
            hour = Hour;
            textBoxName.Text = pacientName;
            textBoxName.ReadOnly = true;
            comboBoxOperatingRooms.Text = qx;

            string[] response;
            string hora = hour;
            string[] timeSep = stringsClass.getStrings(hora, new char[] { ':', ' ' });
            string h = timeSep[0];
            string m = timeSep[1];
            string AorP = timeSep[2];

            comboBoxHour.Text = h;
            comboBoxMin.Text = m;
            comboBoxTime.Text = AorP;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonContinue_Click(object sender, EventArgs e)
        {
            if (comboBoxOperatingRooms.Enabled==true)
            {
                Qid = Convert.ToInt32(comboBoxOperatingRooms.SelectedValue);
            }
            string resp = surgeries.reSchedule(idSurgerie, Qid, dateTimePickerNewDate.Value, comboBoxHour.Text + ':' + comboBoxMin.Text + ' ' + comboBoxTime.Text);
            MessageBox.Show(resp);
            this.Close();
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelchangeHour_Click(object sender, EventArgs e)
        {
            comboBoxHour.Enabled = true;
            comboBoxMin.Enabled = true;
            comboBoxTime.Enabled = true;
        }

        private void labelchangeRoom_Click(object sender, EventArgs e)
        {
            comboBoxOperatingRooms.Enabled = true;
            DataTable infoOperatingRooms = operatingRooms.listoperatingRooms();
            comboBoxOperatingRooms.ValueMember = "idquirofano";
            comboBoxOperatingRooms.DisplayMember = "no_quirofano";
            comboBoxOperatingRooms.DataSource = infoOperatingRooms;
        }

        private void FormReschedule_Load(object sender, EventArgs e)
        {
           
        }
    }
}
