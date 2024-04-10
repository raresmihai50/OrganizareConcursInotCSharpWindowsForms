using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizareConcursInot.domain;
using OrganizareConcursInot.service;

namespace OrganizareConcursInot
{
    public partial class LogInView : Form
    {
        private Service serv;

        public LogInView(Service serv)
        {
            this.serv = serv;
            InitializeComponent();
        }

        public void handleLogIn(object sender, EventArgs e)
        {
            label1.Text = "";
            String username = textBox1.Text;
            String pass = textBox2.Text;
            Organizer org = serv.findOrganizerByUsername(username);
            if (org!=null)
            {
                if (pass == org.getPassword())
                {
                    OrganizerView organizerView = new OrganizerView(serv, org);
                    organizerView.Show();
                }
                else
                {
                    label1.Text = "Wrong Password !";
                }
            }
            else
            {
                label1.Text = "Username doesn't exist !";
            }
            //this.Hide(); // Ascundeți fereastra LogInView
        }

        private void handleExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}