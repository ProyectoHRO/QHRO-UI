using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormWelcome : Form
    {
        string userLogin;
        int getRole;
        bool activate = false;
        int getServiceId;
        public FormWelcome(string userLog,int role,int serviceId)
        {
            InitializeComponent();
            userLogin = userLog;
            activate = false;
            getRole = role;
            getServiceId = serviceId;
        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.50;
            progressBarEnter.Value += 1;
            labelProgress.Text = progressBarEnter.Value.ToString() + "%";
            if (progressBarEnter.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity==0)
            {
                timer2.Stop();
                this.Hide();
                Form1 fI = new Form1(userLogin, getRole, getServiceId);
                fI.ShowDialog();
                activate = true;
            }
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            progressBarEnter.Value = 0;
            progressBarEnter.Minimum = 0;
            progressBarEnter.Maximum = 100;
            timer1.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss");
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void FormWelcome_Activated(object sender, EventArgs e)
        {
            if (activate==true)
            {
                this.Close();
            }
            
        }
    }
}
