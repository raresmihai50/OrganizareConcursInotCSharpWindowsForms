using System;
using System.Collections.Generic;
using System.Data;
using log4net;
using OrganizareConcursInot.domain;

namespace OrganizareConcursInot.repository
{
    public class TrialDBRepository : TrialRepository<Trial, int>
    {
        IDictionary<String, String> props;

        //private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly ILog logger = LogManager.GetLogger("TrialDBRepository");

        public TrialDBRepository(IDictionary<String, String> props)
        {
            logger.Info("Creating TrialDBRepository");
            this.props = props;
        }

        public void addTrial(Trial elem)
        {
            logger.Info("Adding Trial " + elem.toString());
            var connection = DBUtils.getConnection(props);
            try
            {
                connection.Open();
                string sql = "INSERT INTO Trial (id, type, details) VALUES (@id, @type, @details)";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    // Crearea și adăugarea parametrilor manual
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@id";
                    paramId.Value = elem.getId();
                    command.Parameters.Add(paramId);

                    var paramType = command.CreateParameter();
                    paramType.ParameterName = "@type";
                    paramType.Value = elem.getType();
                    command.Parameters.Add(paramType);

                    var paramDetails = command.CreateParameter();
                    paramDetails.ParameterName = "@details";
                    paramDetails.Value = elem.getDetails();
                    command.Parameters.Add(paramDetails);

                    command.ExecuteNonQuery(); // Execute the SQL command
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                // Always close the connection, whether the operation succeeded or failed
                //connection.Close();
            }
        }

        public void deleteTrial(Trial elem)
        {
            throw new System.NotImplementedException();
        }

        public void updateTrial(Trial elem, int id)
        {
            throw new System.NotImplementedException();
        }

        public Trial findByIdTrial(int id)
        {
            logger.InfoFormat("Entering findByIdTrial with value {0}", id);
            IDbConnection con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT * FROM Trial WHERE id = @id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int idd = dataR.GetInt32(0);
                        string type = dataR.GetString(1);
                        string details = dataR.GetString(2);
                        Trial tr = new Trial(idd, type, details);
                        logger.InfoFormat("Exiting findByIdOrganizer with value found {0}", tr);
                        return tr;
                    }
                }
            }

            logger.Info("Exiting findByIdTrial with nothing found");
            return null;
        }

        public Trial findByTypeDetailsTrial(String type, String details)
        {
            logger.InfoFormat("Entering findByTypeDetailsTrial with value {0} , {1}", type, details);
            IDbConnection con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT * FROM Trial WHERE type = @type AND details = @details";

                IDbDataParameter paramType = comm.CreateParameter();
                paramType.ParameterName = "@type";
                paramType.Value = type;
                comm.Parameters.Add(paramType);

                IDbDataParameter paramDetails = comm.CreateParameter();
                paramDetails.ParameterName = "@details";
                paramDetails.Value = details;
                comm.Parameters.Add(paramDetails);
                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int idd = dataR.GetInt32(0);
                        ;
                        Trial tr = new Trial(idd, type, details);
                        logger.InfoFormat("Exiting findByTypeDetailsOrganizer with value found {0}", tr);
                        return tr;
                    }
                }
            }

            logger.Info("Exiting findByIdTrial with nothing found");
            return null;
        }

        public List<Trial> findAllTrial()
        {
            logger.Info("Entering findAllTrial");

            List<Trial> trials = new List<Trial>();

            using (IDbConnection con = DBUtils.getConnection(props))
            {
                con.Open();

                using (var comm = con.CreateCommand())
                {
                    comm.CommandText = "SELECT * FROM Trial";

                    using (var dataR = comm.ExecuteReader())
                    {
                        while (dataR.Read())
                        {
                            int id = dataR.GetInt32(0);
                            string type = dataR.GetString(1);
                            string details = dataR.GetString(2);

                            Trial trial = new Trial(id, type, details);
                            trials.Add(trial);
                        }
                    }
                }
            }

            logger.Info("Exiting findAllTrial");
            return trials;
        }
    }
}