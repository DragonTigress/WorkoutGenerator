
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbxMuscles = new System.Windows.Forms.GroupBox();
            this.rdbtnLegs = new System.Windows.Forms.RadioButton();
            this.rdbtnAbs = new System.Windows.Forms.RadioButton();
            this.rdbtnFull = new System.Windows.Forms.RadioButton();
            this.rdbtnArms = new System.Windows.Forms.RadioButton();
            this.gpbxTime = new System.Windows.Forms.GroupBox();
            this.rdbtn60 = new System.Windows.Forms.RadioButton();
            this.rdbtn45 = new System.Windows.Forms.RadioButton();
            this.rdbtn30 = new System.Windows.Forms.RadioButton();
            this.rdbtn20 = new System.Windows.Forms.RadioButton();
            this.gpbxMuscles.SuspendLayout();
            this.gpbxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 37);
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
            // gpbxMuscles
            // 
            this.gpbxMuscles.Controls.Add(this.rdbtnLegs);
            this.gpbxMuscles.Controls.Add(this.rdbtnAbs);
            this.gpbxMuscles.Controls.Add(this.rdbtnFull);
            this.gpbxMuscles.Controls.Add(this.rdbtnArms);
            this.gpbxMuscles.Location = new System.Drawing.Point(234, 89);
            this.gpbxMuscles.Name = "gpbxMuscles";
            this.gpbxMuscles.Size = new System.Drawing.Size(125, 146);
            this.gpbxMuscles.TabIndex = 27;
            this.gpbxMuscles.TabStop = false;
            // 
            // rdbtnLegs
            // 
            this.rdbtnLegs.AutoSize = true;
            this.rdbtnLegs.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnLegs.Location = new System.Drawing.Point(26, 44);
            this.rdbtnLegs.Name = "rdbtnLegs";
            this.rdbtnLegs.Size = new System.Drawing.Size(60, 25);
            this.rdbtnLegs.TabIndex = 30;
            this.rdbtnLegs.TabStop = true;
            this.rdbtnLegs.Text = "Legs";
            this.rdbtnLegs.UseVisualStyleBackColor = true;
            // 
            // rdbtnAbs
            // 
            this.rdbtnAbs.AutoSize = true;
            this.rdbtnAbs.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnAbs.Location = new System.Drawing.Point(26, 77);
            this.rdbtnAbs.Name = "rdbtnAbs";
            this.rdbtnAbs.Size = new System.Drawing.Size(54, 25);
            this.rdbtnAbs.TabIndex = 29;
            this.rdbtnAbs.TabStop = true;
            this.rdbtnAbs.Text = "Abs";
            this.rdbtnAbs.UseVisualStyleBackColor = true;
            // 
            // rdbtnFull
            // 
            this.rdbtnFull.AutoSize = true;
            this.rdbtnFull.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFull.Location = new System.Drawing.Point(26, 106);
            this.rdbtnFull.Name = "rdbtnFull";
            this.rdbtnFull.Size = new System.Drawing.Size(92, 25);
            this.rdbtnFull.TabIndex = 28;
            this.rdbtnFull.TabStop = true;
            this.rdbtnFull.Text = "Full Body";
            this.rdbtnFull.UseVisualStyleBackColor = true;
            // 
            // rdbtnArms
            // 
            this.rdbtnArms.AutoSize = true;
            this.rdbtnArms.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnArms.Location = new System.Drawing.Point(26, 14);
            this.rdbtnArms.Name = "rdbtnArms";
            this.rdbtnArms.Size = new System.Drawing.Size(65, 25);
            this.rdbtnArms.TabIndex = 27;
            this.rdbtnArms.TabStop = true;
            this.rdbtnArms.Text = "Arms";
            this.rdbtnArms.UseVisualStyleBackColor = true;
            // 
            // gpbxTime
            // 
            this.gpbxTime.Controls.Add(this.rdbtn60);
            this.gpbxTime.Controls.Add(this.rdbtn45);
            this.gpbxTime.Controls.Add(this.rdbtn30);
            this.gpbxTime.Controls.Add(this.rdbtn20);
            this.gpbxTime.Location = new System.Drawing.Point(49, 89);
            this.gpbxTime.Name = "gpbxTime";
            this.gpbxTime.Size = new System.Drawing.Size(129, 146);
            this.gpbxTime.TabIndex = 28;
            this.gpbxTime.TabStop = false;
            // 
            // rdbtn60
            // 
            this.rdbtn60.AutoSize = true;
            this.rdbtn60.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn60.Location = new System.Drawing.Point(6, 105);
            this.rdbtn60.Name = "rdbtn60";
            this.rdbtn60.Size = new System.Drawing.Size(106, 25);
            this.rdbtn60.TabIndex = 26;
            this.rdbtn60.TabStop = true;
            this.rdbtn60.Text = "60 minutes";
            this.rdbtn60.UseVisualStyleBackColor = true;
            // 
            // rdbtn45
            // 
            this.rdbtn45.AutoSize = true;
            this.rdbtn45.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn45.Location = new System.Drawing.Point(6, 74);
            this.rdbtn45.Name = "rdbtn45";
            this.rdbtn45.Size = new System.Drawing.Size(106, 25);
            this.rdbtn45.TabIndex = 25;
            this.rdbtn45.TabStop = true;
            this.rdbtn45.Text = "45 minutes";
            this.rdbtn45.UseVisualStyleBackColor = true;
            // 
            // rdbtn30
            // 
            this.rdbtn30.AutoSize = true;
            this.rdbtn30.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn30.Location = new System.Drawing.Point(6, 43);
            this.rdbtn30.Name = "rdbtn30";
            this.rdbtn30.Size = new System.Drawing.Size(106, 25);
            this.rdbtn30.TabIndex = 24;
            this.rdbtn30.TabStop = true;
            this.rdbtn30.Text = "30 minutes";
            this.rdbtn30.UseVisualStyleBackColor = true;
            // 
            // rdbtn20
            // 
            this.rdbtn20.AutoSize = true;
            this.rdbtn20.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn20.Location = new System.Drawing.Point(6, 12);
            this.rdbtn20.Name = "rdbtn20";
            this.rdbtn20.Size = new System.Drawing.Size(106, 25);
            this.rdbtn20.TabIndex = 23;
            this.rdbtn20.TabStop = true;
            this.rdbtn20.Text = "20 minutes";
            this.rdbtn20.UseVisualStyleBackColor = true;
            // 
            // SelectArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 315);
            this.Controls.Add(this.gpbxTime);
            this.Controls.Add(this.gpbxMuscles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectArea";
            this.Text = "SelectArea";
            this.gpbxMuscles.ResumeLayout(false);
            this.gpbxMuscles.PerformLayout();
            this.gpbxTime.ResumeLayout(false);
            this.gpbxTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gpbxMuscles;
        private System.Windows.Forms.RadioButton rdbtnLegs;
        private System.Windows.Forms.RadioButton rdbtnAbs;
        private System.Windows.Forms.RadioButton rdbtnFull;
        private System.Windows.Forms.RadioButton rdbtnArms;
        private System.Windows.Forms.GroupBox gpbxTime;
        private System.Windows.Forms.RadioButton rdbtn60;
        private System.Windows.Forms.RadioButton rdbtn45;
        private System.Windows.Forms.RadioButton rdbtn30;
        private System.Windows.Forms.RadioButton rdbtn20;
    }
}