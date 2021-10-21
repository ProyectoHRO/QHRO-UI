using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BLL;
using System.Security.Cryptography;

namespace UI
{
    public partial class FormProfile : Form
    {
        string getuserName;
        string password;
        string lastUser;
        string lastPassword;
        string lastEmail;
        string hash = "@HR0";
        private ClassUsers users = new ClassUsers();
        public FormProfile(string userName)
        {
            InitializeComponent();
            getuserName = userName;
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            textBoxUser.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxnewPassword.Enabled = false;
            textBoxnewPasswordConfirm.Enabled = false;
            textBoxUser.Text = getuserName;
            DataTable userData = users.GetUserByUserName(getuserName);
            if (userData.Rows.Count < 1)
            {
                MessageBox.Show("El usuario no esta registrado");
            }
            else
            {
                foreach (DataRow item in userData.Rows)
                {
                    labelId.Text = item.Field<int>(0).ToString();
                    textBoxUser.Text = item.Field<string>(1).ToString();
                    textBoxEmail.Text = item.Field<string>(12).ToString();
                    lastUser = item.Field<string>(1).ToString();
                    lastPassword = item.Field<string>(2).ToString();
                    lastEmail = item.Field<string>(12).ToString();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            if ((textBoxUser.Enabled == true) && (textBoxnewPassword.Enabled == false))
            {
                if ((textBoxUser.Text == lastUser) && (textBoxEmail.Text == lastEmail))
                {
                    MessageBox.Show("No hay cambios por guardar");
                }

                else
                {
                    string response = users.modifyUserData(textBoxUser.Text, textBoxEmail.Text, "n", DateTime.Now, Convert.ToInt32(labelId.Text));
                    if (response.ToUpper().Contains("ERROR"))
                    {
                        MessageBox.Show(response);
                    }
                    else
                    {
                        MessageBox.Show(response);
                        this.Close();
                    }
                    Application.Restart();
                }
            }

            if ((textBoxnewPassword.Enabled == true) && (textBoxUser.Enabled == false))
            {
                if (textBoxnewPassword.Text=="")
                {
                    MessageBox.Show("La contraseña nueva no es valida");
                }

                else
                {
                    if (textBoxnewPassword.Text == textBoxnewPasswordConfirm.Text)
                    {
                        byte[] data = UTF8Encoding.UTF8.GetBytes(textBoxnewPasswordConfirm.Text);
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

                        if(password == lastPassword)
                        {
                            MessageBox.Show("La contraseña es igual a la anterior");
                        }

                        else
                        {
                            string response = users.modifyUserData(textBoxUser.Text, textBoxEmail.Text, password, DateTime.Now, Convert.ToInt32(labelId.Text));
                            if (response.ToUpper().Contains("ERROR"))
                            {
                                MessageBox.Show(response);
                            }
                            else
                            {
                                MessageBox.Show(response);
                                this.Close();
                            }
                            Application.Restart();
                        }
                    }

                    else if (textBoxnewPassword.Text != textBoxnewPasswordConfirm.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }
            }

            if ((textBoxnewPassword.Enabled == true) && (textBoxUser.Enabled == true))
            {
                if (textBoxnewPassword.Text == "")
                {
                    MessageBox.Show("La contraseña nueva no es valida");
                }
            }

            else if ((textBoxUser.Text == lastUser) && (textBoxEmail.Text == lastEmail) && (textBoxnewPassword.Enabled == false))
            {
                MessageBox.Show("No hay cambios por guardar");
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
        }

        private void labelEdit_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            textBoxUser.Enabled = true;
            textBoxEmail.Enabled = true;
        }

        private void labelEditPassword_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            textBoxnewPassword.Enabled = true;
            textBoxnewPasswordConfirm.Enabled = true;
        }
    }
}
