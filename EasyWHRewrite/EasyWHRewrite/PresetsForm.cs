using System;
using System.IO;
using System.Windows.Forms;
using ServiceStack;

namespace EasyWHRewrite
{
    public partial class PresetsForm : Form
    {
        private readonly FolderHelper H;
        private readonly PresetManager M;
        private const string PresetInfoTemplate =
@"ID: {0}
URL: {1}
Name: {2}
Avatar: {3}";
        public PresetsForm()
        {
            // initialize the preset manager
            M = new PresetManager();
            // initialize the folder helper
            H = new FolderHelper();
            // check if old-style presets exist
            if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WebhookPresets")))
            {
                DialogResult D = MessageBox.Show(
                    "Old format presets have been detected, would you like to move them to the new format?",
                    "EasyWH :: Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (D == DialogResult.Yes)
                {
                    string OldPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WebhookPresets");
                    foreach (string F in Directory.EnumerateFiles(OldPath))
                    {
                        if (!File.Exists(H.GetPath("Presets", Path.GetFileName(F))))
                        {
                            File.Move(F, H.GetPath("Presets", Path.GetFileName(F)));
                        }
                    }
                    File.Delete(Path.Combine(OldPath, "Example.xml"));
                    Directory.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WebhookPresets"));
                    MessageBox.Show(
                        "The presets have been migrated successfully.",
                        "EasyWH :: Success",
                        MessageBoxButtons.OK
                    );
                }
            }
            // initialize the window
            InitializeComponent();
            // refresh the list
            RefreshItems();
        }

        public void RefreshItems()
        {
            // tell the list we're updating it
            PresetList.BeginUpdate();
            // clear all items
            PresetList.Items.Clear();
            // loop over each preset found
            foreach(string N in M.GetPresetList())
            {
                // add the preset to the list
                PresetList.Items.Add(new ListViewItem(new string[] { N }));
            }
            // tell the list we're done updating
            PresetList.EndUpdate();
            // reset prest info text
            PresetInfoLabel.Text = "Select a preset to see information about it here.";
        }

        private void RefreshAvatarPreview(Preset P)
        {
            try
            {
                byte[] AvatarData = P.Avatar.GetBytesFromUrl();
                using (Stream AvatarStream = new MemoryStream())
                {
                    AvatarStream.Write(AvatarData, 0, AvatarData.Length);
                    AvatarPreview.Image = new System.Drawing.Bitmap(AvatarStream);
                }
            }
            catch (UriFormatException)
            {
                return;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("could not load avatar preview: " + Ex.ToString());
            }
        }

        private void RefreshAvatarPreview()
        {
            AvatarPreview.Image = null;
        }

        private void PresetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check if any items are selected
            if(PresetList.SelectedItems.Count == 0)
            {
                // disable the `Use` and `Delete` buttons since nothing is selected
                UseButton.Enabled = false;
                DeleteButton.Enabled = false;
                EditButton.Enabled = false;
                CloneButton.Enabled = false;
                // reset the preset info text
                PresetInfoLabel.Text = "Select a preset to see information about it here.";
                RefreshAvatarPreview();
                // and stop here
                return;
            }

            Preset P;

            try
            {
                // get selected preset
                P = M.GetPreset(PresetList.SelectedItems[0].Text);
            } 
            catch (System.Xml.XmlException)
            {
                DialogResult D = MessageBox.Show(
                    "There was a problem while loading this preset. Do you wish to remove it?",
                    "EasyWH :: Error",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                );
                if (D == DialogResult.Yes)
                {
                    M.DeletePreset(PresetList.SelectedItems[0].Text);
                }
                else
                {
                    // disable the `Use` and `Delete`
                    UseButton.Enabled = false;
                    DeleteButton.Enabled = false;
                    EditButton.Enabled = false;
                    CloneButton.Enabled = false;
                    // reset the preset info text
                    PresetInfoLabel.Text = "This preset isn't usable."; 
                }
                return;
            }

            // check if it exists
            if (P == null)
            {
                // disable the `Use` and `Delete` buttons since the preset doesn't exist
                UseButton.Enabled = false;
                DeleteButton.Enabled = false;
                EditButton.Enabled = false;
                CloneButton.Enabled = false;
                // tell the user the preset doesn't exist
                PresetInfoLabel.Text =
                    "This preset doesn't exist.";
            }
            else
            {
                if (!P.Usable)
                {
                    // disable the `Use` and `Delete` buttons since the preset isn't usable
                    UseButton.Enabled = false;
                    DeleteButton.Enabled = false;
                    EditButton.Enabled = false;
                    CloneButton.Enabled = false;
                    // tell the user the preset isn't usable
                    PresetInfoLabel.Text =
                        string.Format(
                            PresetInfoTemplate,
                            P.ID,
                            P.URL,
                            P.Nick,
                            P.Avatar
                        ) + 
                        "\nThis preset isn't usable.";
                    return;
                }
                // enable the `Use` and `Delete` buttons since the preset exists
                UseButton.Enabled = true;
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;
                CloneButton.Enabled = true;
                // update the preset info text
                PresetInfoLabel.Text =
                    string.Format(
                        PresetInfoTemplate,
                        P.ID,
                        P.URL,
                        P.Nick,
                        P.Avatar
                    );
                if (P.Avatar != null && P.Avatar != "")
                    RefreshAvatarPreview(P);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // ask for confirmation
            DialogResult D = MessageBox.Show(
                "Are you sure you want to delete this preset? (This is irreversible!)",
                "EasyWH :: Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (D == DialogResult.No) return;
            // get the selected preset
            Preset P = M.GetPreset(PresetList.SelectedItems[0].Text);

            // the preset manager returns `null` if the preset doesn't exist
            if(P == null)
            {
                // show an error
                MessageBox.Show(
                    "That preset doesn't exist!",
                    "EasyWH :: Error",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                // delete the selected preset
                M.DeletePreset(PresetList.SelectedItems[0].Text);
            }
            // refresh list, to delete possibly invalid presets
            RefreshItems();
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            // ask the user if they're sure
            DialogResult D = 
                MessageBox.Show(
                    "Are you sure you want to delete ALL your presets? (This is irreversible!)", 
                    "EasyWH :: Confirmation", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            // check their decision
            if (D == DialogResult.Yes)
            {
                // they want it all gone
                foreach(string I in M.GetPresetList())
                {
                    if (I != "Example")
                        M.DeletePreset(I);
                }
                // update the list
                RefreshItems();
            }
            // they want to keep it all there
            else return;
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            // get the selected preset
            Preset P = M.GetPreset(PresetList.SelectedItems[0].Text);

            // the preset manager returns `null` if the preset doesn't exist
            if (P == null)
            {
                // show an error
                MessageBox.Show(
                    "That preset doesn't exist!",
                    "EasyWH :: Error",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                // initialize a chat window
                ChatForm C = new ChatForm();
                // prepare the webhook
                if (P.Avatar != null)
                {
                    C.OpenWH(P.URL, P.Nick, P.Avatar);
                }
                else
                {
                    C.OpenWH(P.URL, P.Nick);
                }
                // show the chat window
                C.Show();
                C.Activate();
                Hide();
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NewPresetForm N = new NewPresetForm(this, M);
            N.Show();
            N.Activate();
            Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // get the selected preset
            Preset P = M.GetPreset(PresetList.SelectedItems[0].Text);

            // the preset manager returns `null` if the preset doesn't exist
            if (P == null)
            {
                // show an error
                MessageBox.Show(
                    "That preset doesn't exist!",
                    "EasyWH :: Error",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                // initialize a edit window
                EditPresetForm E = new EditPresetForm(this, M, P.ID);
                // show the edit window
                E.Show();
                E.Activate();
                Hide();
            }
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            // check if any items are selected
            if (PresetList.SelectedItems.Count == 0)
            {
                // stop here
                return;
            }
            ClonePresetForm C = new ClonePresetForm(this, M, PresetList.SelectedItems[0].Text);
            C.Show();
            C.Activate();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm M = new MainForm();
            M.Show();
            M.Activate();
            Hide();
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
