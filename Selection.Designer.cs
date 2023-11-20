
namespace WorkoutGenerator
{
    partial class Selection
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
            this.rdbtnChest = new System.Windows.Forms.RadioButton();
            this.rdbtnForearm = new System.Windows.Forms.RadioButton();
            this.rdbtnLats = new System.Windows.Forms.RadioButton();
            this.rdbtnLower = new System.Windows.Forms.RadioButton();
            this.rdbtnMiddle = new System.Windows.Forms.RadioButton();
            this.rdbtnQuads = new System.Windows.Forms.RadioButton();
            this.rdbtnTraps = new System.Windows.Forms.RadioButton();
            this.rdbtnTriceps = new System.Windows.Forms.RadioButton();
            this.rdbtnCalves = new System.Windows.Forms.RadioButton();
            this.rdbtnGlutes = new System.Windows.Forms.RadioButton();
            this.rdbtnAbs = new System.Windows.Forms.RadioButton();
            this.rdbtnFull = new System.Windows.Forms.RadioButton();
            this.rdbtnBicep = new System.Windows.Forms.RadioButton();
            this.gpbxTime = new System.Windows.Forms.GroupBox();
            this.rdbtn60 = new System.Windows.Forms.RadioButton();
            this.rdbtn45 = new System.Windows.Forms.RadioButton();
            this.rdbtn30 = new System.Windows.Forms.RadioButton();
            this.rdbtn20 = new System.Windows.Forms.RadioButton();
            this.rdbtnHamstring = new System.Windows.Forms.RadioButton();
            this.gpbxMuscles.SuspendLayout();
            this.gpbxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 28);
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
            this.btnGenerate.Location = new System.Drawing.Point(248, 325);
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
            this.btnBack.Location = new System.Drawing.Point(87, 325);
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
            this.btnExit.Location = new System.Drawing.Point(450, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 32);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gpbxMuscles
            // 
            this.gpbxMuscles.Controls.Add(this.rdbtnHamstring);
            this.gpbxMuscles.Controls.Add(this.rdbtnChest);
            this.gpbxMuscles.Controls.Add(this.rdbtnForearm);
            this.gpbxMuscles.Controls.Add(this.rdbtnLats);
            this.gpbxMuscles.Controls.Add(this.rdbtnLower);
            this.gpbxMuscles.Controls.Add(this.rdbtnMiddle);
            this.gpbxMuscles.Controls.Add(this.rdbtnQuads);
            this.gpbxMuscles.Controls.Add(this.rdbtnTraps);
            this.gpbxMuscles.Controls.Add(this.rdbtnTriceps);
            this.gpbxMuscles.Controls.Add(this.rdbtnCalves);
            this.gpbxMuscles.Controls.Add(this.rdbtnGlutes);
            this.gpbxMuscles.Controls.Add(this.rdbtnAbs);
            this.gpbxMuscles.Controls.Add(this.rdbtnFull);
            this.gpbxMuscles.Controls.Add(this.rdbtnBicep);
            this.gpbxMuscles.Location = new System.Drawing.Point(234, 89);
            this.gpbxMuscles.Name = "gpbxMuscles";
            this.gpbxMuscles.Size = new System.Drawing.Size(264, 230);
            this.gpbxMuscles.TabIndex = 27;
            this.gpbxMuscles.TabStop = false;
            // 
            // rdbtnChest
            // 
            this.rdbtnChest.AutoSize = true;
            this.rdbtnChest.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnChest.Location = new System.Drawing.Point(26, 105);
            this.rdbtnChest.Name = "rdbtnChest";
            this.rdbtnChest.Size = new System.Drawing.Size(67, 25);
            this.rdbtnChest.TabIndex = 39;
            this.rdbtnChest.TabStop = true;
            this.rdbtnChest.Text = "Chest";
            this.rdbtnChest.UseVisualStyleBackColor = true;
            // 
            // rdbtnForearm
            // 
            this.rdbtnForearm.AutoSize = true;
            this.rdbtnForearm.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnForearm.Location = new System.Drawing.Point(26, 136);
            this.rdbtnForearm.Name = "rdbtnForearm";
            this.rdbtnForearm.Size = new System.Drawing.Size(94, 25);
            this.rdbtnForearm.TabIndex = 38;
            this.rdbtnForearm.TabStop = true;
            this.rdbtnForearm.Text = "Forearms";
            this.rdbtnForearm.UseVisualStyleBackColor = true;
            // 
            // rdbtnLats
            // 
            this.rdbtnLats.AutoSize = true;
            this.rdbtnLats.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnLats.Location = new System.Drawing.Point(138, 12);
            this.rdbtnLats.Name = "rdbtnLats";
            this.rdbtnLats.Size = new System.Drawing.Size(56, 25);
            this.rdbtnLats.TabIndex = 37;
            this.rdbtnLats.TabStop = true;
            this.rdbtnLats.Text = "Lats";
            this.rdbtnLats.UseVisualStyleBackColor = true;
            // 
            // rdbtnLower
            // 
            this.rdbtnLower.AutoSize = true;
            this.rdbtnLower.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnLower.Location = new System.Drawing.Point(138, 43);
            this.rdbtnLower.Name = "rdbtnLower";
            this.rdbtnLower.Size = new System.Drawing.Size(107, 25);
            this.rdbtnLower.TabIndex = 36;
            this.rdbtnLower.TabStop = true;
            this.rdbtnLower.Text = "Lower Back";
            this.rdbtnLower.UseVisualStyleBackColor = true;
            // 
            // rdbtnMiddle
            // 
            this.rdbtnMiddle.AutoSize = true;
            this.rdbtnMiddle.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMiddle.Location = new System.Drawing.Point(138, 74);
            this.rdbtnMiddle.Name = "rdbtnMiddle";
            this.rdbtnMiddle.Size = new System.Drawing.Size(112, 25);
            this.rdbtnMiddle.TabIndex = 35;
            this.rdbtnMiddle.TabStop = true;
            this.rdbtnMiddle.Text = "Middle Back";
            this.rdbtnMiddle.UseVisualStyleBackColor = true;
            // 
            // rdbtnQuads
            // 
            this.rdbtnQuads.AutoSize = true;
            this.rdbtnQuads.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnQuads.Location = new System.Drawing.Point(138, 105);
            this.rdbtnQuads.Name = "rdbtnQuads";
            this.rdbtnQuads.Size = new System.Drawing.Size(73, 25);
            this.rdbtnQuads.TabIndex = 34;
            this.rdbtnQuads.TabStop = true;
            this.rdbtnQuads.Text = "Quads";
            this.rdbtnQuads.UseVisualStyleBackColor = true;
            // 
            // rdbtnTraps
            // 
            this.rdbtnTraps.AutoSize = true;
            this.rdbtnTraps.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTraps.Location = new System.Drawing.Point(138, 136);
            this.rdbtnTraps.Name = "rdbtnTraps";
            this.rdbtnTraps.Size = new System.Drawing.Size(66, 25);
            this.rdbtnTraps.TabIndex = 33;
            this.rdbtnTraps.TabStop = true;
            this.rdbtnTraps.Text = "Traps";
            this.rdbtnTraps.UseVisualStyleBackColor = true;
            // 
            // rdbtnTriceps
            // 
            this.rdbtnTriceps.AutoSize = true;
            this.rdbtnTriceps.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTriceps.Location = new System.Drawing.Point(138, 167);
            this.rdbtnTriceps.Name = "rdbtnTriceps";
            this.rdbtnTriceps.Size = new System.Drawing.Size(77, 25);
            this.rdbtnTriceps.TabIndex = 32;
            this.rdbtnTriceps.TabStop = true;
            this.rdbtnTriceps.Text = "Triceps";
            this.rdbtnTriceps.UseVisualStyleBackColor = true;
            // 
            // rdbtnCalves
            // 
            this.rdbtnCalves.AutoSize = true;
            this.rdbtnCalves.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnCalves.Location = new System.Drawing.Point(26, 74);
            this.rdbtnCalves.Name = "rdbtnCalves";
            this.rdbtnCalves.Size = new System.Drawing.Size(73, 25);
            this.rdbtnCalves.TabIndex = 31;
            this.rdbtnCalves.TabStop = true;
            this.rdbtnCalves.Text = "Calves";
            this.rdbtnCalves.UseVisualStyleBackColor = true;
            // 
            // rdbtnGlutes
            // 
            this.rdbtnGlutes.AutoSize = true;
            this.rdbtnGlutes.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnGlutes.Location = new System.Drawing.Point(26, 170);
            this.rdbtnGlutes.Name = "rdbtnGlutes";
            this.rdbtnGlutes.Size = new System.Drawing.Size(72, 25);
            this.rdbtnGlutes.TabIndex = 30;
            this.rdbtnGlutes.TabStop = true;
            this.rdbtnGlutes.Text = "Glutes";
            this.rdbtnGlutes.UseVisualStyleBackColor = true;
            // 
            // rdbtnAbs
            // 
            this.rdbtnAbs.AutoSize = true;
            this.rdbtnAbs.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnAbs.Location = new System.Drawing.Point(26, 12);
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
            this.rdbtnFull.Location = new System.Drawing.Point(138, 198);
            this.rdbtnFull.Name = "rdbtnFull";
            this.rdbtnFull.Size = new System.Drawing.Size(92, 25);
            this.rdbtnFull.TabIndex = 28;
            this.rdbtnFull.TabStop = true;
            this.rdbtnFull.Text = "Full Body";
            this.rdbtnFull.UseVisualStyleBackColor = true;
            // 
            // rdbtnBicep
            // 
            this.rdbtnBicep.AutoSize = true;
            this.rdbtnBicep.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnBicep.Location = new System.Drawing.Point(26, 43);
            this.rdbtnBicep.Name = "rdbtnBicep";
            this.rdbtnBicep.Size = new System.Drawing.Size(72, 25);
            this.rdbtnBicep.TabIndex = 27;
            this.rdbtnBicep.TabStop = true;
            this.rdbtnBicep.Text = "Biceps";
            this.rdbtnBicep.UseVisualStyleBackColor = true;
            // 
            // gpbxTime
            // 
            this.gpbxTime.Controls.Add(this.rdbtn60);
            this.gpbxTime.Controls.Add(this.rdbtn45);
            this.gpbxTime.Controls.Add(this.rdbtn30);
            this.gpbxTime.Controls.Add(this.rdbtn20);
            this.gpbxTime.Location = new System.Drawing.Point(75, 132);
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
            // rdbtnHamstring
            // 
            this.rdbtnHamstring.AutoSize = true;
            this.rdbtnHamstring.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnHamstring.Location = new System.Drawing.Point(26, 198);
            this.rdbtnHamstring.Name = "rdbtnHamstring";
            this.rdbtnHamstring.Size = new System.Drawing.Size(108, 25);
            this.rdbtnHamstring.TabIndex = 40;
            this.rdbtnHamstring.TabStop = true;
            this.rdbtnHamstring.Text = "Hamstrings";
            this.rdbtnHamstring.UseVisualStyleBackColor = true;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 388);
            this.Controls.Add(this.gpbxTime);
            this.Controls.Add(this.gpbxMuscles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selection";
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
        private System.Windows.Forms.RadioButton rdbtnGlutes;
        private System.Windows.Forms.RadioButton rdbtnAbs;
        private System.Windows.Forms.RadioButton rdbtnFull;
        private System.Windows.Forms.RadioButton rdbtnBicep;
        private System.Windows.Forms.GroupBox gpbxTime;
        private System.Windows.Forms.RadioButton rdbtn60;
        private System.Windows.Forms.RadioButton rdbtn45;
        private System.Windows.Forms.RadioButton rdbtn30;
        private System.Windows.Forms.RadioButton rdbtn20;
        private System.Windows.Forms.RadioButton rdbtnCalves;
        private System.Windows.Forms.RadioButton rdbtnChest;
        private System.Windows.Forms.RadioButton rdbtnForearm;
        private System.Windows.Forms.RadioButton rdbtnLats;
        private System.Windows.Forms.RadioButton rdbtnLower;
        private System.Windows.Forms.RadioButton rdbtnMiddle;
        private System.Windows.Forms.RadioButton rdbtnQuads;
        private System.Windows.Forms.RadioButton rdbtnTraps;
        private System.Windows.Forms.RadioButton rdbtnTriceps;
        private System.Windows.Forms.RadioButton rdbtnHamstring;
    }
}