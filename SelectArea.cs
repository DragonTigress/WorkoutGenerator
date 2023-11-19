using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutGenerator
{
    public partial class SelectArea : Form
    {
        public int txtTimeLoop;
        public string selectedMuscle;

        public SelectArea()
        {
            InitializeComponent();
        }

        public void btnGenerate_Click(object sender, EventArgs e)
        {
            
            if (chkAbs.Checked)
                selectedMuscle = "abdominals";
            else if (chkArms.Checked)
                selectedMuscle = "biceps";
            else if (chkLegs.Checked)
                selectedMuscle = "glutes";
            else
                selectedMuscle = "";

            if (rdbtn20.Checked)
                txtTimeLoop = 2;
            if (rdbtn30.Checked)
                txtTimeLoop = 3;
            if (rdbtn45.Checked)
                txtTimeLoop = 6;
            if (rdbtn60.Checked)
                txtTimeLoop = 10;

            var myForm = new WorkoutPlan(txtTimeLoop, selectedMuscle);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var myForm = new mainForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void chkArms_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkAbs.Checked || this.chkFullBody.Checked || this.chkLegs.Checked)
				this.chkArms.Checked = false;
		}

		private void chkFullBody_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkAbs.Checked || this.chkArms.Checked || this.chkLegs.Checked)
				this.chkFullBody.Checked = false;
		}

		private void chkLegs_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkAbs.Checked || this.chkFullBody.Checked || this.chkArms.Checked)
				this.chkLegs.Checked = false;
		}

		private void chkAbs_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkArms.Checked || this.chkFullBody.Checked || this.chkLegs.Checked)
				this.chkAbs.Checked = false;
		}

		//public string MuscleSelection { get; set; }

		//public GetMuscle(string MuscleSelection)
		//{
		//    if (chkAbs.Checked)
		//        MuscleSelection = "abdominal";
		//    else if (chkArms.Checked)
		//        MuscleSelection = "biceps";
		//    else if (chkLegs.Checked)
		//        MuscleSelection = "glutes";
		//    else
		//        MuscleSelection = "";
		//    return;
		//}
	}
}