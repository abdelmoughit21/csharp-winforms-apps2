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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textID.Text) || string.IsNullOrEmpty(textName.Text))
                return;


            ListViewItem item = new ListViewItem(textID.Text.Trim());

            if (rbMale.Checked)
            {
                item.ImageIndex = 0;
            }
            else
            {
                item.ImageIndex = 1;
            }

            item.SubItems.Add(textName.Text.Trim());

            listView1.Items.Add(item);

            textID.Clear();
            textName.Clear();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if(listView1.Items.Count > 0)
            {

                listView1.Items.Remove(listView1.SelectedItems[0]);

            }

        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {

            for(int i = 1; i <= 10; i++)
            {

                ListViewItem item = new ListViewItem(i.ToString());

                if (i % 2 == 0)
                    item.ImageIndex = 1;
                else
                    item.ImageIndex = 0;

                item.SubItems.Add("Person " + i);

                listView1.Items.Add(item);

            }

        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {

            listView1.View = View.Details;

        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
    }
}
