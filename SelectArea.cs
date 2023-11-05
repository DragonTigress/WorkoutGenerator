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
            InitializeComponent();
        }

        public void btnGenerate_Click(object sender, EventArgs e)
        {
            var myForm = new WorkoutPlan();
            if (chkAbs.Checked)
                myForm.selectedMuscle = "abdominals";
            else if (chkArms.Checked)
                myForm.selectedMuscle = "biceps";
            else if (chkLegs.Checked)
                myForm.selectedMuscle = "glutes";
            else
                myForm.selectedMuscle = "";

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
            if(chkAbs.Checked || chkFullBody.Checked || chkLegs.Checked)
                (chkArms.Checked) = false;

        }
        private void chkFullBody_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAbs.Checked || chkArms.Checked || chkLegs.Checked)
                (chkFullBody.Checked) = false;
        }

        private void chkLegs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAbs.Checked || chkFullBody.Checked || chkArms.Checked)
                (chkLegs.Checked) = false;
        }

        private void chkAbs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkArms.Checked || chkFullBody.Checked || chkLegs.Checked)
                (chkAbs.Checked) = false;
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
