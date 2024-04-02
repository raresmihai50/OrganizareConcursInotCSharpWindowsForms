using System;
using System.Collections.Generic;
using System.Data;
using log4net;
using OrganizareConcursInot.domain;

namespace OrganizareConcursInot.repository
{
    public class OrganizerDBRepository : OrganizerRepository<Organizer, int>
    {
        IDictionary<String, String> props;

        //private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly ILog logger = LogManager.GetLogger("OrganizerDBRepository");

        public OrganizerDBRepository(IDictionary<String, String> props)
        {
            logger.Info("Creating OrganizerDBRepository");
            this.props = props;
        }

        public void addOrganizer(Organizer elem)
        {
            logger.Info("Adding Organizer " + elem.toString());
            var connection = DBUtils.getConnection(props);
            try
            {
                connection.Open();
                string sql = "INSERT INTO Organizer (id, username, password) VALUES (@id, @username, @password)";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    // Crearea și adăugarea parametrilor manual
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@id";
                    paramId.Value = elem.getId();
                    command.Parameters.Add(paramId);

                    var paramUsername = command.CreateParameter();
                    paramUsername.ParameterName = "@username";
                    paramUsername.Value = elem.getUsername();
                    command.Parameters.Add(paramUsername);

                    var paramPassword = command.CreateParameter();
                    paramPassword.ParameterName = "@password";
                    paramPassword.Value = elem.getPassword();
                    command.Parameters.Add(paramPassword);

                    command.ExecuteNonQuery(); // Execute the SQL command
                    logger.Info("Saved organizer" + elem.toString());
                }
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }
            finally
            {
                // Always close the connection, whether the operation succeeded or failed
                //connection.Close();
            }
        }

        public void deleteOrganizer(Organizer elem)
        {
            throw new System.NotImplementedException();
        }

        public void updateOrganizer(Organizer elem, int id)
        {
            throw new System.NotImplementedException();
        }

        public Organizer findByIdOrganizer(int id)
        {
            logger.InfoFormat("Entering findByIdOrganizer with value {0}", id);
            IDbConnection con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT * FROM Organizer WHERE id = @id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int idd = dataR.GetInt32(0);
                        string username = dataR.GetString(1);
                        string pass = dataR.GetString(2);
                        Organizer org = new Organizer(idd, username, pass);
                        logger.InfoFormat("Exiting findByIdOrganizer with value found {0}", org);
                        return org;
                    }
                }
            }
            logger.Info("Exiting findByIdOrganizer with nothing found");
            return null;
        }
        public Organizer findByUsernameOrganizer(String username)
        {
            logger.InfoFormat("Entering findByUsernameOrganizer with value {0}", username);
            IDbConnection con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT * FROM Organizer WHERE username = @username";
                IDbDataParameter paramUsername = comm.CreateParameter();
                paramUsername.ParameterName = "@username";
                paramUsername.Value = username;
                comm.Parameters.Add(paramUsername);
                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int idd = dataR.GetInt32(0);
                        string usernamee = dataR.GetString(1);
                        string pass = dataR.GetString(2);
                        Organizer org = new Organizer(idd, usernamee, pass);
                        logger.InfoFormat("Exiting findByIdOrganizer with value found {0}", org);
                        return org;
                    }
                }
            }
            logger.Info("Exiting findByUsernameOrganizer with nothing found");
            return null;
        }

        public List<Organizer> findAllOrganizer()
        {
            logger.Info("Entering findAllOrganizer");

            List<Organizer> organizers = new List<Organizer>();

            using (IDbConnection con = DBUtils.getConnection(props))
            {
                con.Open();

                using (var comm = con.CreateCommand())
                {
                    comm.CommandText = "SELECT * FROM Organizer";

                    using (var dataR = comm.ExecuteReader())
                    {
                        while (dataR.Read())
                        {
                            int id = dataR.GetInt32(0);
                            string username = dataR.GetString(1);
                            string password = dataR.GetString(2);

                            Organizer organizer = new Organizer(id, username, password);
                            organizers.Add(organizer);
                        }
                    }
                }
            }

            logger.Info("Exiting findAllOrganizer");
            return organizers;
        }

    }
}