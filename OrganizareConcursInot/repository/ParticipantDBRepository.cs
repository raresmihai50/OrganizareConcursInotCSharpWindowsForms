using System;
using System.Collections.Generic;
using System.Data;
using log4net;
using OrganizareConcursInot.domain;

namespace OrganizareConcursInot.repository
{
    public class ParticipantDBRepository : ParticipantRepository<Participant, int>
    {
        IDictionary<String, String> props;
        TrialDBRepository trialRepo;

        //private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly ILog logger = LogManager.GetLogger("OrganizerDBRepository");

        public ParticipantDBRepository(IDictionary<String, String> props, TrialDBRepository trialRepo)
        {
            logger.Info("Creating ParticipantDBRepository");
            this.props = props;
            this.trialRepo = trialRepo;
        }

        public void addParticipant(Participant elem)
        {
            logger.Info("Adding Participant " + elem.toString());
            var connection = DBUtils.getConnection(props);
            try
            {
                connection.Open();
                string sql = "INSERT INTO Participant (id, name, age) VALUES (@id, @name, @age)";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    // Crearea și adăugarea parametrilor manual
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@id";
                    paramId.Value = elem.getId();
                    command.Parameters.Add(paramId);

                    var paramName = command.CreateParameter();
                    paramName.ParameterName = "@name";
                    paramName.Value = elem.getName();
                    command.Parameters.Add(paramName);

                    var paramAge = command.CreateParameter();
                    paramAge.ParameterName = "@age";
                    paramAge.Value = elem.getAge();
                    command.Parameters.Add(paramAge);

                    command.ExecuteNonQuery(); // Execute the SQL command
                    logger.Info("Saved participant" + elem.toString());
                    foreach (Trial trial in elem.getTrials())
                    {
                        addParticipantToTrial(elem.getId(), trial.getId());
                        logger.Info("Adding participant" + elem.toString() + "to trial " + trial.toString());
                    }
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

        public void deleteParticipant(Participant elem)
        {
            throw new System.NotImplementedException();
        }

        public void updateParticipant(Participant elem, int id)
        {
            throw new System.NotImplementedException();
        }

        public Participant findByIdParticipant(int id)
        {
            logger.InfoFormat("Entering findByIdParticipant with value {0}", id);
            IDbConnection con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT * FROM Participant WHERE id = @id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int idd = dataR.GetInt32(0);
                        string name = dataR.GetString(1);
                        int age = dataR.GetInt32(2);
                        List<Trial> trials = new List<Trial>();
                        trials = findParticipantTrialsById(idd);
                        Participant part = new Participant(idd, name, age, trials);
                        logger.InfoFormat("Exiting findByIdParticipant with value found {0}", part);
                        return part;
                    }
                }
            }

            logger.Info("Exiting findByIdParticipant with nothing found");
            return null;
        }

        public List<Participant> findAllParticipant()
        {
            logger.Info("Entering findAllParticipant");

            List<Participant> participants = new List<Participant>();
            
            IDbConnection con = DBUtils.getConnection(props);
            
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT * FROM Participant";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt32(0);
                        string name = dataR.GetString(1);
                        int age = dataR.GetInt32(2);
                        List<Trial> trials = new List<Trial>();
                        trials = findParticipantTrialsById(id);

                        Participant part = new Participant(id, name, age, trials);
                        participants.Add(part);
                    }
                }
            }

            logger.Info("Exiting findAllParticipant");
            return participants;
        }

        public void addParticipantToTrial(int participantId, int trialId)
        {
            logger.Info("Adding participant with id " + participantId + " to trial with id " + trialId);
            var connection = DBUtils.getConnection(props);
            try
            {
                connection.Open();
                string sql =
                    "INSERT INTO Participant_Trial (id_participant, id_trial) VALUES (@id_participant, @id_trial)";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    var paramIdParticipant = command.CreateParameter();
                    paramIdParticipant.ParameterName = "@id_participant";
                    paramIdParticipant.Value = participantId;
                    command.Parameters.Add(paramIdParticipant);

                    var paramIdTrial = command.CreateParameter();
                    paramIdTrial.ParameterName = "@id_trial";
                    paramIdTrial.Value = trialId;
                    command.Parameters.Add(paramIdTrial);

                    command.ExecuteNonQuery(); // Execute the SQL command
                    logger.Info("Added participant with id" + participantId + "to trial with id" + trialId);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }

        public List<Trial> findParticipantTrialsById(int id)
        {
            logger.Info("Entering findParticipantTrialsById with id " + id);

            List<Trial> trials = new List<Trial>();

            var connection = DBUtils.getConnection(props);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM Participant_Trial WHERE id_participant=@id";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int trialId = dataReader.GetInt32(1);

                            Trial trial = trialRepo.findByIdTrial(trialId);
                            trials.Add(trial);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }

            logger.Info("Exiting findParticipantTrialsById");
            return trials;
        }
    }
}