using System;
using System.Collections.Generic;
using log4net;
using OrganizareConcursInot.domain;
using OrganizareConcursInot.repository;

namespace OrganizareConcursInot.service;

public class Service
{
    private OrganizerDBRepository orgRepo;
    private TrialDBRepository trRepo;
    private ParticipantDBRepository partRepo;
    private static readonly ILog logger = LogManager.GetLogger("Service");

    public Service(OrganizerDBRepository orgRepo, TrialDBRepository trRepo, ParticipantDBRepository partRepo)
    {
        this.orgRepo = orgRepo;
        this.trRepo = trRepo;
        this.partRepo = partRepo;
    }

    public Organizer findOrganizerById(int id)
    {
        return orgRepo.findByIdOrganizer(id);
    }

    public bool verifica_parola(String parola_string, String parola_string_2)
    {
        return parola_string.Equals(parola_string_2);
    }

    public Organizer findOrganizerByUsername(String username)
    {
        return orgRepo.findByUsernameOrganizer(username);
    }

    public List<Participant> findAllParticipant()
    {
        return partRepo.findAllParticipant();
    }

    public Participant findParticipantById(int id)
    {
        return partRepo.findByIdParticipant(id);
    }

    public void AddParticipant(Participant participant)
    {
        partRepo.addParticipant(participant);
    }

    public Trial findTrialByTypeDetails(String type, String details)
    {
        return trRepo.findByTypeDetailsTrial(type, details);
    }

    public void addParticipant(Participant participant)
    {
        partRepo.addParticipant(participant);
    }
    public List<Participant> findParticipantsByTrials(List<Trial> trials)
    {
        logger.Info("Entering findParticipantByTrials" + trials.ToString());
        List<Participant> participants = findAllParticipant();
        List<Participant> result = new List<Participant>();

        foreach (Participant part in participants)
        {
            List<Trial> partTrials = part.getTrials();
            bool allTrialsFound = true;

            // Verifică fiecare trial din lista dată
            foreach (Trial trial in trials)
            {
                // Verifică dacă participantul are trialul din lista dată
                if (!partTrials.Contains(trial))
                {
                    allTrialsFound = false;
                    break; // Nu mai este necesar să continuăm căutarea dacă lipsește un trial
                }
            }

            // Dacă toate trialele din lista dată sunt găsite în lista de triale a participantului, adaugă-l la rezultat
            if (allTrialsFound)
            {
                result.Add(part);
            }
        }

        return result;
    }

}