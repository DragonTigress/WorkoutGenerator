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
		public SelectArea()
		{
			this.InitializeComponent();
		}

		public void btnGenerate_Click(object sender, EventArgs e)
		{
			var myForm = new WorkoutPlan();
			if (this.chkAbs.Checked)
				myForm.SelectedMuscle = "abdominals";
			else if (this.chkArms.Checked)
				myForm.SelectedMuscle = "biceps";
			else if (this.chkLegs.Checked)
				myForm.SelectedMuscle = "glutes";
			else
				myForm.SelectedMuscle = "";

			this.Hide();
			myForm.ShowDialog();
			this.Close();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			var myForm = new SelectTime();
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