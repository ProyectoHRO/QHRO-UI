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
    public partial class ConfirmUser : Form
    {
        int id;
        DateTime lastConnection;
        string password;
        string hash = "@HR0";
        private ClassUsers users = new ClassUsers();
        public ConfirmUser(int idUser, DateTime last, string userName)
        {
            InitializeComponent();
            id = idUser;
            txtUser.Text = userName;
            lastConnection = last;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (textConfirmPassword.Text==txtPassword.Text)
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

                string response=users.ConfirmUser(id,txtUser.Text,password,lastConnection);
                if (response.ToUpper().Contains("ERROR"))
                {
                    MessageBox.Show(response);
                }
                else
                {
                    MessageBox.Show(response);
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
                txtUser.Text = "";
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
                txtUser.Text = "USUARIO";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
                
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.UseSystemPasswordChar = false;
            }
               
        }

        private void textConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (textConfirmPassword.Text == "CONFIRMAR CONTRASEÑA")
            {
                textConfirmPassword.Text = "";
                textConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void textConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (textConfirmPassword.Text == "")
            {
                textConfirmPassword.Text = "CONFIRMAR CONTRASEÑA";
                textConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        int state = 1;
        private void iconPictureEye_Click(object sender, EventArgs e)
        {
            if (state == 0)
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

        int state1 = 1;
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            if (state1 == 0)
            {
                textConfirmPassword.UseSystemPasswordChar = true;
                iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Eye;
                state1 = 1;
            }
            else
            {
                textConfirmPassword.UseSystemPasswordChar = false;
                iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                state1 = 0;
            }
        }

        private void ConfirmUser_Load(object sender, EventArgs e)
        {

        }
    }
}
