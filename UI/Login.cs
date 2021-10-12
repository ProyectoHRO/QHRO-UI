using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class Login : Form
    {
        string password;
        string queryResult;
        string hash = "@HR0";
        private ClassUsers user;
        private ClassMail mails = new ClassMail();
        int logCount;
        bool confirmation;
        DateTime lastConnection;
        int idUser;
        int role;
        string mail;


        int serviceId;
        public Login()
        {
            InitializeComponent();
            user = new ClassUsers();
        }

        private void pictureBoxMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
                txtUser.Text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
                txtUser.Text = "USUARIO";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        int state = 1;
        private void iconPictureEye_Click(object sender, EventArgs e)
        {
            if (state==0)
            {
                txtPassword.UseSystemPasswordChar = true;
                iconPictureEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                state = 1;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                iconPictureEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                state = 0;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txtPassword.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    password = Convert.ToBase64String(results, 0, results.Length);
                }
            }


            queryResult = user.Login(txtUser.Text, password);
            if (queryResult.Contains("incorrectos"))
            {
                MessageBox.Show(queryResult, "Inicio de sesión no valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else

            {
                DataTable userData = user.getDataUser(txtUser.Text, password);
          
                foreach (DataRow item in userData.Rows)
                {
                    idUser = Convert.ToInt32(item.Field<int>(0));
                    role = Convert.ToInt32(item.Field<int>(5));
                    lastConnection = Convert.ToDateTime(item.Field<System.DateTime>(8));
                    confirmation = item.Field<bool>(9);
                    logCount = Convert.ToInt32(item.Field<int>(10));
                    serviceId = Convert.ToInt32(item.Field<int>(11));
                    mail = item.Field<string>(12).ToString();
                }
                if (confirmation == false)
                {
                    if (MessageBox.Show("Usuario no confirmado, desea confirmarlo ahora?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ConfirmUser confirmForm = new ConfirmUser(idUser,lastConnection, txtUser.Text);
                        confirmForm.ShowDialog();
                    }
                }
                else
                {
                    if (logCount==0)
                    {
                        mails.MakeMail(mail,"Has iniciado sesión por primera vez en el sistema de quirófanos. \n Con el usuario: "+ txtUser.Text +" \n A las: "+ DateTime.Now.ToString(),"PRIMER INICIO DE SESIÓN SISTEMA DE QUIRÓFANOS","");
                    }
                    
                        logCount++;
                        user.addLoginCount(idUser, logCount, lastConnection);
                        this.Hide();
                        FormWelcome fW = new FormWelcome(txtUser.Text, role, serviceId);
                        fW.labelUser.Text = txtUser.Text;
                        fW.ShowDialog();
                    
                }
              
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgot = new FormForgotPassword();
            formForgot.ShowDialog();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
