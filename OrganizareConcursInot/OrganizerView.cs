using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using OrganizareConcursInot.domain;
using OrganizareConcursInot.service;

namespace OrganizareConcursInot;

public partial class OrganizerView : Form
{
    private BindingList<Participant> obs_lst = new BindingList<Participant>();
    private Service serv;
    private Organizer org;

    public OrganizerView(Service serv, Organizer org)
    {
        this.serv = serv;
        this.org = org;
        InitializeComponent();
        label1.Text = org.getUsername();
        setGridView();
        loadParticipantsData();
    }

    private void setGridView()
    {
        participantsGridView.AutoGenerateColumns = false; // Dezactivează generarea automată a coloanelor

        // Adaugă coloanele pentru ID, Name și Age
        participantsGridView.Columns.Add("id_col", "ID");
        participantsGridView.Columns["id_col"].DataPropertyName = "id";

        participantsGridView.Columns.Add("name_col", "Name");
        participantsGridView.Columns["name_col"].DataPropertyName = "name";

        participantsGridView.Columns.Add("age_col", "Age");
        participantsGridView.Columns["age_col"].DataPropertyName = "age";
        
        // Adaugă coloana Trials
        participantsGridView.Columns.Add("trials_col", "Trials");
        participantsGridView.Columns["trials_col"].DataPropertyName = "trials";
        participantsGridView.CellFormatting += participantsGridView_CellFormatting;


        //DataGridViewTextBoxColumn trialsColumn = new DataGridViewTextBoxColumn();
        //trialsColumn.HeaderText = "Trials";
        //trialsColumn.Name = "trials_col";
        //participantsGridView.Columns.Add(trialsColumn); // Adăugare coloană Trials la DataGridView

        // Actualizează sursa de date a DataGridView cu lista de participanți
        participantsGridView.DataSource = obs_lst;
    }


    private void loadParticipantsData()
    {
        // Încărcați datele într-o listă de participanți. Presupunem că serv este instanța serviciului tău.
        List<Participant> participants = serv.findAllParticipant();

        // Actualizați lista de participanți cu datele din serviciu
        obs_lst.Clear(); // Curățați lista existentă pentru a evita duplicarea datelor
        foreach (Participant participant in participants)
        {
            obs_lst.Add(participant);
        }
        // Actualizați sursa de date a DataGridView cu lista de participanți
        participantsGridView.DataSource = obs_lst;

        // for (int i = 0; i < obs_lst.Count; i++)
        // {
        //     Participant participant = obs_lst[i];
        //     participantsGridView.Rows[i].Cells["trials_col"].Value = participant.getTrials().Count.ToString();
        // }
        // Setarea datelor pentru coloana Trials
        // for (int i = 0; i < obs_lst.Count; i++)
        // {
        //     Participant participant = obs_lst[i];
        //     string trialsInfo = ""; // Șirul de caractere în care se va concatena informațiile despre toate Trials
        //     foreach (Trial trial in participant.getTrials())
        //     {
        //         trialsInfo += trial.toString() + "; "; // Concatenarea informațiilor despre fiecare Trial
        //     }
        //
        //     // Atribuirea șirului rezultat în proprietatea DataPropertyName a coloanei Trials pentru participantul curent
        //     participantsGridView.Rows[i].Cells["trials_col"].Value = trialsInfo;
        //     Console.WriteLine(trialsInfo);
        // }
    }
    private void participantsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.ColumnIndex == participantsGridView.Columns["trials_col"].Index && e.RowIndex >= 0)
        {
            // Obține valoarea celulei din lista de participanți la rândul curent
            var value = participantsGridView[e.ColumnIndex, e.RowIndex].Value;

            // Verifică dacă valoarea este o listă de Trial-uri și, dacă da, setează textul celulei cu numărul de elemente din listă
            if (value is List<Trial> trials)
            {
                e.Value = trials.Count;
            }
        }
    }


    private void handleAddParticipant(object sender, EventArgs e)
    {
        AddParticipantView addParticipantView = new AddParticipantView(serv);
        addParticipantView.Show();
        //this.Hide(); // Ascunde fereastra LogInView
    }

    public void HandleCancel(object sender, EventArgs e)
    {
        this.Close();
    }

    public void HandleReload(object sender, EventArgs e)
    {
        loadParticipantsData();
    }

    public void HandleSearch(object sender, EventArgs e)
    {
        SearchView searchView = new SearchView(serv);
        searchView.Show();
    }
}