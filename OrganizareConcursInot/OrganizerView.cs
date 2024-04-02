using System;
using System.Windows.Forms;
using OrganizareConcursInot.service;

namespace OrganizareConcursInot;

public partial class OrganizerView : Form
{
    private Service serv;
    public OrganizerView(Service serv)
    {
        this.serv = serv;
        InitializeComponent();
    }

    private EventHandler handleAddParticipant()
    {
        return (sender, e) =>
        {
            AddParticipantView addParticipantView = new AddParticipantView(serv);
            addParticipantView.Show();
            //this.Hide(); // Ascundeți fereastra LogInView
        };
    }
}