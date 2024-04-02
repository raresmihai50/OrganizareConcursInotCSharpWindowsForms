using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net.Config;
using OrganizareConcursInot.repository;
using OrganizareConcursInot.service;
using organizareConcursInot.tests;

namespace OrganizareConcursInot
{
    
    static class Program
    {
        static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.Configure();
            Tests test = new Tests();
            test.runTests();
            Console.WriteLine("Tests passed with success");
            
            IDictionary<String, string> props = new SortedList<String, String>();
            props.Add("ConnectionString", GetConnectionStringByName("ConcursInot"));
            OrganizerDBRepository orgRepo = new OrganizerDBRepository(props);
            TrialDBRepository trRepo = new TrialDBRepository(props);
            ParticipantDBRepository partRepo = new ParticipantDBRepository(props, trRepo);
            Service serv = new Service(orgRepo, trRepo, partRepo);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInView(serv));
        }
    }
    
}