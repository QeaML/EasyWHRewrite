using System;
using System.Windows.Forms;

namespace EasyWHRewrite
{
    public partial class PresetsForm : Form
    {
        private readonly PresetManager M;
        private const string PresetInfoTemplate =
@"ID: {0}
URL: {1}
Name: {2}
Avatar: {3}";
        public PresetsForm()
        {
            // initialize the window
            InitializeComponent();
            // initialize the preset manager
            M = new PresetManager();
            // refresh the list
            RefreshItems();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Dispose(true);
            Close();
            Environment.Exit(0);
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
                // and stop here
                return;
            }

            // get selected preset
            Preset P = M.GetPreset(PresetList.SelectedItems[0].Text);

            // check if it exists
            if(P == null)
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
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
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
                    "Are you sure you want to delete all your presets? (This is irreversible!)", 
                    "EasyWH :: Confirmation", 
                    MessageBoxButtons.YesNo
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
    }
}
