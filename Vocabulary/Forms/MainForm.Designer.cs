
namespace Vocabulary.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Btn_Study = new System.Windows.Forms.Button();
            this.Btn_AddWord = new System.Windows.Forms.Button();
            this.Btn_RemoveWord = new System.Windows.Forms.Button();
            this.Btn_UpdateWord = new System.Windows.Forms.Button();
            this.Lbl_Study = new System.Windows.Forms.Label();
            this.Lbl_Add = new System.Windows.Forms.Label();
            this.Lbl_Update = new System.Windows.Forms.Label();
            this.Lbl_Remove = new System.Windows.Forms.Label();
            this.Lbl_NewWords = new System.Windows.Forms.Label();
            this.NUD_NewWords = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Review = new System.Windows.Forms.Label();
            this.Btn_Review = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Options = new System.Windows.Forms.Button();
            this.Cbx_Dates = new System.Windows.Forms.ComboBox();
            this.Btn_Add_Date = new System.Windows.Forms.Button();
            this.Lbx_Dates = new System.Windows.Forms.ListBox();
            this.RightClick_Lbx_Dates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NewWords)).BeginInit();
            this.RightClick_Lbx_Dates.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Study
            // 
            this.Btn_Study.BackColor = System.Drawing.Color.Black;
            this.Btn_Study.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Study.Location = new System.Drawing.Point(12, 41);
            this.Btn_Study.Name = "Btn_Study";
            this.Btn_Study.Size = new System.Drawing.Size(187, 25);
            this.Btn_Study.TabIndex = 2;
            this.Btn_Study.Text = "Lernen";
            this.Btn_Study.UseVisualStyleBackColor = false;
            this.Btn_Study.Click += new System.EventHandler(this.Btn_Study_Click);
            // 
            // Btn_AddWord
            // 
            this.Btn_AddWord.BackColor = System.Drawing.Color.Black;
            this.Btn_AddWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddWord.Location = new System.Drawing.Point(12, 266);
            this.Btn_AddWord.Name = "Btn_AddWord";
            this.Btn_AddWord.Size = new System.Drawing.Size(187, 25);
            this.Btn_AddWord.TabIndex = 5;
            this.Btn_AddWord.Text = "Wort Hinzufügen";
            this.Btn_AddWord.UseVisualStyleBackColor = false;
            this.Btn_AddWord.Click += new System.EventHandler(this.Btn_AddWord_Click);
            // 
            // Btn_RemoveWord
            // 
            this.Btn_RemoveWord.BackColor = System.Drawing.Color.Black;
            this.Btn_RemoveWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RemoveWord.Location = new System.Drawing.Point(12, 328);
            this.Btn_RemoveWord.Name = "Btn_RemoveWord";
            this.Btn_RemoveWord.Size = new System.Drawing.Size(187, 25);
            this.Btn_RemoveWord.TabIndex = 9;
            this.Btn_RemoveWord.Text = "Wort Entfernen";
            this.Btn_RemoveWord.UseVisualStyleBackColor = false;
            this.Btn_RemoveWord.Click += new System.EventHandler(this.Btn_RemoveWord_Click);
            // 
            // Btn_UpdateWord
            // 
            this.Btn_UpdateWord.BackColor = System.Drawing.Color.Black;
            this.Btn_UpdateWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateWord.Location = new System.Drawing.Point(12, 297);
            this.Btn_UpdateWord.Name = "Btn_UpdateWord";
            this.Btn_UpdateWord.Size = new System.Drawing.Size(187, 25);
            this.Btn_UpdateWord.TabIndex = 7;
            this.Btn_UpdateWord.Text = "Wort Bearbeiten";
            this.Btn_UpdateWord.UseVisualStyleBackColor = false;
            this.Btn_UpdateWord.Click += new System.EventHandler(this.Btn_UpdateWord_Click);
            // 
            // Lbl_Study
            // 
            this.Lbl_Study.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Study.Location = new System.Drawing.Point(205, 42);
            this.Lbl_Study.Name = "Lbl_Study";
            this.Lbl_Study.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Study.TabIndex = 3;
            this.Lbl_Study.Text = "";
            // 
            // Lbl_Add
            // 
            this.Lbl_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Add.Location = new System.Drawing.Point(205, 267);
            this.Lbl_Add.Name = "Lbl_Add";
            this.Lbl_Add.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Add.TabIndex = 6;
            this.Lbl_Add.Text = "";
            // 
            // Lbl_Update
            // 
            this.Lbl_Update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Update.Location = new System.Drawing.Point(205, 298);
            this.Lbl_Update.Name = "Lbl_Update";
            this.Lbl_Update.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Update.TabIndex = 8;
            this.Lbl_Update.Text = "";
            // 
            // Lbl_Remove
            // 
            this.Lbl_Remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Remove.Location = new System.Drawing.Point(205, 329);
            this.Lbl_Remove.Name = "Lbl_Remove";
            this.Lbl_Remove.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Remove.TabIndex = 10;
            this.Lbl_Remove.Text = "";
            // 
            // Lbl_NewWords
            // 
            this.Lbl_NewWords.AutoSize = true;
            this.Lbl_NewWords.Location = new System.Drawing.Point(12, 14);
            this.Lbl_NewWords.Name = "Lbl_NewWords";
            this.Lbl_NewWords.Size = new System.Drawing.Size(74, 15);
            this.Lbl_NewWords.TabIndex = 13;
            this.Lbl_NewWords.Text = "Neue Wörter";
            // 
            // NUD_NewWords
            // 
            this.NUD_NewWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.NUD_NewWords.ForeColor = System.Drawing.Color.Gainsboro;
            this.NUD_NewWords.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_NewWords.Location = new System.Drawing.Point(92, 12);
            this.NUD_NewWords.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUD_NewWords.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_NewWords.Name = "NUD_NewWords";
            this.NUD_NewWords.ReadOnly = true;
            this.NUD_NewWords.Size = new System.Drawing.Size(107, 23);
            this.NUD_NewWords.TabIndex = 14;
            this.NUD_NewWords.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Lbl_Review
            // 
            this.Lbl_Review.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Review.Location = new System.Drawing.Point(205, 205);
            this.Lbl_Review.Name = "Lbl_Review";
            this.Lbl_Review.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Review.TabIndex = 16;
            this.Lbl_Review.Text = "";
            // 
            // Btn_Review
            // 
            this.Btn_Review.BackColor = System.Drawing.Color.Black;
            this.Btn_Review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Review.Location = new System.Drawing.Point(12, 204);
            this.Btn_Review.Name = "Btn_Review";
            this.Btn_Review.Size = new System.Drawing.Size(187, 25);
            this.Btn_Review.TabIndex = 15;
            this.Btn_Review.Text = "Überprüfung";
            this.Btn_Review.UseVisualStyleBackColor = false;
            this.Btn_Review.Click += new System.EventHandler(this.Btn_Review_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(205, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "";
            // 
            // Btn_Options
            // 
            this.Btn_Options.BackColor = System.Drawing.Color.Black;
            this.Btn_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Options.Location = new System.Drawing.Point(12, 385);
            this.Btn_Options.Name = "Btn_Options";
            this.Btn_Options.Size = new System.Drawing.Size(187, 25);
            this.Btn_Options.TabIndex = 17;
            this.Btn_Options.Text = "Optionen";
            this.Btn_Options.UseVisualStyleBackColor = false;
            this.Btn_Options.Click += new System.EventHandler(this.Btn_Options_Click);
            // 
            // Cbx_Dates
            // 
            this.Cbx_Dates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Cbx_Dates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Dates.ForeColor = System.Drawing.Color.Gainsboro;
            this.Cbx_Dates.FormattingEnabled = true;
            this.Cbx_Dates.Location = new System.Drawing.Point(12, 103);
            this.Cbx_Dates.Name = "Cbx_Dates";
            this.Cbx_Dates.Size = new System.Drawing.Size(121, 23);
            this.Cbx_Dates.TabIndex = 19;
            // 
            // Btn_Add_Date
            // 
            this.Btn_Add_Date.BackColor = System.Drawing.Color.Black;
            this.Btn_Add_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add_Date.Location = new System.Drawing.Point(139, 103);
            this.Btn_Add_Date.Name = "Btn_Add_Date";
            this.Btn_Add_Date.Size = new System.Drawing.Size(89, 25);
            this.Btn_Add_Date.TabIndex = 20;
            this.Btn_Add_Date.Text = "Hinzufügen";
            this.Btn_Add_Date.UseVisualStyleBackColor = false;
            this.Btn_Add_Date.Click += new System.EventHandler(this.Btn_Add_Date_Click);
            // 
            // Lbx_Dates
            // 
            this.Lbx_Dates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Lbx_Dates.ContextMenuStrip = this.RightClick_Lbx_Dates;
            this.Lbx_Dates.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbx_Dates.FormattingEnabled = true;
            this.Lbx_Dates.ItemHeight = 15;
            this.Lbx_Dates.Items.AddRange(new object[] {
            "Heute"});
            this.Lbx_Dates.Location = new System.Drawing.Point(12, 134);
            this.Lbx_Dates.Name = "Lbx_Dates";
            this.Lbx_Dates.Size = new System.Drawing.Size(216, 64);
            this.Lbx_Dates.TabIndex = 22;
            // 
            // RightClick_Lbx_Dates
            // 
            this.RightClick_Lbx_Dates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entfernenToolStripMenuItem});
            this.RightClick_Lbx_Dates.Name = "RightClick_Lbx_Dates";
            this.RightClick_Lbx_Dates.Size = new System.Drawing.Size(126, 26);
            this.RightClick_Lbx_Dates.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RightClick_Lbx_Dates_ItemClicked);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(240, 422);
            this.Controls.Add(this.Lbx_Dates);
            this.Controls.Add(this.Btn_Add_Date);
            this.Controls.Add(this.Cbx_Dates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Options);
            this.Controls.Add(this.Lbl_Review);
            this.Controls.Add(this.Btn_Review);
            this.Controls.Add(this.NUD_NewWords);
            this.Controls.Add(this.Lbl_NewWords);
            this.Controls.Add(this.Lbl_Remove);
            this.Controls.Add(this.Lbl_Update);
            this.Controls.Add(this.Lbl_Add);
            this.Controls.Add(this.Lbl_Study);
            this.Controls.Add(this.Btn_UpdateWord);
            this.Controls.Add(this.Btn_RemoveWord);
            this.Controls.Add(this.Btn_AddWord);
            this.Controls.Add(this.Btn_Study);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wortschatz";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NewWords)).EndInit();
            this.RightClick_Lbx_Dates.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Study;
        private System.Windows.Forms.Button Btn_AddWord;
        private System.Windows.Forms.Button Btn_RemoveWord;
        private System.Windows.Forms.Button Btn_UpdateWord;
        private System.Windows.Forms.Label Lbl_Study;
        private System.Windows.Forms.Label Lbl_Add;
        private System.Windows.Forms.Label Lbl_Update;
        private System.Windows.Forms.Label Lbl_Remove;
        private System.Windows.Forms.Label Lbl_NewWords;
        private System.Windows.Forms.NumericUpDown NUD_NewWords;
        private System.Windows.Forms.Label Lbl_Review;
        private System.Windows.Forms.Button Btn_Review;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Options;
        private System.Windows.Forms.ComboBox Cbx_Dates;
        private System.Windows.Forms.Button Btn_Add_Date;
        private System.Windows.Forms.ListBox Lbx_Dates;
        private System.Windows.Forms.ContextMenuStrip RightClick_Lbx_Dates;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
    }
}