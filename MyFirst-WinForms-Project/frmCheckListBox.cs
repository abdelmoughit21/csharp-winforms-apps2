using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmCheckListBox : Form
    {
        public frmCheckListBox()
        {
            InitializeComponent();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {

                checkedListBox1.Items.Add("Item " + (i + 1));

            }
        }

        private void btnShowSelectedItems_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {

                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());

            }

        }

        private void btnCheckAllItems_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {

                checkedListBox1.SetItemChecked(i , true);

            }

        }

        private void btnUncheckAllItems_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {

                checkedListBox1.SetItemChecked(i, false);

            }

        }

        private void btnRemoveThirdItem_Click(object sender, EventArgs e)
        {

            checkedListBox1.Items.RemoveAt(2);

        }
    }
}
