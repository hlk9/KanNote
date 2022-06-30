using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Syncfusion.Windows.Forms.Tools;

namespace Kan_Note
{
    public partial class Kan : MaterialForm
    {
        public Kan()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialListBoxItem ite = new MaterialListBoxItem();
                ite.Text = "New Note";
                kanListNote.Items.Add(ite);
               
               
            }
            catch
            {

            }
        }

        private void kanListNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right&&kanListNote.SelectedItem!=null)
            {
                kanMenu.Show();
            }
        }
    }
}
