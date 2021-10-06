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
using Microsoft.Reporting.WinForms;
namespace UI
{
    public partial class FormDailyReport : Form
    {
        private Surgeries surgeries = new Surgeries();
        public FormDailyReport()
        {
            InitializeComponent();
        }

        private void FormDailyReport_Load(object sender, EventArgs e)
        {

            this.reportViewerDailies.RefreshReport();
        }


        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            DataTable infoReport = surgeries.getDailyReport(dateTimePickerReport.Value);
            List<ClassDailyReport> listDailies = new List<ClassDailyReport>();
            ClassDailyReport dailie;
            int idSurgery = 0;
            foreach (DataRow item in infoReport.Rows)
            {
                dailie = new ClassDailyReport();
                idSurgery = Convert.ToInt32(item.Field<int>(0));
                dailie.No_Historia = item.Field<string>(1).ToString();
                dailie.Nombre = item.Field<string>(2).ToString();
                dailie.Sexo = item.Field<string>(3).ToString();
                dailie.Edad = Convert.ToInt16(item.Field<short>(4));
                dailie.Tiempo = "1 hora";
                dailie.Servicio = item.Field<string>(5).ToString();
                dailie.Operacion_Realizada = item.Field<string>(6).ToString();
                dailie.Tipo_Anestesia = item.Field<string>(7).ToString();
                DataTable getSurgeries = surgeries.getDoctorsByIdSurgerie(idSurgery);
                if (getSurgeries.Rows.Count < 2)
                {
                    foreach (DataRow itemDoc in getSurgeries.Rows)
                    {
                        dailie.Cirujano = itemDoc.Field<string>(1).ToString();
                        dailie.Especialidad = itemDoc.Field<string>(2).ToString();
                    }
                }
                dailie.Tipo_Cirugia = item.Field<string>(8).ToString();
                listDailies.Add(dailie);
            }
            ReportDataSource Report;
            Report = new ReportDataSource("DataSetDailyReport", listDailies);
            this.reportViewerDailies.ProcessingMode = ProcessingMode.Local;
            this.reportViewerDailies.LocalReport.ReportEmbeddedResource = @"UI.Reports.DailyReport.rdlc";
            this.reportViewerDailies.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("fechaHoy",DateTime.Now.ToString()),
                //new Microsoft.Reporting.WinForms.ReportParameter("nombrePaciente",name),
                //new Microsoft.Reporting.WinForms.ReportParameter("edad",age.ToString()),
                //new Microsoft.Reporting.WinForms.ReportParameter("genero",gender),
            };
            this.reportViewerDailies.LocalReport.SetParameters(rParams);
            this.reportViewerDailies.LocalReport.DataSources.Add(Report);
            this.reportViewerDailies.RefreshReport();
        }
    }
}
