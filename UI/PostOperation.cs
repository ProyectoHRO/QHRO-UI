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
    public partial class PostOperation : Form
    {
        private ClassAnesthesia anesthesia = new ClassAnesthesia();
        private ClassReports reports = new ClassReports();
        private Surgeries surgeries = new Surgeries();
        private ClassGetStrings stringsClass = new ClassGetStrings();
        private ClassOperatingRoom Operatigrooms = new ClassOperatingRoom();
        int id;
        public PostOperation(int IdSurgerie, string proc, string hour)
        {
            InitializeComponent();
            textBoxProcI.Text = proc;
            textBoxProcI.ReadOnly = true;
            id = IdSurgerie;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void listAnesthesiaTypes()
        {
            DataTable anesthesiaList = anesthesia.getAnesthesia();
            foreach (DataRow item in anesthesiaList.Rows)
            {
                checkedListBoxAnesthesiaTypes.Items.Add(item.Field<string>(1).ToString());
            }

            DataTable infoAnesthesia = surgeries.getSurgeriesById(id);
            string TypesAsigned = "";
            foreach (DataRow item in infoAnesthesia.Rows)
            {
                TypesAsigned = Convert.ToString(item.Field<string>(1));
            }

            char delimitador = '/';
            string[] tipos = TypesAsigned.Split(delimitador);

            List<string> listTypes = new List<string>();
            for (int i = 0; i < tipos.Length; i++)
            {
                listBox1.Items.Add(tipos[i]);
            }


            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SelectedIndex = i;
                for (int j = 0; j < checkedListBoxAnesthesiaTypes.Items.Count; j++)
                {
                    checkedListBoxAnesthesiaTypes.SelectedIndex = j;
                    if (listBox1.SelectedItem.ToString() == checkedListBoxAnesthesiaTypes.SelectedItem.ToString())
                    {
                        checkedListBoxAnesthesiaTypes.SetItemChecked(listBox1.SelectedIndex, true);
                    }
                }

            }
        }


        private void iconButtonContinue_Click(object sender, EventArgs e)
        {

            string allTypes = "";
            for (int i = 0; i < checkedListBoxAnesthesiaTypes.CheckedItems.Count; i++)
            {
                if (i == (checkedListBoxAnesthesiaTypes.CheckedItems.Count - 1))
                {
                    allTypes = allTypes + checkedListBoxAnesthesiaTypes.CheckedItems[i].ToString();
                }
                else
                {
                    allTypes = allTypes + checkedListBoxAnesthesiaTypes.CheckedItems[i].ToString() + "/";
                }
            }

            string resp = surgeries.updateSurgerieData(id, allTypes, textBoxProcI.Text + "  " + textBoxProcF.Text);
            if (resp.ToUpper().Contains("ERROR"))
                MessageBox.Show(resp, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                MessageBox.Show(resp, "Registro actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void PostOperation_Load(object sender, EventArgs e)
        {
            listAnesthesiaTypes();
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
