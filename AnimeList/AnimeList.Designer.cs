namespace AnimeList;

partial class AnimeList
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        flowLayoutPanel1 = new FlowLayoutPanel();
        pictureBoxComic = new PictureBox();
        txtTitle = new TextBox();
        txtEpisode = new TextBox();
        txtLink = new TextBox();
        txtImageUrl = new TextBox();
        btnBrowse = new Button();
        btnSave = new Button();
        MainPanel = new FlowLayoutPanel();
        flowLayoutPanelComics = new FlowLayoutPanel();
        flowLayoutPanel3 = new FlowLayoutPanel();
        txtSearch = new TextBox();
        btnSearch = new Button();
        label1 = new Label();
        flowLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxComic).BeginInit();
        MainPanel.SuspendLayout();
        flowLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
        flowLayoutPanel1.Controls.Add(pictureBoxComic);
        flowLayoutPanel1.Controls.Add(txtTitle);
        flowLayoutPanel1.Controls.Add(txtEpisode);
        flowLayoutPanel1.Controls.Add(txtLink);
        flowLayoutPanel1.Controls.Add(txtImageUrl);
        flowLayoutPanel1.Controls.Add(btnBrowse);
        flowLayoutPanel1.Controls.Add(btnSave);
        flowLayoutPanel1.Location = new Point(0, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(180, 681);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // pictureBoxComic
        // 
        pictureBoxComic.Location = new Point(3, 3);
        pictureBoxComic.Name = "pictureBoxComic";
        pictureBoxComic.Size = new Size(173, 171);
        pictureBoxComic.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxComic.TabIndex = 0;
        pictureBoxComic.TabStop = false;
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(3, 180);
        txtTitle.Name = "txtTitle";
        txtTitle.PlaceholderText = "Title";
        txtTitle.Size = new Size(173, 23);
        txtTitle.TabIndex = 1;
        // 
        // txtEpisode
        // 
        txtEpisode.Location = new Point(3, 209);
        txtEpisode.Name = "txtEpisode";
        txtEpisode.PlaceholderText = "Episode";
        txtEpisode.Size = new Size(173, 23);
        txtEpisode.TabIndex = 2;
        // 
        // txtLink
        // 
        txtLink.Location = new Point(3, 238);
        txtLink.Name = "txtLink";
        txtLink.PlaceholderText = "link episode";
        txtLink.Size = new Size(173, 23);
        txtLink.TabIndex = 3;
        // 
        // txtImageUrl
        // 
        txtImageUrl.Location = new Point(3, 267);
        txtImageUrl.Name = "txtImageUrl";
        txtImageUrl.PlaceholderText = "link img";
        txtImageUrl.Size = new Size(173, 23);
        txtImageUrl.TabIndex = 6;
        // 
        // btnBrowse
        // 
        btnBrowse.Location = new Point(3, 296);
        btnBrowse.Name = "btnBrowse";
        btnBrowse.Size = new Size(87, 23);
        btnBrowse.TabIndex = 11;
        btnBrowse.Text = "BrowseImage";
        btnBrowse.UseVisualStyleBackColor = true;
        btnBrowse.Click += btnBrowse_Click;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(96, 296);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(80, 23);
        btnSave.TabIndex = 12;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // MainPanel
        // 
        MainPanel.Controls.Add(flowLayoutPanelComics);
        MainPanel.Controls.Add(flowLayoutPanel3);
        MainPanel.Location = new Point(179, 0);
        MainPanel.Name = "MainPanel";
        MainPanel.Size = new Size(1085, 681);
        MainPanel.TabIndex = 1;
        // 
        // flowLayoutPanelComics
        // 
        flowLayoutPanelComics.AutoScroll = true;
        flowLayoutPanelComics.Location = new Point(0, 0);
        flowLayoutPanelComics.Margin = new Padding(0);
        flowLayoutPanelComics.Name = "flowLayoutPanelComics";
        flowLayoutPanelComics.Size = new Size(1079, 650);
        flowLayoutPanelComics.TabIndex = 4;
        // 
        // flowLayoutPanel3
        // 
        flowLayoutPanel3.BackColor = SystemColors.ActiveCaption;
        flowLayoutPanel3.Controls.Add(txtSearch);
        flowLayoutPanel3.Controls.Add(btnSearch);
        flowLayoutPanel3.Controls.Add(label1);
        flowLayoutPanel3.Location = new Point(0, 650);
        flowLayoutPanel3.Margin = new Padding(0);
        flowLayoutPanel3.Name = "flowLayoutPanel3";
        flowLayoutPanel3.Size = new Size(1079, 38);
        flowLayoutPanel3.TabIndex = 3;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(3, 3);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search";
        txtSearch.Size = new Size(258, 23);
        txtSearch.TabIndex = 0;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(267, 3);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(75, 23);
        btnSearch.TabIndex = 1;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // label1
        // 
        label1.Location = new Point(345, 0);
        label1.Margin = new Padding(0);
        label1.Name = "label1";
        label1.Size = new Size(725, 23);
        label1.TabIndex = 2;
        label1.Text = "Version 0.1.0  ";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // AnimeList
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1258, 681);
        Controls.Add(MainPanel);
        Controls.Add(flowLayoutPanel1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "AnimeList";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AnimeList";
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxComic).EndInit();
        MainPanel.ResumeLayout(false);
        flowLayoutPanel3.ResumeLayout(false);
        flowLayoutPanel3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private FlowLayoutPanel flowLayoutPanel1;
    private PictureBox pictureBoxComic;
    private TextBox txtTitle;
    private TextBox txtEpisode;
    private TextBox txtLink;
    private FlowLayoutPanel MainPanel;
    private FlowLayoutPanel flowLayoutPanelComics;
    private FlowLayoutPanel flowLayoutPanel3;
    private TextBox txtSearch;
    private Button btnSearch;
    private TextBox txtImageUrl;
    private Button btnBrowse;
    private Button btnSave;
    private Label label1;
}
