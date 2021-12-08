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
using System.Text.RegularExpressions;
using BLL;
namespace UI
{
    public partial class Users : Form
    {
        private ClassUsers users = new ClassUsers();
        private ClassMail mail = new ClassMail();

        string userName;
        int userId;
        string hash = "@HR0";
        private ClassServices services = new ClassServices();
        public Users(int idUser)
        {
            InitializeComponent();
            userId = idUser;
        }
       
        private void Users_Load(object sender, EventArgs e)
        {
            DataTable infoRoles = users.GetRoles();
            comboBoxRole.ValueMember = "idrol";
            comboBoxRole.DisplayMember = "nombrerol";
            comboBoxRole.DataSource = infoRoles;

            DataTable infoServices = services.getServices();
            comboBoxServices.ValueMember = "idservicio";
            comboBoxServices.DisplayMember = "nombreservicio";
            comboBoxServices.DataSource = infoServices;

            DataTable infoPermits = users.GetPermits();
            foreach (DataRow item in infoPermits.Rows)
            {
                listBoxIdPermits.Items.Add(Convert.ToInt32(item.Field<int>(0)));
                checkedListBoxPermits.Items.Add(item.Field<string>(1).ToString());
            }
        }

        private void iconButtonCreateAndRequest_Click(object sender, EventArgs e)
        {
            int state = 0;
            if (label6.Text == "v")
            {
                state = 1;
            }
            if (state ==1)
            {
                if (Convert.ToInt32(comboBoxRole.SelectedValue) == 4)
                {
                    //ToUpper().Contains("ERROR")
                    userName = users.addUser(textBoxEmail.Text, Convert.ToInt32(comboBoxRole.SelectedValue), Convert.ToInt32(comboBoxServices.SelectedValue));
                }
                else
                {
                    userName = users.addUser(textBoxEmail.Text, Convert.ToInt32(comboBoxRole.SelectedValue), 0);
                }
                if (userName.ToUpper().Contains("ERROR"))
                {
                    MessageBox.Show(userName);
                }
                else
                {
                    string password = "";
                    char delimiter = ':';
                    string[] newphrase = userName.Split(delimiter);

                    byte[] data = UTF8Encoding.UTF8.GetBytes("QUIROFANOSHRO" + newphrase[1]);
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

                    users.makeUserPass(Convert.ToInt32(newphrase[1]), password);

                    MessageBox.Show(mail.MakeMail(textBoxEmail.Text, "NOMBRE DE USUARIO: " + newphrase[0] + "\nCONTRASEÑA: QUIROFANOSHRO" + newphrase[1], "INFORMACIÓN DE USUARIO", "Usuario creado correctamente, porfavor verificar correo "));
                    if (MessageBox.Show("¿Desea asignar permisos?", "Asignar permisos",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        groupBoxAssignPermits.Visible = true;
                        DataTable getuser = users.getUserByEmail(textBoxEmail.Text);
                        if (getuser.Rows.Count < 1)
                        {
                            MessageBox.Show("El correo no esta registrado");
                        }
                        else
                        {
                            foreach (DataRow item in getuser.Rows)
                            {
                                labelId.Text = item.Field<int>(0).ToString();
                                textBoxUser.Text = item.Field<string>(1).ToString();
                                textBoxMail.Text = item.Field<string>(12).ToString();
                                textBoxMail.Enabled = false;
                                textBoxUser.Enabled = false;
                            }

                        }
                    }
                    else
                    {
                        this.Close();
                        state = 0;
                    }

                }
                state = 0;
            }
            else
            {
                MessageBox.Show("Correo inválido");
            }
            
            
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBoxRole.SelectedValue)==4)
            {
                comboBoxServices.Visible = true;
                label3.Visible = true;
            }
            else
            {
                comboBoxServices.Visible = false;
                label3.Visible = false;
            }
        }

        private void iconButtonGrant_Click(object sender, EventArgs e)
        {
            List<ClassDtoPermits> permitsList = new List<ClassDtoPermits>();
            ClassDtoPermits permit;

            for (int i = 0; i < checkedListBoxPermits.Items.Count; i++)
            {
                listBoxIdPermits.SelectedIndex = i;
                if (checkedListBoxPermits.GetItemChecked(i))
                {
                    permit = new ClassDtoPermits();
                    permit.IdPermit = Convert.ToInt32(listBoxIdPermits.SelectedItem);
                    permit.IdUser = Convert.ToInt32(labelId.Text);
                    permitsList.Add(permit);
                }
            }
            string response = users.assignPermits( userId, Convert.ToInt32(labelId.Text),
              permitsList);
            MessageBox.Show(response);
            this.Close();
        }
        public void regeXp(string re, TextBox tb, PictureBox pc)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.check;
                label6.Text = "v";
            }
            else
            {
                pc.Image = Properties.Resources.x;
                label6.Text = "f";
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            regeXp(@"^[aA-zZ0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[aA-zZ0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[aA-zZ0-9](?:[aA-zZ0-9-]*[aA-zZ0-9])?\.)+[aA-zZ0-9](?:[aA-zZ0-9-]*[aA-zZ0-9])?$", textBoxEmail, boxValidateMail);
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                textBoxSearch.Text = "BUSCAR";
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "BUSCAR")
                textBoxSearch.Text = "";
        }
    }
}
