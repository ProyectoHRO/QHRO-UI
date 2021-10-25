using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace UI
{
    public partial class FormUserPermits : Form
    {
  
        private ClassUsers users = new ClassUsers();
        int userId;
        bool hasPermits;
        public FormUserPermits(int idUser)
        {
            InitializeComponent();
            userId = idUser;
        }

        private void FormUserPermits_Load(object sender, EventArgs e)
        {
            DataTable infoPermits = users.GetPermits();
            foreach (DataRow item in infoPermits.Rows)
            {
                listBoxIdPermits.Items.Add(Convert.ToInt32(item.Field<int>(0)));
                checkedListBoxPermits.Items.Add(item.Field<string>(1).ToString());
            }
            
            comboBoxFilter.SelectedIndex = 1;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 0)
            {
                textBoxSearch.Text = "BUSCAR POR USUARIO";
            }else if (comboBoxFilter.SelectedIndex == 1)
            {
                textBoxSearch.Text = "BUSCAR POR CORREO";
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != " ")
                textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            //if (comboBoxFilter.SelectedIndex == 0)
            //{
            //    textBoxSearch.Text = "BUSCAR POR USUARIO";
            //}
            //else if (comboBoxFilter.SelectedIndex == 1)
            //{
            //    textBoxSearch.Text = "BUSCAR POR CORREO";
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxPermits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void getPermits(string idUser)
        {
            for (int i = 0; i < listBoxIdPermits.Items.Count; i++)
                checkedListBoxPermits.SetItemChecked(i, false);
  
            DataTable infoPermits=users.getPermitsByUserId(Convert.ToInt32(idUser));
            if (infoPermits.Rows.Count<1)
            {
                hasPermits = false;
            }
            else
            {
                hasPermits = true;
                List<int> listUserPermits = new List<int>();
                foreach (DataRow item in infoPermits.Rows)
                {
                    listUserPermits.Add(Convert.ToInt32(item.Field<int>(1)));
                }

                for (int i = 0; i < listBoxIdPermits.Items.Count; i++)
                {
                    listBoxIdPermits.SelectedIndex = i;
                    for (int j = 0; j < listUserPermits.Count; j++)
                    {
                        if (Convert.ToInt32(listBoxIdPermits.SelectedItem) == listUserPermits[j])
                        {
                            checkedListBoxPermits.SetItemChecked(listBoxIdPermits.SelectedIndex,true);
                        }
                    }


                }
            }
          
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 0)
            { //BY USER
                DataTable infoUser = users.GetUserByUserName(textBoxSearch.Text);
                if (infoUser.Rows.Count < 1)
                {
                    MessageBox.Show("El usuario no esta registrado");
                }
                else
                {
                    foreach (DataRow item in infoUser.Rows)
                    {
                        labelId.Text = item.Field<int>(0).ToString();
                        textBoxUser.Text = item.Field<string>(1).ToString();
                        textBoxEmail.Text= item.Field<string>(12).ToString();
                        textBoxEmail.Enabled = false;
                        textBoxUser.Enabled = false;
                    }
                    getPermits(labelId.Text);
                }
            }
            else if (comboBoxFilter.SelectedIndex == 1)
            { //BY MAIL

                DataTable getuser = users.getUserByEmail(textBoxSearch.Text);
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
                        textBoxEmail.Text = item.Field<string>(12).ToString();
                        textBoxEmail.Enabled = false;
                        textBoxUser.Enabled = false;
                    }
                    getPermits(labelId.Text);
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonGrant_Click(object sender, EventArgs e)
        {
            if (hasPermits==false)
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
            }
            else
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
                string response = users.modifyPermits(userId,
                Convert.ToInt32(labelId.Text),
                  permitsList);
                MessageBox.Show(response);
            }

        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //expresion regular ^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$
        }
    }
}
