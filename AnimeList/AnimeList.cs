using AnimeList.Component;
using System.Net;
using System.Text.Json;

namespace AnimeList;

public partial class AnimeList : Form
{
    private List<Comic> comics = new List<Comic>();
    private string filePath = "comics.json";
    private string imagesFolder = "Images";
    public AnimeList()
    {
        InitializeComponent();
        LoadComics();
        UpdateComicList();
    }
    private void btnBrowse_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pictureBoxComic.ImageLocation = openFileDialog.FileName;
            txtImageUrl.Text = string.Empty; // Clear URL TextBox
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtEpisode.Text) ||
            string.IsNullOrEmpty(txtLink.Text) ||
            (string.IsNullOrEmpty(pictureBoxComic.ImageLocation) && string.IsNullOrEmpty(txtImageUrl.Text)))
        {
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
            return;
        }

        if (!Directory.Exists(imagesFolder))
        {
            Directory.CreateDirectory(imagesFolder);
        }

        string imagePath = string.Empty;
        if (!string.IsNullOrEmpty(pictureBoxComic.ImageLocation))
        {
            imagePath = pictureBoxComic.ImageLocation;
        }
        else if (!string.IsNullOrEmpty(txtImageUrl.Text))
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = txtImageUrl.Text;
                    string fileName = Path.GetFileName(new Uri(url).LocalPath);
                    imagePath = Path.Combine(imagesFolder, fileName);
                    client.DownloadFile(url, imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการดาวน์โหลดไฟล์จาก URL: " + ex.Message);
                return;
            }
        }

        string newImagePath = Path.Combine(imagesFolder, Path.GetFileName(imagePath));

        if (File.Exists(newImagePath))
        {
            // Add a unique identifier to the file name to avoid conflicts
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(newImagePath);
            string extension = Path.GetExtension(newImagePath);
            newImagePath = Path.Combine(imagesFolder, fileNameWithoutExtension + "_" + Guid.NewGuid().ToString() + extension);
        }

        try
        {
            File.Copy(imagePath, newImagePath, true);
        }
        catch (Exception ex)
        {
            MessageBox.Show("เกิดข้อผิดพลาดในการคัดลอกไฟล์: " + ex.Message);
            return;
        }

        Comic newComic = new Comic
        {
            Title = txtTitle.Text,
            Episode = txtEpisode.Text,
            Link = txtLink.Text,
            ImagePath = newImagePath
        };

        comics.Add(newComic);
        SaveComics();
        UpdateComicList();
        ClearForm();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string searchQuery = txtSearch.Text.ToLower();
        var filteredComics = comics.Where(comic => comic.Title.ToLower().Contains(searchQuery)).ToList();
        DisplayComics(filteredComics);
    }

    private void SaveComics()
    {
        string jsonString = JsonSerializer.Serialize(comics);
        File.WriteAllText(filePath, jsonString);
    }

    private void LoadComics()
    {
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            comics = JsonSerializer.Deserialize<List<Comic>>(jsonString);
        }
    }

    private void UpdateComicList()
    {
        DisplayComics(comics);
    }

    private void DisplayComics(List<Comic> comicsToDisplay)
    {
        flowLayoutPanelComics.Controls.Clear();
        foreach (var comic in comicsToDisplay)
        {
            ComicControl comicControl = new ComicControl();
            comicControl.SetComicData(comic);
            comicControl.DeleteComicClicked += ComicControl_DeleteComicClicked; // Attach delete event handler
            comicControl.EditComicClicked += ComicControl_EditComicClicked; // Attach edit event handler
            flowLayoutPanelComics.Controls.Add(comicControl);
        }
    }
    private void ComicControl_EditComicClicked(object sender, EventArgs e)
    {
        // Handle edit event raised from ComicControl
        ComicControl comicControl = (ComicControl)sender;
        EditComic(comicControl);
    }
    private void ComicControl_DeleteComicClicked(object sender, EventArgs e)
    {
        ComicControl comicControl = (ComicControl)sender;
        comics.Remove(comicControl.GetComicData());

        if (File.Exists(comicControl.GetComicData().ImagePath))
        {
            try
            {
                File.Delete(comicControl.GetComicData().ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการลบไฟล์รูปภาพ: " + ex.Message);
            }
        }

        SaveComics();
        UpdateComicList();
    }


    private void EditComic(ComicControl comicControl)
    {
        // Open edit form with current comic data
        FormEditComic formEdit = new FormEditComic(comicControl.GetComicData());

        if (formEdit.ShowDialog() == DialogResult.OK)
        {
            // Update comic data after editing
            Comic editedComic = formEdit.GetEditedComic();

            // Update the comic in the list
            int index = comics.FindIndex(c => c.Title == editedComic.Title);

            if (index != -1)
            {
                // Use EditURL to update the link if the episode number has changed
                string newUrl = EditURL(editedComic.Episode, editedComic.Link);
                if (newUrl != null)
                {
                    editedComic.Link = newUrl;
                    comics[index] = editedComic;

                    // Save changes to JSON file or database
                    SaveComics();

                    // Update display
                    UpdateComicList();
                }
            }
        }
    }

    private string EditURL(string newEpisode, string url)
    {
        // แยกส่วนของ URL เพื่อให้สามารถแทนที่ได้
        int lastDashIndex = url.LastIndexOf('-');
        int lastSlashIndex = url.LastIndexOf('/');

        if (lastDashIndex != -1 && lastSlashIndex != -1 && lastDashIndex < lastSlashIndex)
        {
            // สร้าง URL ใหม่
            string newUrl = url.Substring(0, lastDashIndex + 1) + newEpisode + url.Substring(lastSlashIndex);
            return newUrl;
        }
        else
        {
            MessageBox.Show("URL ไม่ถูกต้อง");
            return null;
        }
    }

    private void ClearForm()
    {
        txtTitle.Clear();
        txtEpisode.Clear();
        txtLink.Clear();
        txtImageUrl.Clear();
        pictureBoxComic.Image = null;
    }

}

public class Comic
{
    public string Title { get; set; }
    public string Episode { get; set; }
    public string Link { get; set; }
    public string ImagePath { get; set; }
}