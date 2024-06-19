using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeList;
public partial class FormEditComic : Form
{
    private Comic editedComic;

    public FormEditComic(Comic comic)
    {
        InitializeComponent();

        editedComic = new Comic
        {
            Title = comic.Title,
            Episode = comic.Episode,
            Link = comic.Link,
            ImagePath = comic.ImagePath
        };

        UpdateUI();
    }

    private void UpdateUI()
    {
        txtTitle.Text = editedComic.Title;
        txtEpisode.Text = editedComic.Episode;
        txtLink.Text = editedComic.Link;
    }

    public Comic GetEditedComic()
    {
        return editedComic;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        // Save changes to editedComic
        editedComic.Title = txtTitle.Text;
        editedComic.Episode = txtEpisode.Text;
        editedComic.Link = txtLink.Text;

        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }


}

