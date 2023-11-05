
namespace WorkoutGenerator
{
    partial class SelectArea
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
            this.chkLegs = new System.Windows.Forms.CheckBox();
            this.chkAbs = new System.Windows.Forms.CheckBox();
            this.chkFullBody = new System.Windows.Forms.CheckBox();
            this.chkArms = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkLegs
            // 
            this.chkLegs.AutoSize = true;
            this.chkLegs.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLegs.Location = new System.Drawing.Point(170, 139);
            this.chkLegs.Name = "chkLegs";
            this.chkLegs.Size = new System.Drawing.Size(58, 24);
            this.chkLegs.TabIndex = 8;
            this.chkLegs.Text = "Legs";
            this.chkLegs.UseVisualStyleBackColor = true;
            this.chkLegs.CheckedChanged += new System.EventHandler(this.chkLegs_CheckedChanged);
            // 
            // chkAbs
            // 
            this.chkAbs.AutoSize = true;
            this.chkAbs.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAbs.Location = new System.Drawing.Point(170, 162);
            this.chkAbs.Name = "chkAbs";
            this.chkAbs.Size = new System.Drawing.Size(53, 24);
            this.chkAbs.TabIndex = 7;
            this.chkAbs.Text = "Abs";
            this.chkAbs.UseVisualStyleBackColor = true;
            this.chkAbs.CheckedChanged += new System.EventHandler(this.chkAbs_CheckedChanged);
            // 
            // chkFullBody
            // 
            this.chkFullBody.AutoSize = true;
            this.chkFullBody.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFullBody.Location = new System.Drawing.Point(170, 185);
            this.chkFullBody.Name = "chkFullBody";
            this.chkFullBody.Size = new System.Drawing.Size(89, 24);
            this.chkFullBody.TabIndex = 6;
            this.chkFullBody.Text = "Full Body";
            this.chkFullBody.UseVisualStyleBackColor = true;
            this.chkFullBody.CheckedChanged += new System.EventHandler(this.chkFullBody_CheckedChanged);
            // 
            // chkArms
            // 
            this.chkArms.AutoSize = true;
            this.chkArms.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArms.Location = new System.Drawing.Point(170, 116);
            this.chkArms.Name = "chkArms";
            this.chkArms.Size = new System.Drawing.Size(62, 24);
            this.chkArms.TabIndex = 5;
            this.chkArms.Text = "Arms";
            this.chkArms.UseVisualStyleBackColor = true;
            this.chkArms.CheckedChanged += new System.EventHandler(this.chkArms_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 58);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please select which area of muscle you want to workout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(204, 252);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(155, 36);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate Workout";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(43, 252);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 36);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(351, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 32);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SelectArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 300);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkLegs);
            this.Controls.Add(this.chkAbs);
            this.Controls.Add(this.chkFullBody);
            this.Controls.Add(this.chkArms);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectArea";
            this.Text = "SelectArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLegs;
        private System.Windows.Forms.CheckBox chkAbs;
        private System.Windows.Forms.CheckBox chkFullBody;
        private System.Windows.Forms.CheckBox chkArms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}