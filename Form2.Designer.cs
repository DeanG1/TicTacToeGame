
namespace Vesela_Apostolova_2101681070__Deyan_Guzelev_2101681075
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbRPS = new System.Windows.Forms.RadioButton();
            this.rbTTT = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 30);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(498, 77);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(183, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose a game";
            // 
            // rbRPS
            // 
            this.rbRPS.AutoSize = true;
            this.rbRPS.ForeColor = System.Drawing.Color.DarkViolet;
            this.rbRPS.Location = new System.Drawing.Point(14, 266);
            this.rbRPS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbRPS.Name = "rbRPS";
            this.rbRPS.Size = new System.Drawing.Size(257, 27);
            this.rbRPS.TabIndex = 4;
            this.rbRPS.TabStop = true;
            this.rbRPS.Text = "Rock Paper Scissors";
            this.rbRPS.UseVisualStyleBackColor = true;
            this.rbRPS.CheckedChanged += new System.EventHandler(this.rbRPS_CheckedChanged);
            // 
            // rbTTT
            // 
            this.rbTTT.AutoSize = true;
            this.rbTTT.ForeColor = System.Drawing.Color.Blue;
            this.rbTTT.Location = new System.Drawing.Point(390, 266);
            this.rbTTT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbTTT.Name = "rbTTT";
            this.rbTTT.Size = new System.Drawing.Size(155, 27);
            this.rbTTT.TabIndex = 5;
            this.rbTTT.TabStop = true;
            this.rbTTT.Text = "Tic Tac Toe";
            this.rbTTT.UseVisualStyleBackColor = true;
            this.rbTTT.CheckedChanged += new System.EventHandler(this.rbTTT_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vesela_Apostolova_2101681070__Deyan_Guzelev_2101681075.Properties.Resources.tic_tac_toe_411214;
            this.pictureBox2.Location = new System.Drawing.Point(361, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 213);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vesela_Apostolova_2101681070__Deyan_Guzelev_2101681075.Properties.Resources.rock_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(688, 542);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbTTT);
            this.Controls.Add(this.rbRPS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Rock Paper Scissors & Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbRPS;
        private System.Windows.Forms.RadioButton rbTTT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}