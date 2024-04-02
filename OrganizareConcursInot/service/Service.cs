using System;
using System.Collections.Generic;
using OrganizareConcursInot.domain;
using OrganizareConcursInot.repository;

namespace OrganizareConcursInot.service;

public class Service
{
    private OrganizerDBRepository orgRepo;
    private TrialDBRepository trRepo;
    private ParticipantDBRepository partRepo;

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
}