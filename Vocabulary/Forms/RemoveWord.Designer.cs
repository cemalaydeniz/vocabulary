﻿
namespace Vocabulary.Forms
{
    partial class RemoveWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveWord));
            this.Lbl_Remove = new System.Windows.Forms.Label();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Gbx_Search = new System.Windows.Forms.GroupBox();
            this.Lbl_Search = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Lbl_Search_Singular = new System.Windows.Forms.Label();
            this.Tbx_Search_Singular = new System.Windows.Forms.TextBox();
            this.Gbx_Result = new System.Windows.Forms.GroupBox();
            this.RB_Plural = new System.Windows.Forms.RadioButton();
            this.Lbl_SingularForm = new System.Windows.Forms.Label();
            this.Lbl_Example = new System.Windows.Forms.Label();
            this.Tbx_Singular = new System.Windows.Forms.TextBox();
            this.Tbx_Example = new System.Windows.Forms.TextBox();
            this.RB_None = new System.Windows.Forms.RadioButton();
            this.Tbx_Translation = new System.Windows.Forms.TextBox();
            this.Lbl_Gender = new System.Windows.Forms.Label();
            this.RB_Neutral = new System.Windows.Forms.RadioButton();
            this.Lbl_Translation = new System.Windows.Forms.Label();
            this.Tbx_Plural = new System.Windows.Forms.TextBox();
            this.Lbl_Plural = new System.Windows.Forms.Label();
            this.RB_Feminine = new System.Windows.Forms.RadioButton();
            this.RB_Masculine = new System.Windows.Forms.RadioButton();
            this.Lbx_Cards = new System.Windows.Forms.ListBox();
            this.Gbx_Search.SuspendLayout();
            this.Gbx_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Remove
            // 
            this.Lbl_Remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Remove.Location = new System.Drawing.Point(590, 361);
            this.Lbl_Remove.Name = "Lbl_Remove";
            this.Lbl_Remove.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Remove.TabIndex = 24;
            this.Lbl_Remove.Text = "";
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.BackColor = System.Drawing.Color.Black;
            this.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Remove.Location = new System.Drawing.Point(502, 360);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(82, 25);
            this.Btn_Remove.TabIndex = 23;
            this.Btn_Remove.Text = "Entfernen";
            this.Btn_Remove.UseVisualStyleBackColor = false;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Gbx_Search
            // 
            this.Gbx_Search.Controls.Add(this.Lbl_Search);
            this.Gbx_Search.Controls.Add(this.Btn_Search);
            this.Gbx_Search.Controls.Add(this.Lbl_Search_Singular);
            this.Gbx_Search.Controls.Add(this.Tbx_Search_Singular);
            this.Gbx_Search.ForeColor = System.Drawing.Color.Gainsboro;
            this.Gbx_Search.Location = new System.Drawing.Point(12, 12);
            this.Gbx_Search.Name = "Gbx_Search";
            this.Gbx_Search.Size = new System.Drawing.Size(603, 94);
            this.Gbx_Search.TabIndex = 0;
            this.Gbx_Search.TabStop = false;
            this.Gbx_Search.Text = "Wortsuche";
            // 
            // Lbl_Search
            // 
            this.Lbl_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Search.Location = new System.Drawing.Point(571, 60);
            this.Lbl_Search.Name = "Lbl_Search";
            this.Lbl_Search.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Search.TabIndex = 5;
            this.Lbl_Search.Text = "";
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.Black;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Location = new System.Drawing.Point(483, 59);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(82, 25);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "Suchen";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Lbl_Search_Singular
            // 
            this.Lbl_Search_Singular.AutoSize = true;
            this.Lbl_Search_Singular.Location = new System.Drawing.Point(15, 28);
            this.Lbl_Search_Singular.Name = "Lbl_Search_Singular";
            this.Lbl_Search_Singular.Size = new System.Drawing.Size(76, 15);
            this.Lbl_Search_Singular.TabIndex = 1;
            this.Lbl_Search_Singular.Text = "Singularform";
            // 
            // Tbx_Search_Singular
            // 
            this.Tbx_Search_Singular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Search_Singular.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Search_Singular.Location = new System.Drawing.Point(97, 25);
            this.Tbx_Search_Singular.Name = "Tbx_Search_Singular";
            this.Tbx_Search_Singular.Size = new System.Drawing.Size(499, 23);
            this.Tbx_Search_Singular.TabIndex = 2;
            // 
            // Gbx_Result
            // 
            this.Gbx_Result.Controls.Add(this.RB_Plural);
            this.Gbx_Result.Controls.Add(this.Lbl_SingularForm);
            this.Gbx_Result.Controls.Add(this.Lbl_Example);
            this.Gbx_Result.Controls.Add(this.Tbx_Singular);
            this.Gbx_Result.Controls.Add(this.Tbx_Example);
            this.Gbx_Result.Controls.Add(this.RB_None);
            this.Gbx_Result.Controls.Add(this.Tbx_Translation);
            this.Gbx_Result.Controls.Add(this.Lbl_Gender);
            this.Gbx_Result.Controls.Add(this.RB_Neutral);
            this.Gbx_Result.Controls.Add(this.Lbl_Translation);
            this.Gbx_Result.Controls.Add(this.Tbx_Plural);
            this.Gbx_Result.Controls.Add(this.Lbl_Plural);
            this.Gbx_Result.Controls.Add(this.RB_Feminine);
            this.Gbx_Result.Controls.Add(this.RB_Masculine);
            this.Gbx_Result.ForeColor = System.Drawing.Color.Gainsboro;
            this.Gbx_Result.Location = new System.Drawing.Point(12, 122);
            this.Gbx_Result.Name = "Gbx_Result";
            this.Gbx_Result.Size = new System.Drawing.Size(603, 227);
            this.Gbx_Result.TabIndex = 6;
            this.Gbx_Result.TabStop = false;
            this.Gbx_Result.Text = "Ergebnis";
            // 
            // RB_Plural
            // 
            this.RB_Plural.AutoSize = true;
            this.RB_Plural.ForeColor = System.Drawing.Color.Goldenrod;
            this.RB_Plural.Location = new System.Drawing.Point(514, 90);
            this.RB_Plural.Name = "RB_Plural";
            this.RB_Plural.Size = new System.Drawing.Size(82, 19);
            this.RB_Plural.TabIndex = 16;
            this.RB_Plural.TabStop = true;
            this.RB_Plural.Text = "Plural (die)";
            this.RB_Plural.UseVisualStyleBackColor = true;
            // 
            // Lbl_SingularForm
            // 
            this.Lbl_SingularForm.AutoSize = true;
            this.Lbl_SingularForm.Location = new System.Drawing.Point(15, 29);
            this.Lbl_SingularForm.Name = "Lbl_SingularForm";
            this.Lbl_SingularForm.Size = new System.Drawing.Size(76, 15);
            this.Lbl_SingularForm.TabIndex = 7;
            this.Lbl_SingularForm.Text = "Singularform";
            // 
            // Lbl_Example
            // 
            this.Lbl_Example.AutoSize = true;
            this.Lbl_Example.Location = new System.Drawing.Point(15, 147);
            this.Lbl_Example.Name = "Lbl_Example";
            this.Lbl_Example.Size = new System.Drawing.Size(47, 15);
            this.Lbl_Example.TabIndex = 19;
            this.Lbl_Example.Text = "Beispiel";
            // 
            // Tbx_Singular
            // 
            this.Tbx_Singular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Singular.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Singular.Location = new System.Drawing.Point(97, 26);
            this.Tbx_Singular.Name = "Tbx_Singular";
            this.Tbx_Singular.ReadOnly = true;
            this.Tbx_Singular.Size = new System.Drawing.Size(499, 23);
            this.Tbx_Singular.TabIndex = 8;
            // 
            // Tbx_Example
            // 
            this.Tbx_Example.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Example.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Example.Location = new System.Drawing.Point(97, 144);
            this.Tbx_Example.Multiline = true;
            this.Tbx_Example.Name = "Tbx_Example";
            this.Tbx_Example.ReadOnly = true;
            this.Tbx_Example.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Example.Size = new System.Drawing.Size(499, 70);
            this.Tbx_Example.TabIndex = 20;
            // 
            // RB_None
            // 
            this.RB_None.AutoSize = true;
            this.RB_None.ForeColor = System.Drawing.Color.Gainsboro;
            this.RB_None.Location = new System.Drawing.Point(97, 90);
            this.RB_None.Name = "RB_None";
            this.RB_None.Size = new System.Drawing.Size(59, 19);
            this.RB_None.TabIndex = 12;
            this.RB_None.TabStop = true;
            this.RB_None.Text = "Nichts";
            this.RB_None.UseVisualStyleBackColor = true;
            // 
            // Tbx_Translation
            // 
            this.Tbx_Translation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Translation.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Translation.Location = new System.Drawing.Point(97, 115);
            this.Tbx_Translation.Name = "Tbx_Translation";
            this.Tbx_Translation.ReadOnly = true;
            this.Tbx_Translation.Size = new System.Drawing.Size(499, 23);
            this.Tbx_Translation.TabIndex = 18;
            // 
            // Lbl_Gender
            // 
            this.Lbl_Gender.AutoSize = true;
            this.Lbl_Gender.Location = new System.Drawing.Point(15, 92);
            this.Lbl_Gender.Name = "Lbl_Gender";
            this.Lbl_Gender.Size = new System.Drawing.Size(65, 15);
            this.Lbl_Gender.TabIndex = 11;
            this.Lbl_Gender.Text = "Geschlecht";
            // 
            // RB_Neutral
            // 
            this.RB_Neutral.AutoSize = true;
            this.RB_Neutral.ForeColor = System.Drawing.Color.Green;
            this.RB_Neutral.Location = new System.Drawing.Point(406, 90);
            this.RB_Neutral.Name = "RB_Neutral";
            this.RB_Neutral.Size = new System.Drawing.Size(102, 19);
            this.RB_Neutral.TabIndex = 15;
            this.RB_Neutral.TabStop = true;
            this.RB_Neutral.Text = "Neutrum (das)";
            this.RB_Neutral.UseVisualStyleBackColor = true;
            // 
            // Lbl_Translation
            // 
            this.Lbl_Translation.AutoSize = true;
            this.Lbl_Translation.Location = new System.Drawing.Point(15, 118);
            this.Lbl_Translation.Name = "Lbl_Translation";
            this.Lbl_Translation.Size = new System.Drawing.Size(73, 15);
            this.Lbl_Translation.TabIndex = 17;
            this.Lbl_Translation.Text = "Übersetzung";
            // 
            // Tbx_Plural
            // 
            this.Tbx_Plural.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Plural.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Plural.Location = new System.Drawing.Point(97, 55);
            this.Tbx_Plural.Name = "Tbx_Plural";
            this.Tbx_Plural.ReadOnly = true;
            this.Tbx_Plural.Size = new System.Drawing.Size(499, 23);
            this.Tbx_Plural.TabIndex = 10;
            // 
            // Lbl_Plural
            // 
            this.Lbl_Plural.AutoSize = true;
            this.Lbl_Plural.Location = new System.Drawing.Point(15, 58);
            this.Lbl_Plural.Name = "Lbl_Plural";
            this.Lbl_Plural.Size = new System.Drawing.Size(63, 15);
            this.Lbl_Plural.TabIndex = 9;
            this.Lbl_Plural.Text = "Pluralform";
            // 
            // RB_Feminine
            // 
            this.RB_Feminine.AutoSize = true;
            this.RB_Feminine.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RB_Feminine.Location = new System.Drawing.Point(287, 90);
            this.RB_Feminine.Name = "RB_Feminine";
            this.RB_Feminine.Size = new System.Drawing.Size(113, 19);
            this.RB_Feminine.TabIndex = 14;
            this.RB_Feminine.TabStop = true;
            this.RB_Feminine.Text = "Femininum (die)";
            this.RB_Feminine.UseVisualStyleBackColor = true;
            // 
            // RB_Masculine
            // 
            this.RB_Masculine.AutoSize = true;
            this.RB_Masculine.ForeColor = System.Drawing.Color.Red;
            this.RB_Masculine.Location = new System.Drawing.Point(162, 90);
            this.RB_Masculine.Name = "RB_Masculine";
            this.RB_Masculine.Size = new System.Drawing.Size(119, 19);
            this.RB_Masculine.TabIndex = 13;
            this.RB_Masculine.TabStop = true;
            this.RB_Masculine.Text = "Maskulinum (der)";
            this.RB_Masculine.UseVisualStyleBackColor = true;
            // 
            // Lbx_Cards
            // 
            this.Lbx_Cards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Lbx_Cards.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbx_Cards.FormattingEnabled = true;
            this.Lbx_Cards.ItemHeight = 15;
            this.Lbx_Cards.Location = new System.Drawing.Point(630, 20);
            this.Lbx_Cards.Name = "Lbx_Cards";
            this.Lbx_Cards.Size = new System.Drawing.Size(218, 364);
            this.Lbx_Cards.TabIndex = 25;
            this.Lbx_Cards.SelectedIndexChanged += new System.EventHandler(this.Lbx_Cards_SelectedIndexChanged);
            // 
            // RemoveWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(864, 398);
            this.Controls.Add(this.Lbx_Cards);
            this.Controls.Add(this.Gbx_Search);
            this.Controls.Add(this.Gbx_Result);
            this.Controls.Add(this.Lbl_Remove);
            this.Controls.Add(this.Btn_Remove);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wort Entfernen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoveWord_KeyDown);
            this.Gbx_Search.ResumeLayout(false);
            this.Gbx_Search.PerformLayout();
            this.Gbx_Result.ResumeLayout(false);
            this.Gbx_Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Remove;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.GroupBox Gbx_Search;
        private System.Windows.Forms.Label Lbl_Search;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label Lbl_Search_Singular;
        private System.Windows.Forms.TextBox Tbx_Search_Singular;
        private System.Windows.Forms.GroupBox Gbx_Result;
        private System.Windows.Forms.RadioButton RB_Plural;
        private System.Windows.Forms.Label Lbl_Example;
        private System.Windows.Forms.TextBox Tbx_Example;
        private System.Windows.Forms.RadioButton RB_None;
        private System.Windows.Forms.TextBox Tbx_Translation;
        private System.Windows.Forms.Label Lbl_Gender;
        private System.Windows.Forms.RadioButton RB_Neutral;
        private System.Windows.Forms.Label Lbl_Translation;
        private System.Windows.Forms.TextBox Tbx_Plural;
        private System.Windows.Forms.Label Lbl_Plural;
        private System.Windows.Forms.RadioButton RB_Feminine;
        private System.Windows.Forms.RadioButton RB_Masculine;
        private System.Windows.Forms.Label Lbl_SingularForm;
        private System.Windows.Forms.TextBox Tbx_Singular;
        private System.Windows.Forms.ListBox Lbx_Cards;
    }
}