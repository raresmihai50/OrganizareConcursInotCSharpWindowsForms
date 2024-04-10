using System.ComponentModel;

namespace OrganizareConcursInot;

partial class SearchView
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
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
        this.search_btn = new System.Windows.Forms.Button();
        this.exit_btn = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // dataGridView1
        // 
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new System.Drawing.Point(46, 204);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowTemplate.Height = 24;
        this.dataGridView1.Size = new System.Drawing.Size(714, 181);
        this.dataGridView1.TabIndex = 0;
        // 
        // distance_cb
        // 
        this.distance_cb.Location = new System.Drawing.Point(129, 50);
        this.distance_cb.Name = "distance_cb";
        this.distance_cb.Size = new System.Drawing.Size(104, 24);
        this.distance_cb.TabIndex = 4;
        this.distance_cb.Text = "Distance";
        this.distance_cb.UseVisualStyleBackColor = true;
        this.distance_cb.CheckedChanged += new System.EventHandler(this.distance_cb_CheckedChanged);
        // 
        // style_cb
        // 
        this.style_cb.Location = new System.Drawing.Point(129, 99);
        this.style_cb.Name = "style_cb";
        this.style_cb.Size = new System.Drawing.Size(104, 24);
        this.style_cb.TabIndex = 5;
        this.style_cb.Text = "Style";
        this.style_cb.UseVisualStyleBackColor = true;
        this.style_cb.CheckedChanged += new System.EventHandler(this.style_cb_CheckedChanged);
        // 
        // backstroke_cb
        // 
        this.backstroke_cb.Location = new System.Drawing.Point(239, 99);
        this.backstroke_cb.Name = "backstroke_cb";
        this.backstroke_cb.Size = new System.Drawing.Size(104, 24);
        this.backstroke_cb.TabIndex = 6;
        this.backstroke_cb.Text = "Backstroke";
        this.backstroke_cb.UseVisualStyleBackColor = true;
        // 
        // freestyle_cb
        // 
        this.freestyle_cb.Location = new System.Drawing.Point(349, 99);
        this.freestyle_cb.Name = "freestyle_cb";
        this.freestyle_cb.Size = new System.Drawing.Size(92, 24);
        this.freestyle_cb.TabIndex = 7;
        this.freestyle_cb.Text = "Freestyle";
        this.freestyle_cb.UseVisualStyleBackColor = true;
        // 
        // individual_cb
        // 
        this.individual_cb.Location = new System.Drawing.Point(447, 99);
        this.individual_cb.Name = "individual_cb";
        this.individual_cb.Size = new System.Drawing.Size(95, 24);
        this.individual_cb.TabIndex = 8;
        this.individual_cb.Text = "Individual";
        this.individual_cb.UseVisualStyleBackColor = true;
        // 
        // butterfly_cb
        // 
        this.butterfly_cb.Location = new System.Drawing.Point(548, 99);
        this.butterfly_cb.Name = "butterfly_cb";
        this.butterfly_cb.Size = new System.Drawing.Size(104, 24);
        this.butterfly_cb.TabIndex = 9;
        this.butterfly_cb.Text = "Butterfly";
        this.butterfly_cb.UseVisualStyleBackColor = true;
        // 
        // cb_800m
        // 
        this.cb_800m.Location = new System.Drawing.Point(381, 50);
        this.cb_800m.Name = "cb_800m";
        this.cb_800m.Size = new System.Drawing.Size(65, 24);
        this.cb_800m.TabIndex = 10;
        this.cb_800m.Text = "800m";
        this.cb_800m.UseVisualStyleBackColor = true;
        // 
        // cb_1500m
        // 
        this.cb_1500m.Location = new System.Drawing.Point(452, 50);
        this.cb_1500m.Name = "cb_1500m";
        this.cb_1500m.Size = new System.Drawing.Size(104, 24);
        this.cb_1500m.TabIndex = 11;
        this.cb_1500m.Text = "1500m";
        this.cb_1500m.UseVisualStyleBackColor = true;
        // 
        // cb_200m
        // 
        this.cb_200m.Location = new System.Drawing.Point(309, 50);
        this.cb_200m.Name = "cb_200m";
        this.cb_200m.Size = new System.Drawing.Size(66, 24);
        this.cb_200m.TabIndex = 12;
        this.cb_200m.Text = "200m";
        this.cb_200m.UseVisualStyleBackColor = true;
        // 
        // cb_50m
        // 
        this.cb_50m.Location = new System.Drawing.Point(239, 50);
        this.cb_50m.Name = "cb_50m";
        this.cb_50m.Size = new System.Drawing.Size(64, 24);
        this.cb_50m.TabIndex = 13;
        this.cb_50m.Text = "50m";
        this.cb_50m.UseVisualStyleBackColor = true;
        // 
        // search_btn
        // 
        this.search_btn.Location = new System.Drawing.Point(129, 141);
        this.search_btn.Name = "search_btn";
        this.search_btn.Size = new System.Drawing.Size(101, 31);
        this.search_btn.TabIndex = 14;
        this.search_btn.Text = "Search";
        this.search_btn.UseVisualStyleBackColor = true;
        this.search_btn.Click += new System.EventHandler(this.HandleSearch);
        // 
        // exit_btn
        // 
        this.exit_btn.Location = new System.Drawing.Point(593, 141);
        this.exit_btn.Name = "exit_btn";
        this.exit_btn.Size = new System.Drawing.Size(80, 31);
        this.exit_btn.TabIndex = 15;
        this.exit_btn.Text = "Exit";
        this.exit_btn.UseVisualStyleBackColor = true;
        this.exit_btn.Click += new System.EventHandler(this.HandleCancel);
        // 
        // SearchView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.exit_btn);
        this.Controls.Add(this.search_btn);
        this.Controls.Add(this.dataGridView1);
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
        this.Location = new System.Drawing.Point(15, 15);
        this.Name = "SearchView";
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button search_btn;
    private System.Windows.Forms.Button exit_btn;

    private System.Windows.Forms.DataGridView dataGridView1;
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

    #endregion
}