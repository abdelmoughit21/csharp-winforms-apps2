using ComboBoxExercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb.SelectedIndex = 1;
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cb.SelectedItem.ToString().ToLower())
            {

                case "boy":

                    lblTitle.Text = cb.Text;
                    pb.Image = Resources.Boy;
                    break;

                case "girl":

                    lblTitle.Text = cb.Text;
                    pb.Image = Resources.Girl;
                    break;

                case "book":

                    lblTitle.Text = cb.Text;
                    pb.Image = Resources.Book;
                    break;

                case "pen":

                    lblTitle.Text = cb.Text;
                    pb.Image = Resources.Pen;
                    break;

            }

        }
    }
}
