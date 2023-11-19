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
    public partial class SelectTime : Form
    {
        public int txtTimeLoop;
        public SelectTime()
        {
            InitializeComponent();
        }

        public void btnNext_Click(object sender, EventArgs e)
        {
            //Need to specify how many workouts to show for amount of time added
            if (rdbtn20.Checked)
                txtTimeLoop = 2;
            if (rdbtn30.Checked)
                txtTimeLoop = 3;
            if (rdbtn45.Checked)
                txtTimeLoop = 6;
            if (rdbtn60.Checked)
                txtTimeLoop = 10;

            var myForm = new SelectArea();
            //var myForm2 = new WorkoutPlan();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void lstbxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var workoutForm = new WorkoutPlan();
            //if (lstbxTime.SelectedIndex = "45 minutes")
            //    workoutForm.txtTime = "45";
            //workoutForm.txtTime = lstbxTime.SelectedIndex != 0 ? lstbxTime.SelectedItem.ToString() : "no";



            //Console.WriteLine(workoutForm.txtTime);
        }
    }
}
