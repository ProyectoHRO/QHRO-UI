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
    public partial class FormForgotPassword : Form
    {
        string hash = "@HR0";
        int id;
        string password;
        private ClassUsers users = new ClassUsers();
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(textBoxEmail.Text=="CORREO" || textBoxEmail.Text==" ")
            {
                MessageBox.Show("Debes Ingresar un correo", "Sin correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                DataTable getuser = users.getUserByEmail(textBoxEmail.Text);
                if (getuser.Rows.Count < 1)
                {
                    MessageBox.Show("El correo no esta registrado");
                    textBoxEmail.Clear();
                    textBoxEmail.Text="CORREO";
                }
                else
                {

                    foreach (DataRow item in getuser.Rows)
                    {
                        id = Convert.ToInt32(item.Field<int>(0));
                    }

                    byte[] data = UTF8Encoding.UTF8.GetBytes("QUIROFANOSHRO" + id.ToString());
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
                    string userName = "QHRO" + id.ToString();
                    string response = users.restoreUserPass(id, userName, password);
                    if (response.ToUpper().Contains("ERROR"))
                    {
                        MessageBox.Show(response);
                    }
                    else
                    {
                        System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                        msg.To.Add(textBoxEmail.Text);
                        msg.Subject = "SOLICITUD DE RESTABLECIMIENTO DE USUARIO";
                        msg.SubjectEncoding = System.Text.Encoding.UTF8;

                        msg.Body = "NOMBRE DE USUARIO: " + userName + "\nCONTRASEÑA: QUIROFANOSHRO" + id.ToString();
                        msg.BodyEncoding = System.Text.Encoding.UTF8;
                        msg.From = new System.Net.Mail.MailAddress("quirofanoshro@gmail.com");

                        System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                        client.Credentials = new System.Net.NetworkCredential("quirofanoshro@gmail.com", "QuirofanosHROGT");

                        client.Port = 587;
                        client.EnableSsl = true;

                        client.Host = "smtp.gmail.com";

                        try
                        {
                            client.Send(msg);
                            MessageBox.Show(response);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Error al enviar");
                        }
                    }

                }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "CORREO")
                textBoxEmail.Text = "";
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
                textBoxEmail.Text = "CORREO";
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            
        }
    }
}
