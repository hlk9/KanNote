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
using System.IO;
using System.Data.OleDb;

namespace Kan_Note
{
    public partial class Kan : MaterialForm
    {
        public Kan()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            tabcontrolKan.SelectedIndexChanged += TabcontrolKan_SelectedIndexChanged;
        }

        private void TabcontrolKan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                foreach(var item in kanListNote.Items)
                {
                    if(item.Text== tabcontrolKan.SelectedTab.Text)
                    {
                        TabHT = tabcontrolKan.SelectedTab;
                        kanListNote.SelectedItem = item;
                        break;
                    }
                }
            }
            catch
            {
                TabHT = null;
            }
           
        }

        private int Num;
        private void Form1_Load(object sender, EventArgs e)
        {

            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\KanNote"))
            {

            }
            else
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\KanNote");
            }
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Num += 1;
                MaterialListBoxItem ite = new MaterialListBoxItem();                   
                ite.SecondaryText = System.DateTime.Now.ToString();
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
                tab.Closed += Tab_Closed;
                

              
            }
            catch
            {

            }
        }
        private TabPageAdv TabHT;
        private void Tab_Closed(object sender, EventArgs e)
        {
            bool contain = false;
            //Collection was modified; enumeration operation may not execute.'--- ToList()
            foreach (var item in kanListNote.Items.ToList())
            {
               foreach(TabPageAdv item2 in tabcontrolKan.TabPages)
                {
                    if (item.Text == item2.Text)
                    {
                        contain = true;
                        break;
                    }
                    else contain = false;
                }
                if (contain == false) kanListNote.Items.Remove(item);
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
                    TabHT = item;
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

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameDialog a = new RenameDialog();
            if(a.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    kanListNote.SelectedItem.Text = a.Name;
                    tabcontrolKan.SelectedTab.Text = a.Name;
                }
                catch
                { }
               
            }
        }
    }
}
