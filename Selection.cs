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
    public partial class Selection : Form
    {
        public int txtTimeLoop;
        public string selectedMuscle;

        public Selection()
        {
            InitializeComponent();
        }

        public void btnGenerate_Click(object sender, EventArgs e)
        {

            if (rdbtnAbs.Checked)
                selectedMuscle = "abdominals";
            else if (rdbtnBicep.Checked)
                selectedMuscle = "biceps";
            else if (rdbtnCalves.Checked)
                selectedMuscle = "calves";
            else if (rdbtnChest.Checked)
                selectedMuscle = "chest";
            else if (rdbtnForearm.Checked)
                selectedMuscle = "forearms";
            else if (rdbtnGlutes.Checked)
                selectedMuscle = "glutes";
            else if (rdbtnHamstring.Checked)
                selectedMuscle = "hamstrings";
            else if (rdbtnLats.Checked)
                selectedMuscle = "lats";
            else if (rdbtnLower.Checked)
                selectedMuscle = "lower_back";
            else if (rdbtnMiddle.Checked)
                selectedMuscle = "middle_back";
            else if (rdbtnQuads.Checked)
                selectedMuscle = "quadriceps";
            else if (rdbtnTraps.Checked)
                selectedMuscle = "traps";
            else if (rdbtnTriceps.Checked)
                selectedMuscle = "triceps";
            else
                selectedMuscle = "";

            if (rdbtn20.Checked)
                txtTimeLoop = 2;
            else if (rdbtn30.Checked)
                txtTimeLoop = 3;
            else if (rdbtn45.Checked)
                txtTimeLoop = 6;
            else if (rdbtn60.Checked)
                txtTimeLoop = 10;
            else
                txtTimeLoop = 10;

            var myForm = new WorkoutPlan(txtTimeLoop, selectedMuscle);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var myForm = new MainForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}