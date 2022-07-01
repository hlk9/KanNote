
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
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabcontrolKan = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tableLayoutPanel1.SuspendLayout();
            this.kanMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrolKan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.45299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.54701F));
            this.tableLayoutPanel1.Controls.Add(this.kanListNote, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabcontrolKan, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1597, 645);
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
            this.kanListNote.Size = new System.Drawing.Size(256, 639);
            this.kanListNote.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.kanListNote.TabIndex = 0;
            this.kanListNote.SelectedValueChanged += new MaterialSkin.Controls.MaterialListBox.SelectedValueEventHandler(this.kanListNote_SelectedValueChanged);
            this.kanListNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kanListNote_MouseDown);
            // 
            // kanMenu
            // 
            this.kanMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.kanMenu.Name = "kanMenu";
            this.kanMenu.Size = new System.Drawing.Size(184, 114);
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newNoteToolStripMenuItem.Text = "New Note";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleteToolStripMenuItem.Text = "Delete Selected Note";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tabcontrolKan
            // 
            this.tabcontrolKan.ActiveTabFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrolKan.BeforeTouchSize = new System.Drawing.Size(1329, 639);
            this.tabcontrolKan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolKan.FocusOnTabClick = false;
            this.tabcontrolKan.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabcontrolKan.ItemSize = new System.Drawing.Size(37, 32);
            this.tabcontrolKan.Location = new System.Drawing.Point(265, 3);
            this.tabcontrolKan.Multiline = true;
            this.tabcontrolKan.Name = "tabcontrolKan";
            this.tabcontrolKan.ShowCloseButtonForActiveTabOnly = true;
            this.tabcontrolKan.ShowDefaultContextMenu = true;
            this.tabcontrolKan.ShowTabCloseButton = true;
            this.tabcontrolKan.Size = new System.Drawing.Size(1329, 639);
            this.tabcontrolKan.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.FillToRight;
            this.tabcontrolKan.TabIndex = 1;
            this.tabcontrolKan.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabcontrolKan.ThemeName = "TabRendererOffice2016Colorful";
            this.tabcontrolKan.ThemesEnabled = true;
            this.tabcontrolKan.UserMoveTabs = true;
            // 
            // Kan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Kan";
            this.Text = "Kan Note";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.kanMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrolKan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialListBox kanListNote;
        private System.Windows.Forms.ContextMenuStrip kanMenu;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabcontrolKan;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

