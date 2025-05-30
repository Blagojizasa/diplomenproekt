using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankManagementSystem
{
    public partial class Splash : Form
    {
        private Timer timer;
        private Random random;

        public Splash()
        {
            InitializeComponent();

            random = new Random();

            SetupProgressBarAnimation();

            SetupLoginTimer();
        }

        private void SetupProgressBarAnimation()
        {
            Timer progressTimer = new Timer();
            progressTimer.Interval = 30;
            progressTimer.Tick += ProgressTimer_Tick;
            progressTimer.Start();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;

                int percentage = progressBar.Value;
                lblLoading.Text = $"Loading... {percentage}%";
            }
            else
            {
                ((Timer)sender).Stop();
            }
        }

        private void SetupLoginTimer()
        {
            timer = new Timer();

            int randomSeconds = random.Next(3, 21);
            int milliseconds = randomSeconds * 1000;

            timer.Interval = milliseconds;
            timer.Tick += Timer_Tick;
            timer.Start();

            Console.WriteLine($"Will load login form in {randomSeconds} seconds");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            this.Hide();

            Login loginForm = new Login();
            loginForm.Show();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}