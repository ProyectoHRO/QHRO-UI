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
    public partial class FormSearch : Form
    {
        private ClassDoctor doctors = new ClassDoctor();
        private ClassAnesthetist anesthethist= new ClassAnesthetist();
        private ClassAssistants assistants = new ClassAssistants();
        private ClassPatient patients = new ClassPatient();
        private ClassServices services = new ClassServices();
        public FormSearch()
        {
            InitializeComponent();
        }

        void insertPersonData(DataTable dataPerson, int typePerson)
        {
            if (dataPerson.Rows.Count < 1)
            {
                MessageBox.Show("No se pudo encontrar el registro");
            }
            else
            {
                string name = "";
                string secondName = "";
                string thirdName = "";
                string firstSurname = "";
                string secondSurname = "";
                string cui = "";
                string number = "";
                string email = "";
                if (typePerson == 1)
                {
                    string specialty = "";
                    foreach (DataRow item in dataPerson.Rows)
                    {
                        cui = item.Field<string>(1).ToString();
                        try
                        {
                            name = item.Field<string>(2).ToString();
                            firstSurname = item.Field<string>(5).ToString();
                            if (item.Field<string>(6) != null)
                            {
                                secondSurname = item.Field<string>(6).ToString();
                            }
                            if (item.Field<string>(3) != null)
                            {
                                secondName = item.Field<string>(3).ToString();
                            }
                            if (item.Field<string>(4) != null)
                            {
                                thirdName = item.Field<string>(4).ToString();
                            }


                        }
                        catch (Exception)
                        {

                        }

                        number = item.Field<string>(7).ToString();
                        email = item.Field<string>(8).ToString();
                        specialty = item.Field<string>(10).ToString();
                    }
                    if (secondName != "")
                    {
                        name = name + ' ' + secondName;
                    }

                    if (thirdName != "")
                    {
                        name = name + ' ' + thirdName;
                    }
                    name = name + ' ' + firstSurname;
                    if (secondSurname != "")
                    {
                        name = name + ' ' + secondSurname;
                    }

                    ReportDataSource Report;
                    Report = new ReportDataSource();
                    this.reportViewerDoctor.ProcessingMode = ProcessingMode.Local;
                    this.reportViewerDoctor.LocalReport.ReportEmbeddedResource = @"UI.Reports.ReportDoctor.rdlc";
                    this.reportViewerDoctor.LocalReport.DataSources.Clear();
                    Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                new Microsoft.Reporting.WinForms.ReportParameter("nombreDoctor",name),
                new Microsoft.Reporting.WinForms.ReportParameter("cui",cui),
                new Microsoft.Reporting.WinForms.ReportParameter("numero",number),
                new Microsoft.Reporting.WinForms.ReportParameter("correo",email),
                new Microsoft.Reporting.WinForms.ReportParameter("especialidad",specialty)
                    };
                    this.reportViewerDoctor.LocalReport.SetParameters(rParams);
                    this.reportViewerDoctor.LocalReport.DataSources.Add(Report);
                    this.reportViewerDoctor.RefreshReport();
                }
                else if (typePerson == 2)
                {
                    foreach (DataRow item in dataPerson.Rows)
                    {
                        cui = item.Field<string>(1).ToString();
                        try
                        {
                            name = item.Field<string>(2).ToString();
                            firstSurname = item.Field<string>(5).ToString();
                            if (item.Field<string>(6) != null)
                            {
                                secondSurname = item.Field<string>(6).ToString();
                            }
                            if (item.Field<string>(3) != null)
                            {
                                secondName = item.Field<string>(3).ToString();
                            }
                            if (item.Field<string>(4) != null)
                            {
                                thirdName = item.Field<string>(4).ToString();
                            }


                        }
                        catch (Exception)
                        {

                        }

                        number = item.Field<string>(7).ToString();
                        email = item.Field<string>(8).ToString();
                    }
                    if (secondName != "")
                    {
                        name = name + ' ' + secondName;
                    }

                    if (thirdName != "")
                    {
                        name = name + ' ' + thirdName;
                    }
                    name = name + ' ' + firstSurname;
                    if (secondSurname != "")
                    {
                        name = name + ' ' + secondSurname;
                    }

                    ReportDataSource Report;
                    Report = new ReportDataSource();
                    this.reportViewerAnesthetist.ProcessingMode = ProcessingMode.Local;
                    this.reportViewerAnesthetist.LocalReport.ReportEmbeddedResource = @"UI.Reports.ReportAnesthetist.rdlc";
                    this.reportViewerAnesthetist.LocalReport.DataSources.Clear();
                    Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                new Microsoft.Reporting.WinForms.ReportParameter("nombreAnestesista",name),
                new Microsoft.Reporting.WinForms.ReportParameter("cui",cui),
                new Microsoft.Reporting.WinForms.ReportParameter("numero",number),
                new Microsoft.Reporting.WinForms.ReportParameter("correo",email)
                    };
                    this.reportViewerAnesthetist.LocalReport.SetParameters(rParams);
                    this.reportViewerAnesthetist.LocalReport.DataSources.Add(Report);
                    this.reportViewerAnesthetist.RefreshReport();
                }
                else if (typePerson == 3)
                {
                    int idAssistant = 0;
                    int typeAssistant = 0;
                    string typeAssistantName = "";
                    foreach (DataRow item in dataPerson.Rows)
                    {
                        cui = item.Field<string>(1).ToString();
                        try
                        {
                            idAssistant = Convert.ToInt32(item.Field<int>(0));
                            name = item.Field<string>(2).ToString();
                            firstSurname = item.Field<string>(5).ToString();
                            if (item.Field<string>(6) != null)
                            {
                                secondSurname = item.Field<string>(6).ToString();
                            }
                            if (item.Field<string>(3) != null)
                            {
                                secondName = item.Field<string>(3).ToString();
                            }
                            if (item.Field<string>(4) != null)
                            {
                                thirdName = item.Field<string>(4).ToString();
                            }


                        }
                        catch (Exception)
                        {

                        }

                        number = item.Field<string>(8).ToString();
                        email = item.Field<string>(7).ToString();
                        typeAssistant = Convert.ToInt32(item.Field<int>(10));
                    }
                    if (secondName != "")
                    {
                        name = name + ' ' + secondName;
                    }

                    if (thirdName != "")
                    {
                        name = name + ' ' + thirdName;
                    }
                    name = name + ' ' + firstSurname;
                    if (secondSurname != "")
                    {
                        name = name + ' ' + secondSurname;
                    }

                    DataTable typeAssistantsInfo = assistants.getTypeAssistantById(typeAssistant);
                    foreach (DataRow item in typeAssistantsInfo.Rows)
                    {
                        typeAssistantName = item.Field<string>(1).ToString();
                    }


                    ReportDataSource Report;
                    Report = new ReportDataSource();
                    this.reportViewerAssistant.ProcessingMode = ProcessingMode.Local;
                    this.reportViewerAssistant.LocalReport.ReportEmbeddedResource = @"UI.Reports.ReportAssistant.rdlc";
                    this.reportViewerAssistant.LocalReport.DataSources.Clear();
                    Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                new Microsoft.Reporting.WinForms.ReportParameter("nombreAsistente",name),
                new Microsoft.Reporting.WinForms.ReportParameter("cui",cui),
                new Microsoft.Reporting.WinForms.ReportParameter("numero",number),
                new Microsoft.Reporting.WinForms.ReportParameter("correo",email),
                new Microsoft.Reporting.WinForms.ReportParameter("nombreTipoAsistente",typeAssistantName)
                    };
                    this.reportViewerAssistant.LocalReport.SetParameters(rParams);
                    this.reportViewerAssistant.LocalReport.DataSources.Add(Report);
                    this.reportViewerAssistant.RefreshReport();
                }
                else if (typePerson == 4)
                {
                    int idPacient = 0;
                    string historyNumber = "";
                    short age = 0;
                    string gender = "";

                    foreach (DataRow item in dataPerson.Rows)
                    {
                        idPacient = Convert.ToInt32(item.Field<int>(0));
                        historyNumber = item.Field<string>(1).ToString();
                        try
                        {
                            name = item.Field<string>(2).ToString();
                            firstSurname = item.Field<string>(5).ToString();
                            if (item.Field<string>(6) != null)
                            {
                                secondSurname = item.Field<string>(6).ToString();
                            }
                            if (item.Field<string>(3) != null)
                            {
                                secondName = item.Field<string>(3).ToString();
                            }
                            if (item.Field<string>(4) != null)
                            {
                                thirdName = item.Field<string>(4).ToString();
                            }


                        }
                        catch (Exception)
                        {

                        }

                        age = Convert.ToInt16(item.Field<short>(7));
                        gender = item.Field<string>(8).ToString();

                    }
                    if (secondName != "")
                    {
                        name = name + ' ' + secondName;
                    }

                    if (thirdName != "")
                    {
                        name = name + ' ' + thirdName;
                    }
                    name = name + ' ' + firstSurname;
                    if (secondSurname != "")
                    {
                        name = name + ' ' + secondSurname;
                    }
                    List<ClassDiagnosis> diagnosisList = new List<ClassDiagnosis>();
                    DataTable infoPatients = patients.getDiagnosisByPatient(idPacient);
                    ClassDiagnosis diagosis;
                    string date;
                    string format;
                    foreach (DataRow item in infoPatients.Rows)
                    {
                        diagosis = new ClassDiagnosis();
                        diagosis.id_diagnostico = Convert.ToInt32(item.Field<int>(0));
                        diagosis.diagnostico = item.Field<string>(1).ToString();
                        //OBTENGO LA FECHA
                        // date = Convert.ToDateTime(item.Field<string>(2));
                        date = item.Field<string>(2);
                        //INTENTO DE DAT FORMATO
                        //format = date.ToShortDateString();
                        //ENVIO LA FECHA
                        diagosis.fecha_diagnostico = date;
                        diagosis.idpaciente = Convert.ToInt32(item.Field<int>(3));
                        diagnosisList.Add(diagosis);
                    }
                    ReportDataSource Report;
                    Report = new ReportDataSource("DataSetDiagnosis", diagnosisList);
                    this.reportViewerPacientDiagnosis.ProcessingMode = ProcessingMode.Local;
                    this.reportViewerPacientDiagnosis.LocalReport.ReportEmbeddedResource = @"UI.Reports.ReportPacientDiagnosis.rdlc";
                    this.reportViewerPacientDiagnosis.LocalReport.DataSources.Clear();
                    Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                new Microsoft.Reporting.WinForms.ReportParameter("noHistoria",historyNumber),
                new Microsoft.Reporting.WinForms.ReportParameter("nombrePaciente",name),
                new Microsoft.Reporting.WinForms.ReportParameter("edad",age.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("genero",gender),
                    };
                    this.reportViewerPacientDiagnosis.LocalReport.SetParameters(rParams);
                    this.reportViewerPacientDiagnosis.LocalReport.DataSources.Add(Report);
                    this.reportViewerPacientDiagnosis.RefreshReport();
                }
            }
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            this.reportViewerDoctor.RefreshReport();
            comboBoxFilterDoctor.SelectedIndex = 0;
            comboBoxAnesthetist.SelectedIndex = 0;
            comboBoxAssistant.SelectedIndex = 0;
            comboBoxPatient.SelectedIndex = 0;
        }

        private void iconButtonSearchDoctor_Click(object sender, EventArgs e)
        {
            if (comboBoxFilterDoctor.Text=="DPI")
            {
                DataTable dataDoctor = doctors.getDoctorByDpi(textBoxSearchDoctor.Text);
               
                insertPersonData(dataDoctor,1);
            }
            else
            {
                DataTable dataDoctor = doctors.getDoctorByName(textBoxSearchDoctor.Text);
                insertPersonData(dataDoctor,1);
            }
        }

        private void iconButtonSearchAnesthetist_Click(object sender, EventArgs e)
        {
            if (comboBoxAnesthetist.Text == "DPI")
            {
                DataTable dataAnestethist = anesthethist.getAnesthetistByDpi(textBoxAnesthethist.Text);
                insertPersonData(dataAnestethist, 2);
            }
            else
            {
                DataTable dataAnestethist = anesthethist.getAnesthetistByname(textBoxAnesthethist.Text);
                insertPersonData(dataAnestethist, 2);
            }
        }

        private void iconButtonAssistant_Click(object sender, EventArgs e)
        {
            if (comboBoxAssistant.Text == "DPI")
            {
                DataTable dataAssistant = assistants.getAssistantByDpi(textBoxAssistant.Text);
                insertPersonData(dataAssistant, 3);
            }
            else
            {
                DataTable dataAssistant = assistants.getAssistantByName(textBoxAssistant.Text);
                insertPersonData(dataAssistant, 3);
            }
        }

        private void iconButtonPatient_Click_2(object sender, EventArgs e)
        {
            if (comboBoxPatient.Text == "No. Historia")
            {
                DataTable dataPatient = patients.getPatientsByHistoryNumber(textBoxPacient.Text);
                insertPersonData(dataPatient, 4);
            }
            else
            {
                DataTable dataPatient = patients.getPatientsByName(textBoxPacient.Text);
                insertPersonData(dataPatient, 4);
            }
        }

        private void reportViewerPacientDiagnosis_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSearchDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxFilterDoctor.SelectedIndex == 0)
            {
                label1.Location = new Point(498, 36);
                textBoxSearchDoctor.Location = new Point(555, 33);
                textBoxSearchDoctor.Size = new System.Drawing.Size(275, 26);
                textBoxSearchDoctor.MaxLength = 13;
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
            }
            else if (comboBoxFilterDoctor.SelectedIndex == 1)
            {
                label1.Location = new Point(17, 36);
                textBoxSearchDoctor.Location = new Point(77, 33);
                textBoxSearchDoctor.Size = new System.Drawing.Size(700, 26);
                textBoxSearchDoctor.MaxLength = 250;
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void textBoxAnesthethist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxAnesthetist.SelectedIndex == 0)
            {
                label2.Location = new Point(498, 36);
                textBoxAnesthethist.Location = new Point(555, 33);
                textBoxAnesthethist.Size = new System.Drawing.Size(275, 26);
                textBoxAnesthethist.MaxLength = 13;
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
            }
            else if (comboBoxAnesthetist.SelectedIndex == 1)
            {
                label2.Location = new Point(17, 36);
                textBoxAnesthethist.Location = new Point(77, 33);
                textBoxAnesthethist.Size = new System.Drawing.Size(700, 26);
                textBoxAnesthethist.MaxLength = 250;
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void textBoxAssistant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxAssistant.SelectedIndex == 0)
            {
                label3.Location = new Point(498, 36);
                textBoxAssistant.Location = new Point(555, 33);
                textBoxAssistant.Size = new System.Drawing.Size(275, 26);
                textBoxAssistant.MaxLength = 13;
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
            }
            else if (comboBoxAssistant.SelectedIndex == 1)
            {
                label3.Location = new Point(17, 36);
                textBoxAssistant.Location = new Point(77, 33);
                textBoxAssistant.Size = new System.Drawing.Size(700, 26);
                textBoxAssistant.MaxLength = 250;
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void textBoxPacient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxPatient.SelectedIndex == 0)
            {
                label4.Location = new Point(498, 36);
                textBoxPacient.Location = new Point(555, 33);
                textBoxPacient.Size = new System.Drawing.Size(275, 26);
                textBoxPacient.MaxLength = 250;
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && !(char.IsDigit(e.KeyChar)))
                {
                    e.Handled = true;
                    return;
                }
            }
            else if (comboBoxPatient.SelectedIndex == 1)
            {
                label4.Location = new Point(17, 36);
                textBoxPacient.Location = new Point(77,33);
                textBoxPacient.Size = new System.Drawing.Size(700, 26);
                textBoxPacient.MaxLength = 250;
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
