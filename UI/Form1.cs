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

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Doctors());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
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
            openChildForm(new Anesthetist());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new Assistant());
        }

        private void iconButtonPatient_Click(object sender, EventArgs e)
        {
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
    }
}
