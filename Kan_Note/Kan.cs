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
        private int Num;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Num += 1;
                MaterialListBoxItem ite = new MaterialListBoxItem();
                ite.Text = "New Tab[" + Num + "]";
                kanListNote.Items.Add(ite);
                TabPageAdv tab = new TabPageAdv();
                tab.Text = "New Tab["+Num+"]";
                MaterialMultiLineTextBox2 rangetext = new MaterialMultiLineTextBox2();
                //set font cho TextBox
                Font kanFont = new Font("CascadiaCode",14, FontStyle.Regular);
                rangetext.Hint = "Write note into me...";
                rangetext.Font = kanFont;
                tab.Controls.Add(rangetext);
                rangetext.Dock = DockStyle.Fill;
                tabcontrolKan.TabPages.Add(tab);
                
               
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

        private void kanListNote_SelectedValueChanged(object sender, MaterialListBoxItem selectedItem)
        {
           foreach(TabPageAdv item in tabcontrolKan.TabPages)
            {
             
                if (item.Text == selectedItem.Text)
                {
                    tabcontrolKan.SelectedTab = item;
                    break;
                }
                  
                
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (kanListNote.SelectedItem != null)
            {
                foreach (TabPageAdv item in tabcontrolKan.TabPages)
                {

                    if (item.Text == kanListNote.SelectedItem.Text)
                    {
                        tabcontrolKan.TabPages.Remove(tabcontrolKan.SelectedTab);
                        break;
                    }


                }
                kanListNote.Items.Remove(kanListNote.SelectedItem);
            }
        }
    }
}
