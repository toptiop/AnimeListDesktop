namespace AnimeList.Component;

partial class ComicControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        flowLayoutPanel1 = new FlowLayoutPanel();
        pictureBoxComic = new PictureBox();
        lblTitle = new Label();
        lblEpisode = new Label();
        lblLink = new LinkLabel();
        DeleteBTN = new Button();
        button1 = new Button();
        flowLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxComic).BeginInit();
        SuspendLayout();
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(pictureBoxComic);
        flowLayoutPanel1.Controls.Add(lblTitle);
        flowLayoutPanel1.Controls.Add(lblEpisode);
        flowLayoutPanel1.Controls.Add(lblLink);
        flowLayoutPanel1.Controls.Add(DeleteBTN);
        flowLayoutPanel1.Controls.Add(button1);
        flowLayoutPanel1.Location = new Point(3, 3);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(199, 289);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // pictureBoxComic
        // 
        pictureBoxComic.Location = new Point(35, 3);
        pictureBoxComic.Margin = new Padding(35, 3, 3, 3);
        pictureBoxComic.Name = "pictureBoxComic";
        pictureBoxComic.Size = new Size(123, 166);
        pictureBoxComic.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxComic.TabIndex = 0;
        pictureBoxComic.TabStop = false;
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(3, 172);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(196, 35);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "label1";
        // 
        // lblEpisode
        // 
        lblEpisode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblEpisode.Location = new Point(3, 207);
        lblEpisode.Name = "lblEpisode";
        lblEpisode.Size = new Size(196, 23);
        lblEpisode.TabIndex = 2;
        lblEpisode.Text = "label2";
        // 
        // lblLink
        // 
        lblLink.LinkVisited = true;
        lblLink.Location = new Point(3, 230);
        lblLink.Name = "lblLink";
        lblLink.Size = new Size(196, 23);
        lblLink.TabIndex = 3;
        lblLink.TabStop = true;
        lblLink.Text = "linkLabel1";
        lblLink.TextAlign = ContentAlignment.MiddleLeft;
        lblLink.Click += lblLink_Click;
        // 
        // DeleteBTN
        // 
        DeleteBTN.BackColor = Color.RoyalBlue;
        DeleteBTN.Location = new Point(25, 253);
        DeleteBTN.Margin = new Padding(25, 0, 0, 0);
        DeleteBTN.Name = "DeleteBTN";
        DeleteBTN.Size = new Size(75, 23);
        DeleteBTN.TabIndex = 4;
        DeleteBTN.Text = "Edit";
        DeleteBTN.UseVisualStyleBackColor = false;
        DeleteBTN.Click += btnEdit_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.Red;
        button1.Location = new Point(100, 253);
        button1.Margin = new Padding(0);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 5;
        button1.Text = "Delete";
        button1.UseVisualStyleBackColor = false;
        button1.Click += btnDelete_Click;
        // 
        // ComicControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDark;
        Controls.Add(flowLayoutPanel1);
        Name = "ComicControl";
        Size = new Size(205, 295);
        flowLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBoxComic).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private FlowLayoutPanel flowLayoutPanel1;
    private PictureBox pictureBoxComic;
    private Label lblTitle;
    private Label lblEpisode;
    private LinkLabel lblLink;
    private Button DeleteBTN;
    private Button button1;
}
