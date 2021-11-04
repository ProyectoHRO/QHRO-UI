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
        private ClassGetStrings stringsClass = new ClassGetStrings();
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

            foreach (DataRow item in infoReport.Rows)
            {
                int idSurgery = 0;
                string docName = "";
                string specialties = "";
                string initHour = "";
                string initMin = "";
                string finalHour = "";
                string finalMin = "";
                string[] response;
                dailie = new ClassDailyReport();
                idSurgery = Convert.ToInt32(item.Field<int>(0));
                dailie.No_Historia = item.Field<string>(1).ToString();
                dailie.Nombre = item.Field<string>(2).ToString();
                dailie.Sexo = item.Field<string>(3).ToString();
                dailie.Edad = Convert.ToInt16(item.Field<short>(4));
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
                else
                {
                    foreach (DataRow itemDoc in getSurgeries.Rows)
                    {
                        docName = docName + itemDoc.Field<string>(1).ToString() + '/';
                        specialties = specialties + itemDoc.Field<string>(2).ToString() + '/';
                    }
                    dailie.Cirujano = docName.TrimEnd('/');
                    dailie.Especialidad = specialties.TrimEnd('/');
                }
                dailie.Tipo_Cirugia = item.Field<string>(8).ToString();
                initHour = item.Field<string>(9).ToString();
                finalHour = item.Field<string>(10).ToString();
               
                if (initHour.Contains("P"))
                {
                    response = stringsClass.getStrings(initHour, new char[] { ':', ' ', 'P', 'A', '.', 'M' });
                    initHour = ((Convert.ToInt32(response[0]) % 12) + 12).ToString();
                    initMin = response[1];
                }
                if (initHour.Contains("A"))
                {
                    response = stringsClass.getStrings(initHour, new char[] { ':',' ', 'P', 'A', '.', 'M' });
                    initHour = response[0];
                    initMin = response[1];
                }

                response = stringsClass.getStrings(finalHour, new char[] { ':' });
                finalHour = response[0];
                finalMin = response[1];
                DateTime f1 = Convert.ToDateTime(initHour +":" + initMin + ":00");
                DateTime f2 = Convert.ToDateTime(finalHour+":"+finalMin+":00");
                Decimal hours = Convert.ToDecimal(f2.Subtract(f1).TotalHours);
                hours = decimal.Round(hours, 2, MidpointRounding.AwayFromZero);
                dailie.Tiempo = Convert.ToString(hours+" Horas");

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

        private void iconButtonDiff_Click(object sender, EventArgs e)
        {
        
            DataTable infoReport = surgeries.getDailyDiff(dateTimePickerDiff.Value);
            List<ClassDailyDiff> listDiffs = new List<ClassDailyDiff>();
            ClassDailyDiff diffs;


            foreach (DataRow item in infoReport.Rows)
            {
                int idSurgery = 0;
                string docName = "";
                string specialties = "";
                diffs = new ClassDailyDiff();
                idSurgery = Convert.ToInt32(item.Field<int>(0));
                diffs.No_Historia = item.Field<string>(1).ToString();
                diffs.Nombre_Paciente = item.Field<string>(2).ToString();
                diffs.Servicio = item.Field<string>(3).ToString();
                diffs.Operacion_Suspendida = item.Field<string>(4).ToString();
                diffs.Motivo_Suspension = item.Field<string>(5).ToString();
                DataTable getSurgeries = surgeries.getDoctorsByIdSurgerie(idSurgery);
                if (getSurgeries.Rows.Count < 2)
                {
                    foreach (DataRow itemDoc in getSurgeries.Rows)
                    {
                        diffs.Medico_Suspende = itemDoc.Field<string>(1).ToString();
                        diffs.Especialidad = itemDoc.Field<string>(2).ToString();
                    }
                }
                else
                {
                    foreach (DataRow itemDoc in getSurgeries.Rows)
                    {
                        docName = docName + itemDoc.Field<string>(1).ToString() + '/';
                        specialties = specialties + itemDoc.Field<string>(2).ToString() + '/';
                    }
                    diffs.Medico_Suspende = docName.TrimEnd('/');
                    diffs.Especialidad = specialties.TrimEnd('/');
                }
                listDiffs.Add(diffs);
            }
            ReportDataSource Report;
            Report = new ReportDataSource("DataSetDailyDiff", listDiffs);
            this.reportViewerDiff.ProcessingMode = ProcessingMode.Local;
            this.reportViewerDiff.LocalReport.ReportEmbeddedResource = @"UI.Reports.ReportDiff.rdlc";
            this.reportViewerDiff.LocalReport.DataSources.Clear();
            //Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            //{
            //    new Microsoft.Reporting.WinForms.ReportParameter("fechaHoy",DateTime.Now.ToString()),
            //    //new Microsoft.Reporting.WinForms.ReportParameter("nombrePaciente",name),
            //    //new Microsoft.Reporting.WinForms.ReportParameter("edad",age.ToString()),
            //    //new Microsoft.Reporting.WinForms.ReportParameter("genero",gender),
            //};
            //this.reportViewerDailies.LocalReport.SetParameters(rParams);
            this.reportViewerDiff.LocalReport.DataSources.Add(Report);
            this.reportViewerDiff.RefreshReport();
        }

        private void reportViewerDailies_Load(object sender, EventArgs e)
        {
            reportViewerDailies.PrinterSettings.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(5, 5, 10, 10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
