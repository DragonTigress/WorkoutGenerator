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
    public partial class WorkoutPlan : Form
    {
        //public string selectedMuscle;
        public static StringBuilder ExerciseList = new StringBuilder();
        private int txtTime;
        private string selectMuscle;

        public WorkoutPlan(int txtTimeLoop, string selectedMuscle)
        {
            InitializeComponent();
            txtTime = txtTimeLoop;
            selectMuscle = selectedMuscle;
        }

        private Task LoadWorkoutPlan()
        {
            //needs the muscle selected for exercise plan.
            ApiRetriever.InitializeClient(selectMuscle, txtTime);
            return Task.CompletedTask;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //clears the exerciseList so that it doesn't keep all exercises in it. 
            ExerciseList.Clear();
            this.Close();
        }

        private void WorkoutPlan_Load(object sender, EventArgs e)
        {
            LoadWorkoutPlan();;
            txtExercises.Text = ExerciseList.ToString();

        }
       
    }
}
