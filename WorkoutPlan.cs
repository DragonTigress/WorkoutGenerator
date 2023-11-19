using Newtonsoft.Json.Linq;
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
        private static StringBuilder LimitExercise = new StringBuilder();
        public  static List<string> ExerciseList = new List<string> ();
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
            ApiRetriever.InitializeClient(selectMuscle); //, txtTime
            return Task.CompletedTask;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //clears the exerciseList so that it doesn't keep all exercises in it. 
            ExerciseList.Clear();
            LimitExercise.Clear();
            this.Close();
        }

        private void WorkoutPlan_Load(object sender, EventArgs e)
        {
            int i = 0;
            LoadWorkoutPlan();
            Random ExerciseRand = new Random();
            var shuffled = ExerciseList.OrderBy(_ => ExerciseRand.Next()).ToList();
            LimitExercise.AppendLine(String.Join(Environment.NewLine, shuffled.GetRange(0, txtTime)));           

            txtExercises.Text = LimitExercise.ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ExerciseList.Clear();
            LimitExercise.Clear();

            var myForm = new Selection();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
