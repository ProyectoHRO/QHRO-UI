using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login a = new login();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //takeAndSaveActualForm
        private Form currentChildForm;

        //OpenFormChilds
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoctorForm());
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void anesthetist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AnesthetistForm());
        }

        private void assistant_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AssitantForm());
        }

        private void patient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PatientForm());
        }
    }
}
