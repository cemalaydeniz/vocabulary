
namespace Vocabulary.Forms
{
    partial class AddWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWord));
            this.Lbl_Singular = new System.Windows.Forms.Label();
            this.Tbx_Singular = new System.Windows.Forms.TextBox();
            this.Gbx_Front = new System.Windows.Forms.GroupBox();
            this.RB_Plural = new System.Windows.Forms.RadioButton();
            this.RB_None = new System.Windows.Forms.RadioButton();
            this.Lbl_Gender = new System.Windows.Forms.Label();
            this.RB_Neutral = new System.Windows.Forms.RadioButton();
            this.Tbx_Plural = new System.Windows.Forms.TextBox();
            this.Lbl_Plural = new System.Windows.Forms.Label();
            this.RB_Feminine = new System.Windows.Forms.RadioButton();
            this.RB_Masculine = new System.Windows.Forms.RadioButton();
            this.Gbx_Back = new System.Windows.Forms.GroupBox();
            this.Tbx_Example = new System.Windows.Forms.TextBox();
            this.Tbx_Translation = new System.Windows.Forms.TextBox();
            this.Lbl_Example = new System.Windows.Forms.Label();
            this.Lbl_Translation = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Lbl_Save = new System.Windows.Forms.Label();
            this.Lbl_Clear = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Gbx_Front.SuspendLayout();
            this.Gbx_Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Singular
            // 
            this.Lbl_Singular.AutoSize = true;
            this.Lbl_Singular.Location = new System.Drawing.Point(15, 28);
            this.Lbl_Singular.Name = "Lbl_Singular";
            this.Lbl_Singular.Size = new System.Drawing.Size(76, 15);
            this.Lbl_Singular.TabIndex = 1;
            this.Lbl_Singular.Text = "Singularform";
            // 
            // Tbx_Singular
            // 
            this.Tbx_Singular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Singular.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Singular.Location = new System.Drawing.Point(97, 25);
            this.Tbx_Singular.Name = "Tbx_Singular";
            this.Tbx_Singular.Size = new System.Drawing.Size(499, 23);
            this.Tbx_Singular.TabIndex = 2;
            // 
            // Gbx_Front
            // 
            this.Gbx_Front.Controls.Add(this.RB_Plural);
            this.Gbx_Front.Controls.Add(this.RB_None);
            this.Gbx_Front.Controls.Add(this.Lbl_Gender);
            this.Gbx_Front.Controls.Add(this.RB_Neutral);
            this.Gbx_Front.Controls.Add(this.Tbx_Plural);
            this.Gbx_Front.Controls.Add(this.Lbl_Plural);
            this.Gbx_Front.Controls.Add(this.RB_Feminine);
            this.Gbx_Front.Controls.Add(this.Lbl_Singular);
            this.Gbx_Front.Controls.Add(this.RB_Masculine);
            this.Gbx_Front.Controls.Add(this.Tbx_Singular);
            this.Gbx_Front.ForeColor = System.Drawing.Color.Gainsboro;
            this.Gbx_Front.Location = new System.Drawing.Point(12, 12);
            this.Gbx_Front.Name = "Gbx_Front";
            this.Gbx_Front.Size = new System.Drawing.Size(603, 118);
            this.Gbx_Front.TabIndex = 0;
            this.Gbx_Front.TabStop = false;
            this.Gbx_Front.Text = "Vorderseite";
            // 
            // RB_Plural
            // 
            this.RB_Plural.AutoSize = true;
            this.RB_Plural.ForeColor = System.Drawing.Color.Goldenrod;
            this.RB_Plural.Location = new System.Drawing.Point(514, 89);
            this.RB_Plural.Name = "RB_Plural";
            this.RB_Plural.Size = new System.Drawing.Size(82, 19);
            this.RB_Plural.TabIndex = 10;
            this.RB_Plural.TabStop = true;
            this.RB_Plural.Text = "Plural (die)";
            this.RB_Plural.UseVisualStyleBackColor = true;
            // 
            // RB_None
            // 
            this.RB_None.AutoSize = true;
            this.RB_None.ForeColor = System.Drawing.Color.Gainsboro;
            this.RB_None.Location = new System.Drawing.Point(97, 89);
            this.RB_None.Name = "RB_None";
            this.RB_None.Size = new System.Drawing.Size(59, 19);
            this.RB_None.TabIndex = 6;
            this.RB_None.TabStop = true;
            this.RB_None.Text = "Nichts";
            this.RB_None.UseVisualStyleBackColor = true;
            // 
            // Lbl_Gender
            // 
            this.Lbl_Gender.AutoSize = true;
            this.Lbl_Gender.Location = new System.Drawing.Point(15, 91);
            this.Lbl_Gender.Name = "Lbl_Gender";
            this.Lbl_Gender.Size = new System.Drawing.Size(65, 15);
            this.Lbl_Gender.TabIndex = 5;
            this.Lbl_Gender.Text = "Geschlecht";
            // 
            // RB_Neutral
            // 
            this.RB_Neutral.AutoSize = true;
            this.RB_Neutral.ForeColor = System.Drawing.Color.Green;
            this.RB_Neutral.Location = new System.Drawing.Point(406, 89);
            this.RB_Neutral.Name = "RB_Neutral";
            this.RB_Neutral.Size = new System.Drawing.Size(102, 19);
            this.RB_Neutral.TabIndex = 9;
            this.RB_Neutral.TabStop = true;
            this.RB_Neutral.Text = "Neutrum (das)";
            this.RB_Neutral.UseVisualStyleBackColor = true;
            // 
            // Tbx_Plural
            // 
            this.Tbx_Plural.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Plural.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Plural.Location = new System.Drawing.Point(97, 54);
            this.Tbx_Plural.Name = "Tbx_Plural";
            this.Tbx_Plural.Size = new System.Drawing.Size(499, 23);
            this.Tbx_Plural.TabIndex = 4;
            // 
            // Lbl_Plural
            // 
            this.Lbl_Plural.AutoSize = true;
            this.Lbl_Plural.Location = new System.Drawing.Point(15, 57);
            this.Lbl_Plural.Name = "Lbl_Plural";
            this.Lbl_Plural.Size = new System.Drawing.Size(63, 15);
            this.Lbl_Plural.TabIndex = 3;
            this.Lbl_Plural.Text = "Pluralform";
            // 
            // RB_Feminine
            // 
            this.RB_Feminine.AutoSize = true;
            this.RB_Feminine.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RB_Feminine.Location = new System.Drawing.Point(287, 89);
            this.RB_Feminine.Name = "RB_Feminine";
            this.RB_Feminine.Size = new System.Drawing.Size(113, 19);
            this.RB_Feminine.TabIndex = 8;
            this.RB_Feminine.TabStop = true;
            this.RB_Feminine.Text = "Femininum (die)";
            this.RB_Feminine.UseVisualStyleBackColor = true;
            // 
            // RB_Masculine
            // 
            this.RB_Masculine.AutoSize = true;
            this.RB_Masculine.ForeColor = System.Drawing.Color.Red;
            this.RB_Masculine.Location = new System.Drawing.Point(162, 89);
            this.RB_Masculine.Name = "RB_Masculine";
            this.RB_Masculine.Size = new System.Drawing.Size(119, 19);
            this.RB_Masculine.TabIndex = 7;
            this.RB_Masculine.TabStop = true;
            this.RB_Masculine.Text = "Maskulinum (der)";
            this.RB_Masculine.UseVisualStyleBackColor = true;
            // 
            // Gbx_Back
            // 
            this.Gbx_Back.Controls.Add(this.Tbx_Example);
            this.Gbx_Back.Controls.Add(this.Tbx_Translation);
            this.Gbx_Back.Controls.Add(this.Lbl_Example);
            this.Gbx_Back.Controls.Add(this.Lbl_Translation);
            this.Gbx_Back.ForeColor = System.Drawing.Color.Gainsboro;
            this.Gbx_Back.Location = new System.Drawing.Point(12, 145);
            this.Gbx_Back.Name = "Gbx_Back";
            this.Gbx_Back.Size = new System.Drawing.Size(603, 140);
            this.Gbx_Back.TabIndex = 11;
            this.Gbx_Back.TabStop = false;
            this.Gbx_Back.Text = "Hinterseite";
            // 
            // Tbx_Example
            // 
            this.Tbx_Example.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Example.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Example.Location = new System.Drawing.Point(97, 60);
            this.Tbx_Example.Multiline = true;
            this.Tbx_Example.Name = "Tbx_Example";
            this.Tbx_Example.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Example.Size = new System.Drawing.Size(499, 70);
            this.Tbx_Example.TabIndex = 15;
            // 
            // Tbx_Translation
            // 
            this.Tbx_Translation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Translation.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Translation.Location = new System.Drawing.Point(97, 31);
            this.Tbx_Translation.Name = "Tbx_Translation";
            this.Tbx_Translation.Size = new System.Drawing.Size(499, 23);
            this.Tbx_Translation.TabIndex = 13;
            // 
            // Lbl_Example
            // 
            this.Lbl_Example.AutoSize = true;
            this.Lbl_Example.Location = new System.Drawing.Point(15, 63);
            this.Lbl_Example.Name = "Lbl_Example";
            this.Lbl_Example.Size = new System.Drawing.Size(47, 15);
            this.Lbl_Example.TabIndex = 14;
            this.Lbl_Example.Text = "Beispiel";
            // 
            // Lbl_Translation
            // 
            this.Lbl_Translation.AutoSize = true;
            this.Lbl_Translation.Location = new System.Drawing.Point(15, 34);
            this.Lbl_Translation.Name = "Lbl_Translation";
            this.Lbl_Translation.Size = new System.Drawing.Size(73, 15);
            this.Lbl_Translation.TabIndex = 12;
            this.Lbl_Translation.Text = "Übersetzung";
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.Black;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(502, 297);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(82, 25);
            this.Btn_Save.TabIndex = 21;
            this.Btn_Save.Text = "Speichern";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Lbl_Save
            // 
            this.Lbl_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Save.Location = new System.Drawing.Point(590, 298);
            this.Lbl_Save.Name = "Lbl_Save";
            this.Lbl_Save.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Save.TabIndex = 22;
            this.Lbl_Save.Text = "";
            // 
            // Lbl_Clear
            // 
            this.Lbl_Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Clear.Location = new System.Drawing.Point(100, 298);
            this.Lbl_Clear.Name = "Lbl_Clear";
            this.Lbl_Clear.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Clear.TabIndex = 20;
            this.Lbl_Clear.Text = "";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.Black;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(12, 297);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(82, 25);
            this.Btn_Clear.TabIndex = 19;
            this.Btn_Clear.Text = "Leeren";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(627, 335);
            this.Controls.Add(this.Lbl_Clear);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Lbl_Save);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Gbx_Back);
            this.Controls.Add(this.Gbx_Front);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wort Hinzufügen";
            this.Gbx_Front.ResumeLayout(false);
            this.Gbx_Front.PerformLayout();
            this.Gbx_Back.ResumeLayout(false);
            this.Gbx_Back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Singular;
        private System.Windows.Forms.TextBox Tbx_Singular;
        private System.Windows.Forms.GroupBox Gbx_Front;
        private System.Windows.Forms.GroupBox Gbx_Back;
        private System.Windows.Forms.Label Lbl_Gender;
        private System.Windows.Forms.RadioButton RB_Neutral;
        private System.Windows.Forms.TextBox Tbx_Plural;
        private System.Windows.Forms.Label Lbl_Plural;
        private System.Windows.Forms.RadioButton RB_Feminine;
        private System.Windows.Forms.RadioButton RB_Masculine;
        private System.Windows.Forms.TextBox Tbx_Example;
        private System.Windows.Forms.TextBox Tbx_Translation;
        private System.Windows.Forms.Label Lbl_Example;
        private System.Windows.Forms.Label Lbl_Translation;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Lbl_Save;
        private System.Windows.Forms.RadioButton RB_None;
        private System.Windows.Forms.Label Lbl_Clear;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.RadioButton RB_Plural;
    }
}