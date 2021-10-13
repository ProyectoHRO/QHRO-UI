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

        public bool Activate { get; set; }
     
        public Form1(string userLog, int role, int serviceId)
        {
            InitializeComponent();
            labelUserLog.Text = userLog;
        }
        private Form activeForm = null;
        private void openChildForm(object formChild)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            Form fh = formChild as Form;
            activeForm = fh;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            openChildForm(new FormMain());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new Doctors());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Activate = true;
            this.Close();
        }

        private void pictureBoxMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMaximized_Click(object sender, EventArgs e)
        {
            pictureBoxMaximized.Visible = false;
            pictureBoxNormal.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBoxNormal_Click(object sender, EventArgs e)
        {
            pictureBoxMaximized.Visible = true;
            pictureBoxNormal.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new Anesthetist());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new Assistant());
        }

        private void iconButtonPatient_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new Patient());
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButtonOperatingRooms_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new OperatingRooms());
        }

        private void iconButtonServices_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new Services());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new RequestSurgery());
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new assignSurgery());
        }
        int statePanel = 0;
        private void iconButtonReports_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = true;
            statePanel++;
            if (statePanel==2)
            {
                statePanel = 0;
                panelReportsMenu.Visible = false;
            }

        }

        private void iconButtonSurgerys_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new FormViewInterventions());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new Users());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new FormUserPermits());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new FormSearch());
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new FormDailyReport());
        }

        private void iconButtonSchedules_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new FormsSchedules());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new FormViweOperatingRooms());
        }
    }
}
