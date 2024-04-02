using System;
using System.Windows.Forms;
using OrganizareConcursInot.service;

namespace OrganizareConcursInot;

public partial class AddParticipantView : Form
{
    private Service serv;
    public AddParticipantView(Service serv)
    {
        this.serv = serv;
        InitializeComponent();
    }
}