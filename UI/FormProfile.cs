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

        void EncryptPassword()
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


            if ((textBoxnewPassword.Enabled == true) && (textBoxUser.Enabled == true))
            {
                if (textBoxnewPassword.Text != "")
                {

                    if (textBoxnewPassword.Text == textBoxnewPasswordConfirm.Text)
                    {
                        EncryptPassword();
                        if ((textBoxUser.Text == lastUser) && (textBoxEmail.Text == lastEmail) && (password == lastPassword))
                        {
                            MessageBox.Show("No hay cambios por guardar");
                        }

                        else if (((textBoxUser.Text != lastUser) || (textBoxEmail.Text != lastEmail)) && (password != lastPassword))
                        {
                            string response = users.modifyUserData(textBoxUser.Text, textBoxEmail.Text, password, DateTime.Now, Convert.ToInt32(labelId.Text));
                            if (response.ToUpper().Contains("ERROR"))
                            {
                                MessageBox.Show(response);
                            }
                            else
                            {
                                MessageBox.Show("Los datos se actualizaron correctamente, por favor inicie sesión de nuevo");
                                this.Close();
                            }
                            Application.Restart();
                        }

                        else if ((textBoxUser.Text == lastUser) && (textBoxEmail.Text == lastEmail) && (password != lastPassword))
                        {
                            string response = users.modifyUserData(lastUser, lastEmail, password, DateTime.Now, Convert.ToInt32(labelId.Text));
                            if (response.ToUpper().Contains("ERROR"))
                            {
                                MessageBox.Show(response);
                            }
                            else
                            {
                                MessageBox.Show("La contraseña se cambio exitosamente, por favor inicie sesión nuevamente");
                                this.Close();
                            }
                            Application.Restart();
                        }

                        else if ((textBoxUser.Text != lastUser) || (textBoxEmail.Text != lastEmail))
                        {
                            if (password==lastPassword)
                            {
                                MessageBox.Show("La contraseña es igual a la anterior, por favor cambiela");
                            }
                            else
                            {
                                if ((textBoxUser.Text != lastUser) && (textBoxEmail.Text == lastEmail))
                                {
                                    string response = users.modifyUserData(textBoxUser.Text, lastEmail, password, DateTime.Now, Convert.ToInt32(labelId.Text));
                                    if (response.ToUpper().Contains("ERROR"))
                                    {
                                        MessageBox.Show(response);
                                    }
                                    else
                                    {
                                        MessageBox.Show("El nombre de usuario se cambio exitosamente, por favor inicie sesión nuevamente");
                                        this.Close();
                                    }
                                    Application.Restart();
                                }

                                else if ((textBoxUser.Text == lastUser) && (textBoxEmail.Text != lastEmail))
                                {
                                    string response = users.modifyUserData(lastUser, textBoxEmail.Text, password, DateTime.Now, Convert.ToInt32(labelId.Text));
                                    if (response.ToUpper().Contains("ERROR"))
                                    {
                                        MessageBox.Show(response);
                                    }
                                    else
                                    {
                                        MessageBox.Show("El correo se cambio exitosamente, por favor inicie sesión nuevamente");
                                        this.Close();
                                    }
                                    Application.Restart();
                                }
                            }
                        }

                    }

                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }

                else
                {
                    MessageBox.Show("Ingrese nueva contraseña valida");
                }
            }

            else if ((textBoxUser.Enabled == true) && (textBoxnewPassword.Enabled == false))
            {
                if ((textBoxUser.Text == lastUser) && (textBoxEmail.Text == lastEmail))
                {
                    MessageBox.Show("No hay cambios por guardar");
                }

                else
                {
                    if ((textBoxUser.Text != lastUser) && (textBoxEmail.Text != lastEmail))
                    {
                        string response = users.modifyUserData(textBoxUser.Text, textBoxEmail.Text, "n", DateTime.Now, Convert.ToInt32(labelId.Text));
                        if (response.ToUpper().Contains("ERROR"))
                        {
                            MessageBox.Show(response);
                        }
                        else
                        {
                            MessageBox.Show("Los datos se actualizaron exitosamente, por favor inicie sesión nuevamente");
                            this.Close();
                        }
                        Application.Restart();
                    }

                    else if ((textBoxUser.Text != lastUser) && (textBoxEmail.Text == lastEmail))
                    {
                        string response = users.modifyUserData(textBoxUser.Text, lastEmail, "n", DateTime.Now, Convert.ToInt32(labelId.Text));
                        if (response.ToUpper().Contains("ERROR"))
                        {
                            MessageBox.Show(response);
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario se cambio exitosamente, por favor inicie sesión nuevamente");
                            this.Close();
                        }
                        Application.Restart();
                    }

                    else if ((textBoxUser.Text == lastUser) && (textBoxEmail.Text != lastEmail))
                    {
                        string response = users.modifyUserData(lastUser, textBoxEmail.Text, "n", DateTime.Now, Convert.ToInt32(labelId.Text));
                        if (response.ToUpper().Contains("ERROR"))
                        {
                            MessageBox.Show(response);
                        }
                        else
                        {
                            MessageBox.Show("El correo se cambio exitosamente, por favor inicie sesión nuevamente");
                            this.Close();
                        }
                        Application.Restart();
                    }
                }
            }

            else if ((textBoxnewPassword.Enabled == true) && (textBoxUser.Enabled == false))
            {
                if (textBoxnewPassword.Text != "")
                {
                    if (textBoxnewPassword.Text == textBoxnewPasswordConfirm.Text)
                    {
                        EncryptPassword();

                        if (password == lastPassword)
                        {
                            MessageBox.Show("La contraseña es igual a la anterior");                          
                        }

                        else
                        {
                            string response = users.modifyUserData(lastUser, lastEmail, password, DateTime.Now, Convert.ToInt32(labelId.Text));
                            if (response.ToUpper().Contains("ERROR"))
                            {
                                MessageBox.Show(response);
                            }
                            else
                            {
                                MessageBox.Show("La contraseña se cambio exitosamente, por favor inicie sesión nuevamente");
                                this.Close();
                            }
                            Application.Restart();
                        }

                    }

                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }

                else
                {
                    MessageBox.Show("Ingrese nueva contraseña valida");
                }
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
