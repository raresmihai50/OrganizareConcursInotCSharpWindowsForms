using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using OrganizareConcursInot.domain;
using OrganizareConcursInot.repository;

namespace organizareConcursInot.tests;

public class Tests
{
    public void runTests()
    {
        testOrganizerDBRepository();
        testTrialDBRepository();
        testParticipantDBRepository();
    }
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
    public void testOrganizerDBRepository()
    {
        IDictionary<String, string> props = new SortedList<String, String>();
        props.Add("ConnectionString", GetConnectionStringByName("ConcursInot"));
        
        OrganizerDBRepository repo = new OrganizerDBRepository(props);
        //repo.addOrganizer(new Organizer(2,"Mirel","123"));
        Organizer org = repo.findByIdOrganizer(1);
        Debug.Assert(org.getId()==1);
        List<Organizer> orgs = new List<Organizer>();
        orgs = repo.findAllOrganizer(); 
        Debug.Assert(orgs.Count==2);
        Organizer org2 = repo.findByUsernameOrganizer("Rares");
        Debug.Assert(org2.getUsername()=="Rares");
    }

    public void testTrialDBRepository()
    {
        IDictionary<String, string> props = new SortedList<String, String>();
        props.Add("ConnectionString", GetConnectionStringByName("ConcursInot"));
        TrialDBRepository repo = new TrialDBRepository(props);
        Trial tr = repo.findByIdTrial(1);
        Debug.Assert(tr.getDetails()=="50m");
        //repo.addTrial(new Trial(2, "Distanta", "100m"));
        List<Trial> trials = new List<Trial>();
        trials = repo.findAllTrial();
        Debug.Assert(trials.Count==8);
        Trial tri = repo.findByTypeDetailsTrial("Distance", "1500m");
        Debug.Assert(tri.getDetails()=="1500m");
        Debug.Assert(tri.getType()=="Distance");
        Debug.Assert(tri.getId()==4);
    }

    public void testParticipantDBRepository()
    {
        IDictionary<String, string> props = new SortedList<String, String>();
        props.Add("ConnectionString", GetConnectionStringByName("ConcursInot"));
        TrialDBRepository trRepo = new TrialDBRepository(props);
        ParticipantDBRepository partRepo = new ParticipantDBRepository(props, trRepo);
        List<Trial> trials = new List<Trial>();
        trials = partRepo.findParticipantTrialsById(1);
        Debug.Assert(trials.Count==1);
        //trials.Add(trRepo.findByIdTrial(2));
        //partRepo.addParticipant(new Participant(2,"Marean",25,trials));
        List<Trial> trials2 = new List<Trial>();
        Participant part = partRepo.findByIdParticipant(2);
        Debug.Assert(part.getTrials().Count==2);
        List<Participant> participants = new List<Participant>();
        participants = partRepo.findAllParticipant();
        Debug.Assert(participants[0].getTrials().Count==1);
        Debug.Assert(participants[1].getTrials().Count==2);
        Debug.Assert(participants[1].getName()=="Marean");
    }
}