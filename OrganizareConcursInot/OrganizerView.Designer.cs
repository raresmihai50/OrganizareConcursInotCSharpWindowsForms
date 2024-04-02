using System.ComponentModel;

namespace OrganizareConcursInot;

partial class OrganizerView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.btnAdd = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // btnAdd
        // 
        this.btnAdd.Location = new System.Drawing.Point(73, 290);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(163, 48);
        this.btnAdd.TabIndex = 0;
        this.btnAdd.Text = "Add Participant";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.handleAddParticipant());
        // 
        // OrganizerView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnAdd);
        this.Name = "OrganizerView";
        this.Text = "OrganizerView";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnAdd;

    #endregion
}