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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			this.InitializeComponent();
		}

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var myForm = new SelectArea();
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