
namespace WorkoutGenerator
{
    partial class SelectTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdbtn20 = new System.Windows.Forms.RadioButton();
            this.rdbtn30 = new System.Windows.Forms.RadioButton();
            this.rdbtn45 = new System.Windows.Forms.RadioButton();
            this.rdbtn60 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the amount of time you\'d like to workout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(139, 249);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 36);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(333, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 33);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdbtn20
            // 
            this.rdbtn20.AutoSize = true;
            this.rdbtn20.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn20.Location = new System.Drawing.Point(147, 101);
            this.rdbtn20.Name = "rdbtn20";
            this.rdbtn20.Size = new System.Drawing.Size(106, 25);
            this.rdbtn20.TabIndex = 15;
            this.rdbtn20.TabStop = true;
            this.rdbtn20.Text = "20 minutes";
            this.rdbtn20.UseVisualStyleBackColor = true;
            // 
            // rdbtn30
            // 
            this.rdbtn30.AutoSize = true;
            this.rdbtn30.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn30.Location = new System.Drawing.Point(147, 132);
            this.rdbtn30.Name = "rdbtn30";
            this.rdbtn30.Size = new System.Drawing.Size(106, 25);
            this.rdbtn30.TabIndex = 16;
            this.rdbtn30.TabStop = true;
            this.rdbtn30.Text = "30 minutes";
            this.rdbtn30.UseVisualStyleBackColor = true;
            // 
            // rdbtn45
            // 
            this.rdbtn45.AutoSize = true;
            this.rdbtn45.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn45.Location = new System.Drawing.Point(147, 163);
            this.rdbtn45.Name = "rdbtn45";
            this.rdbtn45.Size = new System.Drawing.Size(106, 25);
            this.rdbtn45.TabIndex = 17;
            this.rdbtn45.TabStop = true;
            this.rdbtn45.Text = "45 minutes";
            this.rdbtn45.UseVisualStyleBackColor = true;
            // 
            // rdbtn60
            // 
            this.rdbtn60.AutoSize = true;
            this.rdbtn60.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn60.Location = new System.Drawing.Point(147, 194);
            this.rdbtn60.Name = "rdbtn60";
            this.rdbtn60.Size = new System.Drawing.Size(106, 25);
            this.rdbtn60.TabIndex = 18;
            this.rdbtn60.TabStop = true;
            this.rdbtn60.Text = "60 minutes";
            this.rdbtn60.UseVisualStyleBackColor = true;
            // 
            // SelectTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 297);
            this.Controls.Add(this.rdbtn60);
            this.Controls.Add(this.rdbtn45);
            this.Controls.Add(this.rdbtn30);
            this.Controls.Add(this.rdbtn20);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectTime";
            this.Text = "Select Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdbtn20;
        private System.Windows.Forms.RadioButton rdbtn30;
        private System.Windows.Forms.RadioButton rdbtn45;
        private System.Windows.Forms.RadioButton rdbtn60;
    }
}