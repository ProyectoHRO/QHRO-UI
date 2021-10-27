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
        string pacientName = "";
        int formClosed;
        int surgerieId;
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
        }

        private void iconButtonReSchedule_Click(object sender, EventArgs e)
        {
            FormDiffers fDiffers = new FormDiffers(1, surgerieId, pacientName);
            fDiffers.Show();
            loadData();
        }

        private void iconButtonFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show(surgeries.finishSurgerie(surgerieId));
            loadData();
        }

        private void FormsSchedules_Activated(object sender, EventArgs e)
        {
           
        }
    }
}
