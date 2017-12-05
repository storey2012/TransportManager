using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace TransManager
{
    public partial class frmNote : Form
    {
        private int _ownerid;
        private Client client;
        private Notes collNotes;
        private Notes.NoteType _notetype;
        

        public frmNote(int ownerid, Notes.NoteType notetype)
        {
            InitializeComponent();
            _ownerid = ownerid;
            _notetype = notetype;
            if (notetype == Notes.NoteType.Client)
            {
                client = new Client(ownerid, false);
                this.rtxtClientDetails.Text = (client.Title + " " + client.FirstName + " " + client.Surname).Trim();
                this.rtxtClientDetails.Text += System.Environment.NewLine + client.AddressLine1 + System.Environment.NewLine + client.Postcode;
            }
            else if (notetype == Notes.NoteType.Driver) {
            }

            collNotes = new Notes(ownerid, notetype);
            
            LoadNotestoListView();
        }

        private void frmNote_Load(object sender, EventArgs e)
        {
            //    
        }

        private void LoadNotestoListView()
        {
            Int32 i = 0;
            lvNotes.Items.Clear();
            if (collNotes.Count > 0)
            {
                foreach (Note note in collNotes)
                {
                    ListViewItem lvi = lvNotes.Items.Add(note.NoteID.ToString());
                    lvi.SubItems.Add(note.NoteText);
                    //ListViewItem lvi = lvNotes.Items.Add(note.NoteText);
                    lvi.BackColor = (i++ % 2 == 0) ? Color.LightBlue : Color.LightCyan;
                }
            }
            else
            {
                ListViewItem lvi = lvNotes.Items.Add("There are no notes for this client.");
                if (_notetype == Notes.NoteType.Client)
                {
                    lvi.SubItems.Add("There are no notes for this client.");
                }
                else {
                    lvi.SubItems.Add("There are no notes for this driver.");
                }
            }
        }

        private void lvNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNotes.SelectedItems.Count == 1)
            {
                if (collNotes.Count > 0)
                {
                    Note note = collNotes.Where(j => j.NoteID.ToString() == lvNotes.SelectedItems[0].SubItems[0].Text).First();
                    this.txtNoteID.Text = note.NoteID.ToString();
                    this.rtxtNote.Text = note.NoteText;
                    this.txtEnteredAt.Text = note.EnteredAt.ToString();
                    this.txtEnteredBy.Text = note.EnteredBy;
                    this.btnUpdate.Text = "Save Amended Note";
                    this.btnUpdate.Enabled = false;
                    this.btnCancel.Text = "Cancel";
                    this.btnCancel.Enabled = true;
                    this.btnUpdate.Width = this.btnCancel.Width = this.btnDelete.Width;
                    this.btnUpdate.Left = this.rtxtNote.Left;
                    this.btnCancel.Left = this.rtxtNote.Right-this.btnCancel.Width;
                    this.btnDelete.Visible = true;
                   

                }
                            }

        }

        private void ResetEdits()
        {
            this.lvNotes.SelectedItems.Clear();
            this.btnCancel.Enabled = false;
            this.btnCancel.Text = "Cancel";

            this.btnUpdate.Text = "Add a Note";
            this.btnUpdate.Enabled = true;
            this.rtxtNote.Text = "";
            
            this.rtxtNote.BorderStyle = BorderStyle.None;
            this.txtEnteredAt.Text = "";
            this.txtEnteredBy.Text = "";
            this.txtNoteID.Text = "";

            this.btnDelete.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetEdits();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.rtxtNote.Text == "")
            {
                return;
            }
            
            if (btnUpdate.Text == "Save Note")
            {
                if(collNotes.AddNote(_ownerid, this.rtxtNote.Text)){    
                    MessageBox.Show("Note has been added");
                    this.rtxtNote.BorderStyle = BorderStyle.None;
                    //this.rtxtNote.BackColor = Color.White;                    collNotes.ReloadClientNotes();
                    LoadNotestoListView();
                }
                else
                {
                    MessageBox.Show("Note not added");
                }
                ResetEdits();

            }
            else
                if (btnUpdate.Text == "Save Amended Note")
            {
                int x = Int32.Parse(this.txtNoteID.Text);

                if (collNotes.UpdateNote(System.Convert.ToInt32(this.txtNoteID.Text), rtxtNote.Text))
                {

                    this.rtxtNote.BorderStyle = BorderStyle.Fixed3D;
                    //this.rtxtNote.BackColor = Color.LightYellow;
                    this.rtxtNote.Text = "";
                    this.btnUpdate.Text = "Save Note";
                    this.btnUpdate.Enabled = true;
                    this.rtxtNote.Focus();
                    MessageBox.Show("Note has been updated");
                    collNotes.ReloadClientNotes();
                    ResetEdits();
                    LoadNotestoListView();

                }
                else
                {
                    MessageBox.Show("Note not updated");
                }

            }

        }

        private void rtxtNote_TextChanged(object sender, EventArgs e)
        {
            if (rtxtNote.Text != "")
            {
                //btnUpdate.Enabled = true;
                if (btnUpdate.Text == "Add a Note")
                {
                    btnUpdate.Text = "Save Note";
                }
            }
            btnUpdate.Enabled = btnCancel.Enabled = rtxtNote.Text != string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the current note?", "Notes maintenance", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show(collNotes.DeleteNote(System.Convert.ToInt32(this.txtNoteID.Text)));
            }
            LoadNotestoListView();
            this.rtxtNote.Clear();
            ResetEdits();
        }
    }
}
