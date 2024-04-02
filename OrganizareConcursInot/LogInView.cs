using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public EventHandler handleLogIn()
        {
            return (sender, e) =>
            {
                OrganizerView organizerView = new OrganizerView(serv);
                organizerView.Show();
                this.Hide(); // Ascundeți fereastra LogInView
            };
        }

        private EventHandler handleExit()
        {
            return (sender, e) =>
            {
                Application.Exit();
            };
        }
        
    }
}