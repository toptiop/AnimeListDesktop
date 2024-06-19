using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AnimeList.AnimeList;

namespace AnimeList.Component;
public partial class ComicControl : UserControl
{
    private Comic comic;

    public ComicControl()
    {
        InitializeComponent();
    }

    public void SetComicData(Comic comic)
    {
        this.comic = comic;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (comic != null)
        {
            lblTitle.Text = comic.Title;
            lblEpisode.Text = comic.Episode;
            lblLink.Text = comic.Link;

            // Set image
            if (File.Exists(comic.ImagePath))
            {
                pictureBoxComic.ImageLocation = comic.ImagePath;
            }
        }
    }
    public Comic GetComicData()
    {
        return comic;
    }

    public event EventHandler DeleteComicClicked; // Event for deleting comic

    // Event for editing comic
    public event EventHandler EditComicClicked;
    private void btnEdit_Click(object sender, EventArgs e)
    {
        EditComicClicked?.Invoke(this, EventArgs.Empty);
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        DeleteComicClicked?.Invoke(this, EventArgs.Empty);
    }

    private void lblLink_Click(object sender, EventArgs e)
    {
        Label lbl = sender as Label;
        if (lbl != null)
        {
            string url = lbl.Text;
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ไม่สามารถเปิดลิงก์ได้: " + ex.Message);
                }
            }
        }
    }
}
