using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_CourseWork
{
    public partial class MainForm : Form
    {
        private ClientRegistration clientRegistration;
        private ClientLogin clientLogin;
        private AdminLogin adminLogin;
        public MainForm()
        {
            InitializeComponent();
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButtonMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            clientRegistration = new ClientRegistration();
            clientRegistration.Show();
          
        }

        private void iconButtonEnter_Click(object sender, EventArgs e)
        {
            clientLogin = new ClientLogin();
            clientLogin.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
