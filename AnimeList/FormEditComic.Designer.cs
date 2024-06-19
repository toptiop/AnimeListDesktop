namespace AnimeList;

partial class FormEditComic
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        txtTitle = new TextBox();
        txtEpisode = new TextBox();
        txtLink = new TextBox();
        btnSave = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // txtTitle
        // 
        txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtTitle.Location = new Point(14, 14);
        txtTitle.Margin = new Padding(4, 3, 4, 3);
        txtTitle.Name = "txtTitle";
        txtTitle.PlaceholderText = "Title";
        txtTitle.Size = new Size(233, 23);
        txtTitle.TabIndex = 0;
        // 
        // txtEpisode
        // 
        txtEpisode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtEpisode.Location = new Point(14, 44);
        txtEpisode.Margin = new Padding(4, 3, 4, 3);
        txtEpisode.Name = "txtEpisode";
        txtEpisode.PlaceholderText = "Episode";
        txtEpisode.Size = new Size(233, 23);
        txtEpisode.TabIndex = 1;
        // 
        // txtLink
        // 
        txtLink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtLink.Location = new Point(14, 74);
        txtLink.Margin = new Padding(4, 3, 4, 3);
        txtLink.Name = "txtLink";
        txtLink.PlaceholderText = "Link";
        txtLink.Size = new Size(233, 23);
        txtLink.TabIndex = 2;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(14, 104);
        btnSave.Margin = new Padding(4, 3, 4, 3);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(88, 27);
        btnSave.TabIndex = 3;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(108, 104);
        btnCancel.Margin = new Padding(4, 3, 4, 3);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(88, 27);
        btnCancel.TabIndex = 4;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // FormEditComic
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(261, 149);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        Controls.Add(txtLink);
        Controls.Add(txtEpisode);
        Controls.Add(txtTitle);
        FormBorderStyle = FormBorderStyle.SizableToolWindow;
        Margin = new Padding(4, 3, 4, 3);
        Name = "FormEditComic";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Edit Comic";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtTitle;
    private System.Windows.Forms.TextBox txtEpisode;
    private System.Windows.Forms.TextBox txtLink;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;

    public System.Windows.Forms.TextBox TxtTitle { get => txtTitle; set => txtTitle = value; }
    public System.Windows.Forms.TextBox TxtEpisode { get => txtEpisode; set => txtEpisode = value; }
    public System.Windows.Forms.TextBox TxtLink { get => txtLink; set => txtLink = value; }
}

    #endregion
