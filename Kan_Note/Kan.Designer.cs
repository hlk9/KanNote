
namespace Kan_Note
{
    partial class Kan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kanListNote = new MaterialSkin.Controls.MaterialListBox();
            this.kanMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.kanMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.45299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.54701F));
            this.tableLayoutPanel1.Controls.Add(this.kanListNote, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 469);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kanListNote
            // 
            this.kanListNote.BackColor = System.Drawing.Color.White;
            this.kanListNote.BorderColor = System.Drawing.Color.LightGray;
            this.kanListNote.ContextMenuStrip = this.kanMenu;
            this.kanListNote.Depth = 0;
            this.kanListNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kanListNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kanListNote.Location = new System.Drawing.Point(3, 3);
            this.kanListNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.kanListNote.Name = "kanListNote";
            this.kanListNote.SelectedIndex = -1;
            this.kanListNote.SelectedItem = null;
            this.kanListNote.Size = new System.Drawing.Size(147, 463);
            this.kanListNote.TabIndex = 0;
            this.kanListNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kanListNote_MouseDown);
            // 
            // kanMenu
            // 
            this.kanMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem});
            this.kanMenu.Name = "kanMenu";
            this.kanMenu.Size = new System.Drawing.Size(128, 48);
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newNoteToolStripMenuItem.Text = "New Note";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // Kan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Kan";
            this.Text = "Kan Note";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.kanMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialListBox kanListNote;
        private System.Windows.Forms.ContextMenuStrip kanMenu;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
    }
}

