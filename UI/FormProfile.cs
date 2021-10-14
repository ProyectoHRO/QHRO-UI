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
        string hash = "@HR0";
        private ClassUsers users = new ClassUsers();
        public FormProfile(string userName)
        {
            InitializeComponent();
            getuserName = userName;
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            textBoxUser.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxnewPassword.Enabled = false;
            textBoxnewPasswordConfirm.Enabled = false;
            labelUserName.Text = getuserName;
            DataTable userData = users.GetUserByUserName(labelUserName.Text);
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
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (textBoxnewPassword.Enabled==false)
            {
                string response = users.modifyUserData(textBoxUser.Text, textBoxEmail.Text, "n", Convert.ToInt32(labelId.Text));
            }

            else if (textBoxnewPassword.Text == textBoxnewPasswordConfirm.Text)
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

                string response = users.modifyUserData(textBoxUser.Text, textBoxEmail.Text,password, Convert.ToInt32(labelId.Text));
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
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            textBoxEmail.Enabled = false;
            textBoxUser.Enabled = false;

        }

        private void labelEdit_Click(object sender, EventArgs e)
        {
            textBoxUser.Enabled = true;
            textBoxEmail.Enabled = true;
        }

        private void labelEditPassword_Click(object sender, EventArgs e)
        {
            textBoxnewPassword.Enabled = true;
            textBoxnewPasswordConfirm.Enabled = true;
        }
    }
}
