namespace DochazkovySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listboxAll = new System.Windows.Forms.ListBox();
            this.listboxPerson = new System.Windows.Forms.ListBox();
            this.listboxRecord = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShiftStart = new System.Windows.Forms.Button();
            this.btnShiftEnd = new System.Windows.Forms.Button();
            this.btnPauseStart = new System.Windows.Forms.Button();
            this.btnPauseEnd = new System.Windows.Forms.Button();
            this.btnDoctorStart = new System.Windows.Forms.Button();
            this.btnDoctorEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxAll
            // 
            this.listboxAll.FormattingEnabled = true;
            this.listboxAll.ItemHeight = 15;
            this.listboxAll.Location = new System.Drawing.Point(12, 44);
            this.listboxAll.Name = "listboxAll";
            this.listboxAll.Size = new System.Drawing.Size(161, 364);
            this.listboxAll.TabIndex = 0;
            // 
            // listboxPerson
            // 
            this.listboxPerson.FormattingEnabled = true;
            this.listboxPerson.ItemHeight = 15;
            this.listboxPerson.Location = new System.Drawing.Point(179, 44);
            this.listboxPerson.Name = "listboxPerson";
            this.listboxPerson.Size = new System.Drawing.Size(161, 364);
            this.listboxPerson.TabIndex = 0;
            this.listboxPerson.SelectedIndexChanged += new System.EventHandler(this.listboxPerson_SelectedIndexChanged);
            // 
            // listboxRecord
            // 
            this.listboxRecord.FormattingEnabled = true;
            this.listboxRecord.ItemHeight = 15;
            this.listboxRecord.Location = new System.Drawing.Point(346, 44);
            this.listboxRecord.Name = "listboxRecord";
            this.listboxRecord.Size = new System.Drawing.Size(161, 364);
            this.listboxRecord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Všechno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Osoby";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Záznamy";
            // 
            // btnShiftStart
            // 
            this.btnShiftStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShiftStart.Location = new System.Drawing.Point(513, 44);
            this.btnShiftStart.Name = "btnShiftStart";
            this.btnShiftStart.Size = new System.Drawing.Size(171, 54);
            this.btnShiftStart.TabIndex = 2;
            this.btnShiftStart.Text = "Zahájení směny ";
            this.btnShiftStart.UseVisualStyleBackColor = false;
            this.btnShiftStart.Click += new System.EventHandler(this.btnShiftStart_Click);
            // 
            // btnShiftEnd
            // 
            this.btnShiftEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShiftEnd.Location = new System.Drawing.Point(513, 104);
            this.btnShiftEnd.Name = "btnShiftEnd";
            this.btnShiftEnd.Size = new System.Drawing.Size(171, 54);
            this.btnShiftEnd.TabIndex = 2;
            this.btnShiftEnd.Text = "Ukončení směny";
            this.btnShiftEnd.UseVisualStyleBackColor = false;
            this.btnShiftEnd.Click += new System.EventHandler(this.btnShiftEnd_Click);
            // 
            // btnPauseStart
            // 
            this.btnPauseStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPauseStart.Location = new System.Drawing.Point(513, 164);
            this.btnPauseStart.Name = "btnPauseStart";
            this.btnPauseStart.Size = new System.Drawing.Size(171, 54);
            this.btnPauseStart.TabIndex = 2;
            this.btnPauseStart.Text = "Začátek pauzy";
            this.btnPauseStart.UseVisualStyleBackColor = false;
            this.btnPauseStart.Click += new System.EventHandler(this.btnPauseStart_Click);
            // 
            // btnPauseEnd
            // 
            this.btnPauseEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPauseEnd.Location = new System.Drawing.Point(513, 224);
            this.btnPauseEnd.Name = "btnPauseEnd";
            this.btnPauseEnd.Size = new System.Drawing.Size(171, 54);
            this.btnPauseEnd.TabIndex = 2;
            this.btnPauseEnd.Text = "Konec pauzy";
            this.btnPauseEnd.UseVisualStyleBackColor = false;
            this.btnPauseEnd.Click += new System.EventHandler(this.btnPauseEnd_Click);
            // 
            // btnDoctorStart
            // 
            this.btnDoctorStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDoctorStart.Location = new System.Drawing.Point(513, 284);
            this.btnDoctorStart.Name = "btnDoctorStart";
            this.btnDoctorStart.Size = new System.Drawing.Size(171, 54);
            this.btnDoctorStart.TabIndex = 2;
            this.btnDoctorStart.Text = "Odchod k lékaři";
            this.btnDoctorStart.UseVisualStyleBackColor = false;
            this.btnDoctorStart.Click += new System.EventHandler(this.btnDoctorStart_Click);
            // 
            // btnDoctorEnd
            // 
            this.btnDoctorEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDoctorEnd.Location = new System.Drawing.Point(513, 344);
            this.btnDoctorEnd.Name = "btnDoctorEnd";
            this.btnDoctorEnd.Size = new System.Drawing.Size(171, 54);
            this.btnDoctorEnd.TabIndex = 2;
            this.btnDoctorEnd.Text = "Návrat od lékaře";
            this.btnDoctorEnd.UseVisualStyleBackColor = false;
            this.btnDoctorEnd.Click += new System.EventHandler(this.btnDoctorEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 417);
            this.Controls.Add(this.btnDoctorEnd);
            this.Controls.Add(this.btnDoctorStart);
            this.Controls.Add(this.btnPauseEnd);
            this.Controls.Add(this.btnPauseStart);
            this.Controls.Add(this.btnShiftEnd);
            this.Controls.Add(this.btnShiftStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxRecord);
            this.Controls.Add(this.listboxPerson);
            this.Controls.Add(this.listboxAll);
            this.Name = "Form1";
            this.Text = "Docházkový systém";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxAll;
        private System.Windows.Forms.ListBox listboxPerson;
        private System.Windows.Forms.ListBox listboxRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShiftStart;
        private System.Windows.Forms.Button btnShiftEnd;
        private System.Windows.Forms.Button btnPauseStart;
        private System.Windows.Forms.Button btnPauseEnd;
        private System.Windows.Forms.Button btnDoctorStart;
        private System.Windows.Forms.Button btnDoctorEnd;
    }
}

