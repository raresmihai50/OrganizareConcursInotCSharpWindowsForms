using System.ComponentModel;

namespace OrganizareConcursInot;

partial class AddParticipantView
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
        this.add_btn = new System.Windows.Forms.Button();
        this.cancel_btn = new System.Windows.Forms.Button();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.distance_cb = new System.Windows.Forms.CheckBox();
        this.style_cb = new System.Windows.Forms.CheckBox();
        this.backstroke_cb = new System.Windows.Forms.CheckBox();
        this.freestyle_cb = new System.Windows.Forms.CheckBox();
        this.individual_cb = new System.Windows.Forms.CheckBox();
        this.butterfly_cb = new System.Windows.Forms.CheckBox();
        this.cb_800m = new System.Windows.Forms.CheckBox();
        this.cb_1500m = new System.Windows.Forms.CheckBox();
        this.cb_200m = new System.Windows.Forms.CheckBox();
        this.cb_50m = new System.Windows.Forms.CheckBox();
        this.SuspendLayout();
        // 
        // add_btn
        // 
        this.add_btn.Location = new System.Drawing.Point(189, 327);
        this.add_btn.Name = "add_btn";
        this.add_btn.Size = new System.Drawing.Size(152, 31);
        this.add_btn.TabIndex = 0;
        this.add_btn.Text = "Add Participant";
        this.add_btn.UseVisualStyleBackColor = true;
        this.add_btn.Click += new System.EventHandler(this.HandleAddParticipant);
        // 
        // cancel_btn
        // 
        this.cancel_btn.Location = new System.Drawing.Point(189, 364);
        this.cancel_btn.Name = "cancel_btn";
        this.cancel_btn.Size = new System.Drawing.Size(81, 31);
        this.cancel_btn.TabIndex = 1;
        this.cancel_btn.Text = "Cancel";
        this.cancel_btn.UseVisualStyleBackColor = true;
        this.cancel_btn.Click += new System.EventHandler(this.HandleCancel);
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(251, 145);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(286, 22);
        this.textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(251, 173);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(286, 22);
        this.textBox2.TabIndex = 3;
        // 
        // distance_cb
        // 
        this.distance_cb.Location = new System.Drawing.Point(251, 220);
        this.distance_cb.Name = "distance_cb";
        this.distance_cb.Size = new System.Drawing.Size(104, 24);
        this.distance_cb.TabIndex = 4;
        this.distance_cb.Text = "Distance";
        this.distance_cb.UseVisualStyleBackColor = true;
        this.distance_cb.CheckedChanged += new System.EventHandler(this.distance_cb_CheckedChanged);
        // 
        // style_cb
        // 
        this.style_cb.Location = new System.Drawing.Point(251, 279);
        this.style_cb.Name = "style_cb";
        this.style_cb.Size = new System.Drawing.Size(104, 24);
        this.style_cb.TabIndex = 5;
        this.style_cb.Text = "Style";
        this.style_cb.UseVisualStyleBackColor = true;
        this.style_cb.CheckedChanged += new System.EventHandler(this.style_cb_CheckedChanged);
        // 
        // backstroke_cb
        // 
        this.backstroke_cb.Location = new System.Drawing.Point(361, 279);
        this.backstroke_cb.Name = "backstroke_cb";
        this.backstroke_cb.Size = new System.Drawing.Size(104, 24);
        this.backstroke_cb.TabIndex = 6;
        this.backstroke_cb.Text = "Backstroke";
        this.backstroke_cb.UseVisualStyleBackColor = true;
        // 
        // freestyle_cb
        // 
        this.freestyle_cb.Location = new System.Drawing.Point(471, 279);
        this.freestyle_cb.Name = "freestyle_cb";
        this.freestyle_cb.Size = new System.Drawing.Size(104, 24);
        this.freestyle_cb.TabIndex = 7;
        this.freestyle_cb.Text = "Freestyle";
        this.freestyle_cb.UseVisualStyleBackColor = true;
        // 
        // individual_cb
        // 
        this.individual_cb.Location = new System.Drawing.Point(581, 279);
        this.individual_cb.Name = "individual_cb";
        this.individual_cb.Size = new System.Drawing.Size(104, 24);
        this.individual_cb.TabIndex = 8;
        this.individual_cb.Text = "Individual";
        this.individual_cb.UseVisualStyleBackColor = true;
        // 
        // butterfly_cb
        // 
        this.butterfly_cb.Location = new System.Drawing.Point(691, 279);
        this.butterfly_cb.Name = "butterfly_cb";
        this.butterfly_cb.Size = new System.Drawing.Size(104, 24);
        this.butterfly_cb.TabIndex = 9;
        this.butterfly_cb.Text = "Butterfly";
        this.butterfly_cb.UseVisualStyleBackColor = true;
        // 
        // cb_800m
        // 
        this.cb_800m.Location = new System.Drawing.Point(581, 220);
        this.cb_800m.Name = "cb_800m";
        this.cb_800m.Size = new System.Drawing.Size(104, 24);
        this.cb_800m.TabIndex = 10;
        this.cb_800m.Text = "800m";
        this.cb_800m.UseVisualStyleBackColor = true;
        // 
        // cb_1500m
        // 
        this.cb_1500m.Location = new System.Drawing.Point(691, 220);
        this.cb_1500m.Name = "cb_1500m";
        this.cb_1500m.Size = new System.Drawing.Size(104, 24);
        this.cb_1500m.TabIndex = 11;
        this.cb_1500m.Text = "1500m";
        this.cb_1500m.UseVisualStyleBackColor = true;
        // 
        // cb_200m
        // 
        this.cb_200m.Location = new System.Drawing.Point(471, 220);
        this.cb_200m.Name = "cb_200m";
        this.cb_200m.Size = new System.Drawing.Size(104, 24);
        this.cb_200m.TabIndex = 12;
        this.cb_200m.Text = "200m";
        this.cb_200m.UseVisualStyleBackColor = true;
        // 
        // cb_50m
        // 
        this.cb_50m.Location = new System.Drawing.Point(361, 220);
        this.cb_50m.Name = "cb_50m";
        this.cb_50m.Size = new System.Drawing.Size(104, 24);
        this.cb_50m.TabIndex = 13;
        this.cb_50m.Text = "50m";
        this.cb_50m.UseVisualStyleBackColor = true;
        // 
        // AddParticipantView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.cb_50m);
        this.Controls.Add(this.cb_200m);
        this.Controls.Add(this.cb_1500m);
        this.Controls.Add(this.cb_800m);
        this.Controls.Add(this.butterfly_cb);
        this.Controls.Add(this.individual_cb);
        this.Controls.Add(this.freestyle_cb);
        this.Controls.Add(this.backstroke_cb);
        this.Controls.Add(this.style_cb);
        this.Controls.Add(this.distance_cb);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.cancel_btn);
        this.Controls.Add(this.add_btn);
        this.Name = "AddParticipantView";
        this.Text = "Add Participant";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
    
   
    private System.Windows.Forms.CheckBox distance_cb;
    private System.Windows.Forms.CheckBox style_cb;
    private System.Windows.Forms.CheckBox backstroke_cb;
    private System.Windows.Forms.CheckBox freestyle_cb;
    private System.Windows.Forms.CheckBox individual_cb;
    private System.Windows.Forms.CheckBox butterfly_cb;
    private System.Windows.Forms.CheckBox cb_800m;
    private System.Windows.Forms.CheckBox cb_1500m;
    private System.Windows.Forms.CheckBox cb_200m;
    private System.Windows.Forms.CheckBox cb_50m;

    private System.Windows.Forms.Button add_btn;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Button cancel_btn;

    #endregion
}