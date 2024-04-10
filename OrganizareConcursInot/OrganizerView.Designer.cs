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
        this.participantsGridView = new System.Windows.Forms.DataGridView();
        this.button1 = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.reload_btn = new System.Windows.Forms.Button();
        this.search_btn = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.participantsGridView)).BeginInit();
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
        this.btnAdd.Click += new System.EventHandler(this.handleAddParticipant);
        // 
        // participantsGridView
        // 
        this.participantsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.participantsGridView.Location = new System.Drawing.Point(73, 102);
        this.participantsGridView.Name = "participantsGridView";
        this.participantsGridView.RowTemplate.Height = 24;
        this.participantsGridView.Size = new System.Drawing.Size(643, 150);
        this.participantsGridView.TabIndex = 1;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(73, 357);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(99, 34);
        this.button1.TabIndex = 2;
        this.button1.Text = "Exit";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.HandleCancel);
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(73, 30);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(450, 28);
        this.label1.TabIndex = 3;
        // 
        // reload_btn
        // 
        this.reload_btn.Location = new System.Drawing.Point(242, 290);
        this.reload_btn.Name = "reload_btn";
        this.reload_btn.Size = new System.Drawing.Size(75, 48);
        this.reload_btn.TabIndex = 4;
        this.reload_btn.Text = "Reload";
        this.reload_btn.UseVisualStyleBackColor = true;
        this.reload_btn.Click += new System.EventHandler(this.HandleReload);
        // 
        // search_btn
        // 
        this.search_btn.Location = new System.Drawing.Point(199, 357);
        this.search_btn.Name = "search_btn";
        this.search_btn.Size = new System.Drawing.Size(89, 34);
        this.search_btn.TabIndex = 5;
        this.search_btn.Text = "Search";
        this.search_btn.UseVisualStyleBackColor = true;
        this.search_btn.Click += new System.EventHandler(this.HandleSearch);
        // 
        // OrganizerView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.search_btn);
        this.Controls.Add(this.reload_btn);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.participantsGridView);
        this.Controls.Add(this.btnAdd);
        this.Location = new System.Drawing.Point(15, 15);
        this.Name = "OrganizerView";
        ((System.ComponentModel.ISupportInitialize)(this.participantsGridView)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button search_btn;

    private System.Windows.Forms.Button reload_btn;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.DataGridView participantsGridView;

    private System.Windows.Forms.Button btnAdd;

    #endregion
}