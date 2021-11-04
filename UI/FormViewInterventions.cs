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
    public partial class FormViewInterventions : Form
    {
        private Surgeries surgeries = new Surgeries();
        private ClassServices services = new ClassServices();
        private ClassAnesthesia anesthesia = new ClassAnesthesia();
        private ClassOperatingRoom operatingRooms = new ClassOperatingRoom();
        public FormViewInterventions()
        {
            InitializeComponent();
        }

        private void FormViewInterventions_Load(object sender, EventArgs e)
        {
            this.reportViewerSurgeriesBdates.RefreshReport();
            DataTable infoOperatingRooms = operatingRooms.listoperatingRooms();
            comboBoxOperatingRooms.ValueMember = "idquirofano";
            comboBoxOperatingRooms.DisplayMember = "no_quirofano";
            comboBoxOperatingRooms.DataSource = infoOperatingRooms;
        }

        private void iconButtonSurgeriesBdates_Click(object sender, EventArgs e)
        {
            getDates getDate = new getDates();
            getDate.ShowDialog();
            DateTime firstDate = getDate.firstDate;
            DateTime secondDate = getDate.secondDate;
            DataTable infoSurgeries = surgeries.getSurgeriesByDates(firstDate,secondDate);
            List<ClassDailyReport> listSurgerie = new List<ClassDailyReport>();
            ClassDailyReport surgerie;


            foreach (DataRow item in infoSurgeries.Rows)
            {
                int idSurgery = 0;
                string docName = "";
                string specialties = "";
                surgerie = new ClassDailyReport();
                idSurgery = Convert.ToInt32(item.Field<int>(0));
                surgerie.No_Historia = item.Field<string>(1).ToString();
                surgerie.Nombre = item.Field<string>(2).ToString();
                surgerie.Sexo = item.Field<string>(3).ToString();
                surgerie.Edad = Convert.ToInt16(item.Field<short>(4));
                surgerie.Servicio = item.Field<string>(5).ToString();
                surgerie.Operacion_Realizada = item.Field<string>(6).ToString();
                surgerie.Tipo_Anestesia = item.Field<string>(7).ToString();
                DataTable getSurgeries = surgeries.getDoctorsByIdSurgerie(idSurgery);
                if (getSurgeries.Rows.Count < 2)
                {
                    foreach (DataRow itemDoc in getSurgeries.Rows)
                    {
                        surgerie.Cirujano = itemDoc.Field<string>(1).ToString();
                        surgerie.Especialidad = itemDoc.Field<string>(2).ToString();
                    }
                }
                else
                {
                    foreach (DataRow itemDoc in getSurgeries.Rows)
                    {
                        docName = ' '+ docName + itemDoc.Field<string>(1).ToString() + " / ";
                        specialties = ' '+ specialties + itemDoc.Field<string>(2).ToString() + " / ";
                    }
                    surgerie.Cirujano = docName.TrimEnd(' ');
                    surgerie.Cirujano = surgerie.Cirujano.TrimEnd('/');
                    surgerie.Especialidad = specialties.TrimEnd(' ');
                    surgerie.Especialidad = surgerie.Especialidad.TrimEnd('/');
                }
                surgerie.Tipo_Cirugia = item.Field<string>(8).ToString();
                surgerie.Tiempo = item.Field<System.DateTime>(9).ToString("dd/MM/yyyy");
                listSurgerie.Add(surgerie);
            }
            ReportDataSource Report;
            Report = new ReportDataSource("DataSetInterventionsBday", listSurgerie);
            this.reportViewerSurgeriesBdates.ProcessingMode = ProcessingMode.Local;
            this.reportViewerSurgeriesBdates.LocalReport.ReportEmbeddedResource = @"UI.Reports.ReportSurgeriesBdate.rdlc";
            this.reportViewerSurgeriesBdates.LocalReport.DataSources.Clear();
            //Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            //{
            //    new Microsoft.Reporting.WinForms.ReportParameter("fechaHoy",DateTime.Now.ToString()),
            //    //new Microsoft.Reporting.WinForms.ReportParameter("nombrePaciente",name),
            //    //new Microsoft.Reporting.WinForms.ReportParameter("edad",age.ToString()),
            //    //new Microsoft.Reporting.WinForms.ReportParameter("genero",gender),
            //};
            //this.reportViewerSurgeriesBdates.LocalReport.SetParameters(rParams);
            this.reportViewerSurgeriesBdates.LocalReport.DataSources.Add(Report);
            this.reportViewerSurgeriesBdates.RefreshReport();
        }

        string serviceName ;
        private void iconButtonSurgeriesServicesBdates_Click(object sender, EventArgs e)
        {
            if (textBoxServiceName.Text!="")
            {
                DataTable infoService = services.getServicesByName(textBoxServiceName.Text);
                if (infoService.Rows.Count < 1)
                {
                    MessageBox.Show("No se encuentra el servicio, intentalo de nuevo");
                }
                else
                {
                    getDates getDate = new getDates();
                    getDate.ShowDialog();
                    DateTime firstDate = getDate.firstDate;
                    DateTime secondDate = getDate.secondDate;
                    DataTable infoSurgeries = surgeries.getSurgeriesByServiceByDates(firstDate, secondDate, textBoxServiceName.Text);
                    List<ClassDailyReport> listSurgerie = new List<ClassDailyReport>();
                    ClassDailyReport surgerie;

                    foreach (DataRow item in infoSurgeries.Rows)
                    {
                        int idSurgery = 0;
                        string docName = "";
                        string specialties = "";
                        surgerie = new ClassDailyReport();
                        idSurgery = Convert.ToInt32(item.Field<int>(0));
                        surgerie.No_Historia = item.Field<string>(1).ToString();
                        surgerie.Nombre = item.Field<string>(2).ToString();
                        surgerie.Sexo = item.Field<string>(3).ToString();
                        surgerie.Edad = Convert.ToInt16(item.Field<short>(4));
                        surgerie.Servicio = item.Field<string>(5).ToString();
                        serviceName = surgerie.Servicio;
                        surgerie.Operacion_Realizada = item.Field<string>(6).ToString();
                        surgerie.Tipo_Anestesia = item.Field<string>(7).ToString();
                        DataTable getSurgeries = surgeries.getDoctorsByIdSurgerie(idSurgery);
                        if (getSurgeries.Rows.Count < 2)
                        {
                            foreach (DataRow itemDoc in getSurgeries.Rows)
                            {
                                surgerie.Cirujano = itemDoc.Field<string>(1).ToString();
                                surgerie.Especialidad = itemDoc.Field<string>(2).ToString();
                            }
                        }
                        else
                        {
                            foreach (DataRow itemDoc in getSurgeries.Rows)
                            {
                                docName = ' ' + docName + itemDoc.Field<string>(1).ToString() + " / ";
                                specialties = ' ' + specialties + itemDoc.Field<string>(2).ToString() + " / ";
                            }
                            surgerie.Cirujano = docName.TrimEnd(' ');
                            surgerie.Cirujano = surgerie.Cirujano.TrimEnd('/');
                            surgerie.Especialidad = specialties.TrimEnd(' ');
                            surgerie.Especialidad = surgerie.Especialidad.TrimEnd('/');
                        }
                        surgerie.Tipo_Cirugia = item.Field<string>(8).ToString();
                        surgerie.Tiempo = item.Field<System.DateTime>(9).ToString("dd/MM/yyyy");
                        listSurgerie.Add(surgerie);
                    }
                    ReportDataSource Report;
                    Report = new ReportDataSource("DataSetSurgeriesServicesBdate", listSurgerie);
                    this.reportViewerSurgeriesServiceBdates.ProcessingMode = ProcessingMode.Local;
                    this.reportViewerSurgeriesServiceBdates.LocalReport.ReportEmbeddedResource = @"UI.Reports.ReportSurgeriesServicesBdate.rdlc";
                    this.reportViewerSurgeriesServiceBdates.LocalReport.DataSources.Clear();
                    Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                    new Microsoft.Reporting.WinForms.ReportParameter("serviceName",serviceName),
                        //new Microsoft.Reporting.WinForms.ReportParameter("nombrePaciente",name),
                        //new Microsoft.Reporting.WinForms.ReportParameter("edad",age.ToString()),
                        //new Microsoft.Reporting.WinForms.ReportParameter("genero",gender),
                    };
                    this.reportViewerSurgeriesServiceBdates.LocalReport.SetParameters(rParams);
                    this.reportViewerSurgeriesServiceBdates.LocalReport.DataSources.Add(Report);
                    this.reportViewerSurgeriesServiceBdates.RefreshReport();
                }

            }

        }

        private void iconButtonSurgeriesQBdates_Click(object sender, EventArgs e)
        {
            getDates getDate = new getDates();
            getDate.ShowDialog();
            DateTime firstDate = getDate.firstDate;
            DateTime secondDate = getDate.secondDate;
            DataTable infoSurgeries = surgeries.getSurgeriesByQuiByDates(firstDate, secondDate, Convert.ToString(comboBoxOperatingRooms.SelectedValue));
            List<ClassQuiReport> listSurgerie = new List<ClassQuiReport>();
            ClassQuiReport surgerie;
            string Qx="";
            foreach (DataRow item in infoSurgeries.Rows)
            {
                int idSurgery = 0;
                string docName = "";
                string specialties = "";
                surgerie = new ClassQuiReport();
                idSurgery = Convert.ToInt32(item.Field<int>(0));
                surgerie.Qx = Convert.ToInt32(item.Field<string>(1));
                Qx = item.Field<string>(1).ToString();
                surgerie.No_Historia = item.Field<string>(2).ToString();
                surgerie.Nombre = item.Field<string>(3).ToString();
                surgerie.Sexo = item.Field<string>(4).ToString();
                surgerie.Edad = Convert.ToInt16(item.Field<short>(5));
                surgerie.Servicio = item.Field<string>(6).ToString();
                serviceName = surgerie.Servicio;
                surgerie.Operacion_Realizada = item.Field<string>(7).ToString();
                surgerie.Tipo_Anestesia = item.Field<string>(8).ToString();
                DataTable getSurgeries = surgeries.getDoctorsByIdSurgerie(idSurgery);
                if (getSurgeries.Rows.Count < 2)
                {
                    foreach (DataRow itemDoc in getSurgeries.Rows)
                    {
                        surgerie.Cirujano = itemDoc.Field<string>(1).ToString();
                        surgerie.Especialidad = itemDoc.Field<string>(2).ToString();
                    }
                }
                else
                {
                    foreach (DataRow itemDoc in getSurgeries.Rows)
                    {
                        docName = ' ' + docName + itemDoc.Field<string>(1).ToString() + " / ";
                        specialties = ' ' + specialties + itemDoc.Field<string>(2).ToString() + " / ";
                    }
                    surgerie.Cirujano = docName.TrimEnd(' ');
                    surgerie.Cirujano = surgerie.Cirujano.TrimEnd('/');
                    surgerie.Especialidad = specialties.TrimEnd(' ');
                    surgerie.Especialidad = surgerie.Especialidad.TrimEnd('/');
                }
                surgerie.Tipo_Cirugia = item.Field<string>(9).ToString();
                surgerie.Tiempo = item.Field<System.DateTime>(10).ToString("dd/MM/yyyy" );
                listSurgerie.Add(surgerie);
            }
            ReportDataSource Report;
            Report = new ReportDataSource("DataSetSurgeriesQBdate", listSurgerie);
            this.reportViewerSurgeriesQBdates.ProcessingMode = ProcessingMode.Local;
            this.reportViewerSurgeriesQBdates.LocalReport.ReportEmbeddedResource = @"UI.Reports.ReportSurgeriesQBdate.rdlc";
            this.reportViewerSurgeriesQBdates.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                    new Microsoft.Reporting.WinForms.ReportParameter("QuiNumber",Qx),
                //new Microsoft.Reporting.WinForms.ReportParameter("nombrePaciente",name),
                //new Microsoft.Reporting.WinForms.ReportParameter("edad",age.ToString()),
                //new Microsoft.Reporting.WinForms.ReportParameter("genero",gender),
            };
            this.reportViewerSurgeriesQBdates.LocalReport.SetParameters(rParams);
            this.reportViewerSurgeriesQBdates.LocalReport.DataSources.Add(Report);
            this.reportViewerSurgeriesQBdates.RefreshReport();

         }

        private void iconButtonSurgeriesByPatient_Click(object sender, EventArgs e)
        {
            DataTable infoSurgeries = surgeries.getSurgeriesByHistoryNumber(textBoxSurgeriesByPatient.Text);
            if (infoSurgeries.Rows.Count < 1)
            {
                MessageBox.Show("No se encuentra el Numero de Historia");
            }
            else
            {
                List<ClassReportByPatient> listSurgerie = new List<ClassReportByPatient>();
                ClassReportByPatient surgerie;
                string name = "";
                foreach (DataRow item in infoSurgeries.Rows)
                {
                    int idSurgery = 0;
                    string docName = "";
                    string specialties = "";
                    surgerie = new ClassReportByPatient();
                    idSurgery = Convert.ToInt32(item.Field<int>(0));
                    surgerie.Qx = Convert.ToInt32(item.Field<string>(1));
                    surgerie.No_Historia = item.Field<string>(2).ToString();
                    surgerie.Nombre = item.Field<string>(3).ToString();
                    name = item.Field<string>(3).ToString();
                    surgerie.Sexo = item.Field<string>(4).ToString();
                    surgerie.Edad = Convert.ToInt16(item.Field<short>(5));
                    surgerie.Servicio = item.Field<string>(6).ToString();
                    serviceName = surgerie.Servicio;
                    surgerie.Operacion_Realizada = item.Field<string>(7).ToString();
                    surgerie.Tipo_Anestesia = item.Field<string>(8).ToString();
                    DataTable getSurgeries = surgeries.getDoctorsByIdSurgerie(idSurgery);
                    if (getSurgeries.Rows.Count < 2)
                    {
                        foreach (DataRow itemDoc in getSurgeries.Rows)
                        {
                            surgerie.Cirujano = itemDoc.Field<string>(1).ToString();
                            surgerie.Especialidad = itemDoc.Field<string>(2).ToString();
                        }
                    }
                    else
                    {
                        foreach (DataRow itemDoc in getSurgeries.Rows)
                        {
                            docName = ' ' + docName + itemDoc.Field<string>(1).ToString() + " / ";
                            specialties = ' ' + specialties + itemDoc.Field<string>(2).ToString() + " / ";
                        }
                        surgerie.Cirujano = docName.TrimEnd(' ');
                        surgerie.Cirujano = surgerie.Cirujano.TrimEnd('/');
                        surgerie.Especialidad = specialties.TrimEnd(' ');
                        surgerie.Especialidad = surgerie.Especialidad.TrimEnd('/');
                    }
                    surgerie.Tipo_Cirugia = item.Field<string>(9).ToString();
                    surgerie.Fecha_Cirugia = Convert.ToDateTime(item.Field<System.DateTime>(10));
                    listSurgerie.Add(surgerie);
                }
                ReportDataSource Report;
                Report = new ReportDataSource("DataSetSurgeriesByHistoryNumber", listSurgerie);
                this.reportViewerSurgeriesByPatient.ProcessingMode = ProcessingMode.Local;
                this.reportViewerSurgeriesByPatient.LocalReport.ReportEmbeddedResource = @"UI.Reports.ReportSurgeriesByHistoryNumber.rdlc";
                this.reportViewerSurgeriesByPatient.LocalReport.DataSources.Clear();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("pacientName",name),
                    //new Microsoft.Reporting.WinForms.ReportParameter("nombrePaciente",name),
                    //new Microsoft.Reporting.WinForms.ReportParameter("edad",age.ToString()),
                    //new Microsoft.Reporting.WinForms.ReportParameter("genero",gender),
                };
                this.reportViewerSurgeriesByPatient.LocalReport.SetParameters(rParams);
                this.reportViewerSurgeriesByPatient.LocalReport.DataSources.Add(Report);
                this.reportViewerSurgeriesByPatient.RefreshReport();
            }
           
        }

        string anesthesiaName="";
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (textBoxAnesthesiaName.Text != "")
            {
                DataTable infoAnesthesia = anesthesia.getAnesthesiaByName(textBoxAnesthesiaName.Text);
                if (infoAnesthesia.Rows.Count < 1)
                {
                    MessageBox.Show("No se encuentra el tipo de anestesia, intentalo de nuevo");
                }
                else
                {
                    getDates getDate = new getDates();
                    getDate.ShowDialog();
                    DateTime firstDate = getDate.firstDate;
                    DateTime secondDate = getDate.secondDate;
                    DataTable infoSurgeries = surgeries.getSurgeriesByAnesthesiaByDates(firstDate, secondDate, textBoxAnesthesiaName.Text);
                  
                    if (infoSurgeries.Rows.Count < 1)
                    {
                        MessageBox.Show("No hay datos");
                    }
                    else
                    {

                        List<ClassDailyReport> listSurgerie = new List<ClassDailyReport>();
                        ClassDailyReport surgerie;

                        foreach (DataRow item in infoSurgeries.Rows)
                        {
                            int idSurgery = 0;
                            string docName = "";
                            string specialties = "";
                            surgerie = new ClassDailyReport();
                            idSurgery = Convert.ToInt32(item.Field<int>(0));
                            surgerie.No_Historia = item.Field<string>(1).ToString();
                            surgerie.Nombre = item.Field<string>(2).ToString();
                            surgerie.Sexo = item.Field<string>(3).ToString();
                            surgerie.Edad = Convert.ToInt16(item.Field<short>(4));
                            surgerie.Servicio = item.Field<string>(5).ToString();
                            surgerie.Operacion_Realizada = item.Field<string>(6).ToString();
                            surgerie.Tipo_Anestesia = item.Field<string>(7).ToString();
                            anesthesiaName = surgerie.Tipo_Anestesia;
                            DataTable getSurgeries = surgeries.getDoctorsByIdSurgerie(idSurgery);
                            if (getSurgeries.Rows.Count < 2)
                            {
                                foreach (DataRow itemDoc in getSurgeries.Rows)
                                {
                                    surgerie.Cirujano = itemDoc.Field<string>(1).ToString();
                                    surgerie.Especialidad = itemDoc.Field<string>(2).ToString();
                                }
                            }
                            else
                            {
                                foreach (DataRow itemDoc in getSurgeries.Rows)
                                {
                                    docName = ' ' + docName + itemDoc.Field<string>(1).ToString() + " / ";
                                    specialties = ' ' + specialties + itemDoc.Field<string>(2).ToString() + " / ";
                                }
                                surgerie.Cirujano = docName.TrimEnd(' ');
                                surgerie.Cirujano = surgerie.Cirujano.TrimEnd('/');
                                surgerie.Especialidad = specialties.TrimEnd(' ');
                                surgerie.Especialidad = surgerie.Especialidad.TrimEnd('/');
                            }
                            surgerie.Tipo_Cirugia = item.Field<string>(8).ToString();
                            surgerie.Tiempo = item.Field<System.DateTime>(9).ToString("dd/MM/yyyy");
                            listSurgerie.Add(surgerie);
                        }
                        ReportDataSource Report;
                        Report = new ReportDataSource("DataSetSurgeriesServicesBdate", listSurgerie);
                        this.reportViewerAnesthesiaByDates.ProcessingMode = ProcessingMode.Local;
                        this.reportViewerAnesthesiaByDates.LocalReport.ReportEmbeddedResource = @"UI.Reports.ReportSurgeriesAnesthesiaBdate.rdlc";
                        this.reportViewerAnesthesiaByDates.LocalReport.DataSources.Clear();
                        Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                        {
                             new Microsoft.Reporting.WinForms.ReportParameter("anesthesiaType",anesthesiaName),
                            //new Microsoft.Reporting.WinForms.ReportParameter("nombrePaciente",name),
                            //new Microsoft.Reporting.WinForms.ReportParameter("edad",age.ToString()),
                            //new Microsoft.Reporting.WinForms.ReportParameter("genero",gender),
                        };
                        this.reportViewerAnesthesiaByDates.LocalReport.SetParameters(rParams);
                        this.reportViewerAnesthesiaByDates.LocalReport.DataSources.Add(Report);
                        this.reportViewerAnesthesiaByDates.RefreshReport();

                    }



                }

            }
        }
    }
}
