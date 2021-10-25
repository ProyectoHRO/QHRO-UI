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
            List<ClassDailySurgeries> surgeriesList = new List<ClassDailySurgeries>();
            ClassDailySurgeries surgerie = new ClassDailySurgeries(); ;
            DataTable surgeriesData = surgeries.getDailySurgeries();


            foreach (DataRow item in surgeriesData.Rows)
            {
                string docName = "";
                string assistantName = "";
                surgerie = new ClassDailySurgeries();
                surgerie.IdCirugia = Convert.ToInt32(item.Field<int>(0));
                surgerie.Hora = item.Field<string>(1).ToString();
                surgerie.Qx = item.Field<string>(2).ToString();
                surgerie.No_Historia = item.Field<string>(3).ToString();
                surgerie.Nombre = item.Field<string>(4).ToString();
                surgerie.Edad = Convert.ToInt16(item.Field<short>(5));
                surgerie.Procedimiento = item.Field<string>(6).ToString();
                surgerie.Servicio = item.Field<string>(7).ToString();
                DataTable infoDoctor = surgeries.getDoctorsByIdSurgerie(surgerie.IdCirugia);
                if (infoDoctor.Rows.Count < 2)
                {
                    foreach (DataRow itemDoc in infoDoctor.Rows)
                    {
                        surgerie.Cirujano = itemDoc.Field<string>(1).ToString();
                    }
                }
                else
                {
                    foreach (DataRow itemDoc in infoDoctor.Rows)
                    {
                        docName = ' ' + docName + itemDoc.Field<string>(1).ToString() + " / ";
                    }
                    surgerie.Cirujano = docName.TrimEnd(' ');
                    surgerie.Cirujano = surgerie.Cirujano.TrimEnd('/');
                }
                surgerie.Anestesista = item.Field<string>(8).ToString();
                DataTable infoAssistants = surgeries.getAssistantsBySurgerie(surgerie.IdCirugia);
                if (infoAssistants.Rows.Count < 2)
                {
                    foreach (DataRow itemAssistant in infoAssistants.Rows)
                    {
                        surgerie.Asistentes = itemAssistant.Field<string>(1).ToString();
                    }
                }
                else
                {
                    foreach (DataRow itemAssistant in infoAssistants.Rows)
                    {
                        assistantName = assistantName + itemAssistant.Field<string>(1).ToString() + '/';
                    }
                    surgerie.Asistentes = assistantName.TrimEnd('/');
                }
                surgeriesList.Add(surgerie);
            }

            dataGridViewSchedule.DataSource = surgeriesList;
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
