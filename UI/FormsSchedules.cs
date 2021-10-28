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
    public partial class FormsSchedules : Form
    {
        private ClassReports reports =new ClassReports();
        private Surgeries surgeries = new Surgeries();
        private ClassGetStrings stringsClass = new ClassGetStrings();
        private 
        string pacientName = "";
        int formClosed;
        int surgerieId;
        string hour;
        public FormsSchedules()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            dataGridViewSchedule.DataSource = reports.dailySchedule();
            dataGridViewSchedule.Columns[0].Visible = false;
            dataGridViewSchedule.AutoResizeColumns();
            dataGridViewSchedule.AutoResizeRows();
            dataGridViewSchedule.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void iconButtonDiffer_Click(object sender, EventArgs e)
        {
            FormDiffers fDiffers = new FormDiffers(2, surgerieId,pacientName);
            fDiffers.Show();
        }

        private void FormsSchedules_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iconButtonDiffer.Enabled = true;
            iconButtonReSchedule.Enabled = true;
            iconButtonFinish.Enabled = true;
            surgerieId = Convert.ToInt32(dataGridViewSchedule.Rows[e.RowIndex].Cells[0].Value);
            pacientName = dataGridViewSchedule.Rows[e.RowIndex].Cells[4].Value.ToString();
            hour = dataGridViewSchedule.Rows[e.RowIndex].Cells[1].Value.ToString();
            label2.Text = hour.ToString();
        }

        private void iconButtonReSchedule_Click(object sender, EventArgs e)
        {
            FormDiffers fDiffers = new FormDiffers(1, surgerieId, pacientName);
            fDiffers.Show();
            loadData();
        }

        private void iconButtonFinish_Click(object sender, EventArgs e)
        {
            string[] response;
            string initHour="";
            string initMin="";
            if (hour.Contains("P"))
            {
                response = stringsClass.getStrings(hour, new char[] { ':', ' ', 'P', 'A', '.', 'M' });
                initHour = ((Convert.ToInt32(response[0]) % 12) + 12).ToString();
                initMin = response[1];
            }
            if (hour.Contains("A"))
            {
                response = stringsClass.getStrings(hour, new char[] { ':', ' ', 'P', 'A', '.', 'M' });
                initHour = response[0];
                initMin = response[1];
            }

            DateTime f1 = Convert.ToDateTime(initHour + ":" + initMin + ":00");
            DateTime f2 = Convert.ToDateTime(DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString()+ ":00");

            if (f2.Hour > f1.Hour)
            {
                MessageBox.Show(surgeries.finishSurgerie(surgerieId));
                loadData();
            }
            else if(f2.Hour== f1.Hour)
            {
                if (f2.Minute > f1.Minute)
                {
                    MessageBox.Show(surgeries.finishSurgerie(surgerieId));
                    loadData();
                }
                else
                {
                    MessageBox.Show("No puedes finalizar una cirugía que aun no ha comenzado.");
                }
            }
            else
            {
                MessageBox.Show("No puedes finalizar una cirugía que aun no ha comenzado.");
            }
        }

        private void FormsSchedules_Activated(object sender, EventArgs e)
        {
           
        }
    }
}
