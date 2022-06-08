
namespace Vocabulary.Forms
{
    partial class Flashcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flashcard));
            this.Lbl_Singular = new System.Windows.Forms.Label();
            this.Btn_Listen_Word = new System.Windows.Forms.Button();
            this.Lbl_Hear_Word = new System.Windows.Forms.Label();
            this.Btn_Show = new System.Windows.Forms.Button();
            this.Gbx_Back = new System.Windows.Forms.GroupBox();
            this.NUD_Speed = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Speed = new System.Windows.Forms.Label();
            this.Lbl_Stop = new System.Windows.Forms.Label();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Lbl_Hear_Example = new System.Windows.Forms.Label();
            this.Lbl_Example = new System.Windows.Forms.Label();
            this.Btn_Listen_Example = new System.Windows.Forms.Button();
            this.Tbx_Example = new System.Windows.Forms.TextBox();
            this.Lbl_Translation = new System.Windows.Forms.Label();
            this.Tbx_Translation = new System.Windows.Forms.TextBox();
            this.Lbl_Correct = new System.Windows.Forms.Label();
            this.Btn_Correct = new System.Windows.Forms.Button();
            this.Lbl_Wrong = new System.Windows.Forms.Label();
            this.Btn_Wrong = new System.Windows.Forms.Button();
            this.Lbl_Plural = new System.Windows.Forms.Label();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Gbx_Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Singular
            // 
            this.Lbl_Singular.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Singular.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Singular.Name = "Lbl_Singular";
            this.Lbl_Singular.Size = new System.Drawing.Size(471, 47);
            this.Lbl_Singular.TabIndex = 0;
            this.Lbl_Singular.Text = "Singularform";
            this.Lbl_Singular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Listen_Word
            // 
            this.Btn_Listen_Word.BackColor = System.Drawing.Color.Black;
            this.Btn_Listen_Word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Listen_Word.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Listen_Word.Location = new System.Drawing.Point(12, 112);
            this.Btn_Listen_Word.Name = "Btn_Listen_Word";
            this.Btn_Listen_Word.Size = new System.Drawing.Size(75, 25);
            this.Btn_Listen_Word.TabIndex = 1;
            this.Btn_Listen_Word.Text = "Anhören";
            this.Btn_Listen_Word.UseVisualStyleBackColor = false;
            this.Btn_Listen_Word.Click += new System.EventHandler(this.Btn_Listen_Word_Click);
            // 
            // Lbl_Hear_Word
            // 
            this.Lbl_Hear_Word.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Hear_Word.Location = new System.Drawing.Point(93, 113);
            this.Lbl_Hear_Word.Name = "Lbl_Hear_Word";
            this.Lbl_Hear_Word.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Hear_Word.TabIndex = 2;
            this.Lbl_Hear_Word.Text = "";
            // 
            // Btn_Show
            // 
            this.Btn_Show.BackColor = System.Drawing.Color.Black;
            this.Btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Show.Location = new System.Drawing.Point(12, 324);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(75, 25);
            this.Btn_Show.TabIndex = 3;
            this.Btn_Show.Text = "Zeigen";
            this.Btn_Show.UseVisualStyleBackColor = false;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // Gbx_Back
            // 
            this.Gbx_Back.Controls.Add(this.NUD_Speed);
            this.Gbx_Back.Controls.Add(this.Lbl_Speed);
            this.Gbx_Back.Controls.Add(this.Lbl_Stop);
            this.Gbx_Back.Controls.Add(this.Btn_Stop);
            this.Gbx_Back.Controls.Add(this.Lbl_Hear_Example);
            this.Gbx_Back.Controls.Add(this.Lbl_Example);
            this.Gbx_Back.Controls.Add(this.Btn_Listen_Example);
            this.Gbx_Back.Controls.Add(this.Tbx_Example);
            this.Gbx_Back.Controls.Add(this.Lbl_Translation);
            this.Gbx_Back.Controls.Add(this.Tbx_Translation);
            this.Gbx_Back.ForeColor = System.Drawing.Color.Gainsboro;
            this.Gbx_Back.Location = new System.Drawing.Point(12, 150);
            this.Gbx_Back.Name = "Gbx_Back";
            this.Gbx_Back.Size = new System.Drawing.Size(471, 163);
            this.Gbx_Back.TabIndex = 5;
            this.Gbx_Back.TabStop = false;
            this.Gbx_Back.Text = "Hinterseite";
            // 
            // NUD_Speed
            // 
            this.NUD_Speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.NUD_Speed.ForeColor = System.Drawing.Color.Gainsboro;
            this.NUD_Speed.Location = new System.Drawing.Point(406, 132);
            this.NUD_Speed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Speed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.NUD_Speed.Name = "NUD_Speed";
            this.NUD_Speed.ReadOnly = true;
            this.NUD_Speed.Size = new System.Drawing.Size(57, 23);
            this.NUD_Speed.TabIndex = 29;
            // 
            // Lbl_Speed
            // 
            this.Lbl_Speed.AutoSize = true;
            this.Lbl_Speed.Location = new System.Drawing.Point(357, 135);
            this.Lbl_Speed.Name = "Lbl_Speed";
            this.Lbl_Speed.Size = new System.Drawing.Size(43, 15);
            this.Lbl_Speed.TabIndex = 28;
            this.Lbl_Speed.Text = "Tempo";
            // 
            // Lbl_Stop
            // 
            this.Lbl_Stop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Stop.Location = new System.Drawing.Point(290, 131);
            this.Lbl_Stop.Name = "Lbl_Stop";
            this.Lbl_Stop.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Stop.TabIndex = 27;
            this.Lbl_Stop.Text = "";
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.BackColor = System.Drawing.Color.Black;
            this.Btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Stop.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Stop.Location = new System.Drawing.Point(209, 130);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(75, 25);
            this.Btn_Stop.TabIndex = 26;
            this.Btn_Stop.Text = "Stopp";
            this.Btn_Stop.UseVisualStyleBackColor = false;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Lbl_Hear_Example
            // 
            this.Lbl_Hear_Example.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Hear_Example.Location = new System.Drawing.Point(178, 131);
            this.Lbl_Hear_Example.Name = "Lbl_Hear_Example";
            this.Lbl_Hear_Example.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Hear_Example.TabIndex = 20;
            this.Lbl_Hear_Example.Text = "";
            // 
            // Lbl_Example
            // 
            this.Lbl_Example.AutoSize = true;
            this.Lbl_Example.Location = new System.Drawing.Point(15, 57);
            this.Lbl_Example.Name = "Lbl_Example";
            this.Lbl_Example.Size = new System.Drawing.Size(47, 15);
            this.Lbl_Example.TabIndex = 17;
            this.Lbl_Example.Text = "Beispiel";
            // 
            // Btn_Listen_Example
            // 
            this.Btn_Listen_Example.BackColor = System.Drawing.Color.Black;
            this.Btn_Listen_Example.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Listen_Example.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Listen_Example.Location = new System.Drawing.Point(97, 130);
            this.Btn_Listen_Example.Name = "Btn_Listen_Example";
            this.Btn_Listen_Example.Size = new System.Drawing.Size(75, 25);
            this.Btn_Listen_Example.TabIndex = 19;
            this.Btn_Listen_Example.Text = "Anhören";
            this.Btn_Listen_Example.UseVisualStyleBackColor = false;
            this.Btn_Listen_Example.Click += new System.EventHandler(this.Btn_Listen_Example_Click);
            // 
            // Tbx_Example
            // 
            this.Tbx_Example.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Example.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Example.Location = new System.Drawing.Point(97, 54);
            this.Tbx_Example.Multiline = true;
            this.Tbx_Example.Name = "Tbx_Example";
            this.Tbx_Example.ReadOnly = true;
            this.Tbx_Example.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Example.Size = new System.Drawing.Size(366, 70);
            this.Tbx_Example.TabIndex = 18;
            // 
            // Lbl_Translation
            // 
            this.Lbl_Translation.AutoSize = true;
            this.Lbl_Translation.Location = new System.Drawing.Point(15, 28);
            this.Lbl_Translation.Name = "Lbl_Translation";
            this.Lbl_Translation.Size = new System.Drawing.Size(73, 15);
            this.Lbl_Translation.TabIndex = 6;
            this.Lbl_Translation.Text = "Übersetzung";
            // 
            // Tbx_Translation
            // 
            this.Tbx_Translation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Tbx_Translation.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tbx_Translation.Location = new System.Drawing.Point(97, 25);
            this.Tbx_Translation.Name = "Tbx_Translation";
            this.Tbx_Translation.ReadOnly = true;
            this.Tbx_Translation.Size = new System.Drawing.Size(366, 23);
            this.Tbx_Translation.TabIndex = 7;
            // 
            // Lbl_Correct
            // 
            this.Lbl_Correct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Correct.Location = new System.Drawing.Point(346, 324);
            this.Lbl_Correct.Name = "Lbl_Correct";
            this.Lbl_Correct.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Correct.TabIndex = 22;
            this.Lbl_Correct.Text = "";
            // 
            // Btn_Correct
            // 
            this.Btn_Correct.BackColor = System.Drawing.Color.Black;
            this.Btn_Correct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Correct.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Correct.Location = new System.Drawing.Point(265, 324);
            this.Btn_Correct.Name = "Btn_Correct";
            this.Btn_Correct.Size = new System.Drawing.Size(75, 25);
            this.Btn_Correct.TabIndex = 21;
            this.Btn_Correct.Text = "Richtig";
            this.Btn_Correct.UseVisualStyleBackColor = false;
            this.Btn_Correct.Click += new System.EventHandler(this.Btn_Correct_Click);
            // 
            // Lbl_Wrong
            // 
            this.Lbl_Wrong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Wrong.Location = new System.Drawing.Point(458, 324);
            this.Lbl_Wrong.Name = "Lbl_Wrong";
            this.Lbl_Wrong.Size = new System.Drawing.Size(25, 23);
            this.Lbl_Wrong.TabIndex = 24;
            this.Lbl_Wrong.Text = "";
            // 
            // Btn_Wrong
            // 
            this.Btn_Wrong.BackColor = System.Drawing.Color.Black;
            this.Btn_Wrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Wrong.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Wrong.Location = new System.Drawing.Point(377, 324);
            this.Btn_Wrong.Name = "Btn_Wrong";
            this.Btn_Wrong.Size = new System.Drawing.Size(75, 25);
            this.Btn_Wrong.TabIndex = 23;
            this.Btn_Wrong.Text = "Falsch";
            this.Btn_Wrong.UseVisualStyleBackColor = false;
            this.Btn_Wrong.Click += new System.EventHandler(this.Btn_Wrong_Click);
            // 
            // Lbl_Plural
            // 
            this.Lbl_Plural.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Plural.ForeColor = System.Drawing.Color.Goldenrod;
            this.Lbl_Plural.Location = new System.Drawing.Point(12, 61);
            this.Lbl_Plural.Name = "Lbl_Plural";
            this.Lbl_Plural.Size = new System.Drawing.Size(471, 47);
            this.Lbl_Plural.TabIndex = 25;
            this.Lbl_Plural.Text = "Pluralform";
            this.Lbl_Plural.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.Black;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Edit.Location = new System.Drawing.Point(408, 112);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(75, 25);
            this.Btn_Edit.TabIndex = 26;
            this.Btn_Edit.Text = "Bearbeiten";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Flashcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(495, 359);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Lbl_Plural);
            this.Controls.Add(this.Lbl_Wrong);
            this.Controls.Add(this.Gbx_Back);
            this.Controls.Add(this.Btn_Wrong);
            this.Controls.Add(this.Btn_Show);
            this.Controls.Add(this.Lbl_Correct);
            this.Controls.Add(this.Lbl_Hear_Word);
            this.Controls.Add(this.Btn_Listen_Word);
            this.Controls.Add(this.Btn_Correct);
            this.Controls.Add(this.Lbl_Singular);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Flashcard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karteikarten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Flashcard_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Flashcard_KeyDown);
            this.Gbx_Back.ResumeLayout(false);
            this.Gbx_Back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Speed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Singular;
        private System.Windows.Forms.Button Btn_Listen_Word;
        private System.Windows.Forms.Label Lbl_Hear_Word;
        private System.Windows.Forms.Button Btn_Show;
        private System.Windows.Forms.GroupBox Gbx_Back;
        private System.Windows.Forms.Label Lbl_Hear_Example;
        private System.Windows.Forms.Label Lbl_Example;
        private System.Windows.Forms.Button Btn_Listen_Example;
        private System.Windows.Forms.TextBox Tbx_Example;
        private System.Windows.Forms.Label Lbl_Correct;
        private System.Windows.Forms.Button Btn_Correct;
        private System.Windows.Forms.Label Lbl_Wrong;
        private System.Windows.Forms.Button Btn_Wrong;
        private System.Windows.Forms.Label Lbl_Plural;
        private System.Windows.Forms.Label Lbl_Translation;
        private System.Windows.Forms.TextBox Tbx_Translation;
        private System.Windows.Forms.Label Lbl_Stop;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Label Lbl_Speed;
        private System.Windows.Forms.NumericUpDown NUD_Speed;
        private System.Windows.Forms.Button Btn_Edit;
    }
}