
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
            this.tabcontrolKan = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.materialMultiLineTextBox21 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.tableLayoutPanel1.SuspendLayout();
            this.kanMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrolKan)).BeginInit();
            this.tabcontrolKan.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
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
            this.kanListNote.TabIndex = 0;
            this.kanListNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kanListNote_MouseDown);
            // 
            // kanMenu
            // 
            this.kanMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem});
            this.kanMenu.Name = "kanMenu";
            this.kanMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newNoteToolStripMenuItem.Text = "New Note";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // tabcontrolKan
            // 
            this.tabcontrolKan.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabcontrolKan.BeforeTouchSize = new System.Drawing.Size(1329, 639);
            this.tabcontrolKan.Controls.Add(this.tabPageAdv1);
            this.tabcontrolKan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolKan.FocusOnTabClick = false;
            this.tabcontrolKan.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabcontrolKan.ItemSize = new System.Drawing.Size(37, 32);
            this.tabcontrolKan.Location = new System.Drawing.Point(265, 3);
            this.tabcontrolKan.Name = "tabcontrolKan";
            this.tabcontrolKan.Size = new System.Drawing.Size(1329, 639);
            this.tabcontrolKan.TabIndex = 1;
            this.tabcontrolKan.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabcontrolKan.ThemeName = "TabRendererOffice2016Colorful";
            this.tabcontrolKan.ThemesEnabled = true;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv1.Controls.Add(this.materialMultiLineTextBox21);
            this.tabPageAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(3, 34);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(1322, 601);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Note";
            this.tabPageAdv1.ThemesEnabled = true;
            // 
            // materialMultiLineTextBox21
            // 
            this.materialMultiLineTextBox21.AnimateReadOnly = false;
            this.materialMultiLineTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMultiLineTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialMultiLineTextBox21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialMultiLineTextBox21.Depth = 0;
            this.materialMultiLineTextBox21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialMultiLineTextBox21.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.materialMultiLineTextBox21.HideSelection = true;
            this.materialMultiLineTextBox21.Location = new System.Drawing.Point(0, 0);
            this.materialMultiLineTextBox21.MaxLength = 32767;
            this.materialMultiLineTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMultiLineTextBox21.Name = "materialMultiLineTextBox21";
            this.materialMultiLineTextBox21.PasswordChar = '\0';
            this.materialMultiLineTextBox21.ReadOnly = false;
            this.materialMultiLineTextBox21.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materialMultiLineTextBox21.SelectedText = "";
            this.materialMultiLineTextBox21.SelectionLength = 0;
            this.materialMultiLineTextBox21.SelectionStart = 0;
            this.materialMultiLineTextBox21.ShortcutsEnabled = true;
            this.materialMultiLineTextBox21.Size = new System.Drawing.Size(1322, 601);
            this.materialMultiLineTextBox21.TabIndex = 0;
            this.materialMultiLineTextBox21.TabStop = false;
            this.materialMultiLineTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMultiLineTextBox21.UseSystemPasswordChar = false;
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
            this.tabcontrolKan.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialListBox kanListNote;
        private System.Windows.Forms.ContextMenuStrip kanMenu;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabcontrolKan;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox21;
    }
}

