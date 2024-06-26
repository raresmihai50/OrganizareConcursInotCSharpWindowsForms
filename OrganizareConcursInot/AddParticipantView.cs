using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OrganizareConcursInot.domain;
using OrganizareConcursInot.service;

namespace OrganizareConcursInot;

public partial class AddParticipantView : Form
{
    private Service serv;
    public AddParticipantView(Service serv)
    {
        this.serv = serv;
        InitializeComponent();
        StyleOffCb();
        DistanceOffCb();
    }
    
    private void StyleOnCb()
    {
        backstroke_cb.Visible = true;
        freestyle_cb.Visible = true;
        butterfly_cb.Visible = true;
        individual_cb.Visible = true;
    }

    private void StyleOffCb()
    {
        backstroke_cb.Visible = false;
        backstroke_cb.Checked = false;
        freestyle_cb.Visible = false;
        freestyle_cb.Checked = false;
        butterfly_cb.Visible = false;
        butterfly_cb.Checked = false;
        individual_cb.Visible = false;
        individual_cb.Checked = false;
    }

    private void style_cb_CheckedChanged(object sender, EventArgs e)
    {
        if (style_cb.Checked)
        {
            StyleOnCb();
        }
        else
        {
            StyleOffCb();
        }
    }
    private void DistanceOnCb()
    {
        cb_50m.Visible = true;
        cb_200m.Visible = true;
        cb_800m.Visible = true;
        cb_1500m.Visible = true;
    }

    private void DistanceOffCb()
    {
        cb_50m.Visible = false;
        cb_50m.Checked = false;
        cb_200m.Visible = false;
        cb_200m.Checked = false;
        cb_800m.Visible = false;
        cb_800m.Checked = false;
        cb_1500m.Visible = false;
        cb_1500m.Checked = false;
    }
    private void distance_cb_CheckedChanged(object sender, EventArgs e)
    {
        if (distance_cb.Checked)
        {
            DistanceOnCb();
        }
        else
        {
            DistanceOffCb();
        }
    }
    public void HandleAddParticipant(object sender, EventArgs e)
    {
        List<Trial> trials = new List<Trial>();

        if (distance_cb.Checked)
        {
            if (cb_50m.Checked)
            {
                Trial trial = serv.findTrialByTypeDetails(distance_cb.Text, cb_50m.Text);
                trials.Add(trial);
            }
            if (cb_200m.Checked)
            {
                Trial trial = serv.findTrialByTypeDetails(distance_cb.Text, cb_200m.Text);
                trials.Add(trial);
            }
            if (cb_800m.Checked)
            {
                Trial trial = serv.findTrialByTypeDetails(distance_cb.Text, cb_800m.Text);
                trials.Add(trial);
            }
            if (cb_1500m.Checked)
            {
                Trial trial = serv.findTrialByTypeDetails(distance_cb.Text, cb_1500m.Text);
                trials.Add(trial);
            }
        }

        if (style_cb.Checked)
        {
            if (backstroke_cb.Checked)
            {
                Trial trial = serv.findTrialByTypeDetails(style_cb.Text, backstroke_cb.Text);
                trials.Add(trial);
            }
            if (butterfly_cb.Checked)
            {
                Trial trial = serv.findTrialByTypeDetails(style_cb.Text, butterfly_cb.Text);
                trials.Add(trial);
            }
            if (freestyle_cb.Checked)
            {
                Trial trial = serv.findTrialByTypeDetails(style_cb.Text, freestyle_cb.Text);
                trials.Add(trial);
            }
            if (individual_cb.Checked)
            {
                Trial trial = serv.findTrialByTypeDetails(style_cb.Text, individual_cb.Text);
                trials.Add(trial);
            }
        }

        if (trials.Count == 0)
        {
            MessageBox.Show("Sign Up for at least one Trial !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            Random rand = new Random();
            string name = textBox1.Text;
            int age = int.Parse(textBox2.Text);
            serv.AddParticipant(new Participant(rand.Next(), name, age, trials));
            this.Close();
        }
    }

    public void HandleCancel(object sender, EventArgs e)
    {
        this.Close();
    }

}