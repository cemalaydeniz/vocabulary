using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Vocabulary.Forms
{
    public partial class RemoveWord : Form
    {
        private List<Word> cards;
        private SortedList<string, Word> sortedCards;

        private Word searchResult;


        public RemoveWord(List<Word> cards, SortedList<string, Word> sortedCards)
        {
            InitializeComponent();

            RB_None.CheckedChanged += (sender, e) => { SwitchBackToDefaultGender(); };
            RB_Masculine.CheckedChanged += (sender, e) => { SwitchBackToDefaultGender(); };
            RB_Feminine.CheckedChanged += (sender, e) => { SwitchBackToDefaultGender(); };
            RB_Neutral.CheckedChanged += (sender, e) => { SwitchBackToDefaultGender(); };
            RB_Plural.CheckedChanged += (sender, e) => { SwitchBackToDefaultGender(); };

            this.cards = cards;
            this.sortedCards = sortedCards;

            ClearForm();
        }

        private void ClearForm()
        {
            searchResult = null;

            Tbx_Search_Singular.Clear();

            Gbx_Result.Enabled = false;
            Tbx_Singular.Clear();
            Tbx_Plural.Clear();
            RB_None.Checked = false;
            RB_Masculine.Checked = false;
            RB_Feminine.Checked = false;
            RB_Neutral.Checked = false;
            RB_Plural.Checked = false;
            Tbx_Translation.Clear();
            Tbx_Example.Clear();

            Btn_Remove.Enabled = false;

            Lbx_Cards.Items.Clear();
            foreach (var item in sortedCards)
            {
                Lbx_Cards.Items.Add(item.Key);
            }
        }

        private void Lbx_Cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lbx_Cards.SelectedItem == null)
                return;

            Tbx_Search_Singular.Text = Lbx_Cards.GetItemText(Lbx_Cards.SelectedItem);
        }

        private void SwitchBackToDefaultGender()
        {
            if (searchResult == null)
                return;

            switch (searchResult.Gender)
            {
                case Word.EGender.None:
                    RB_None.Checked = true;
                    break;
                case Word.EGender.Masculine:
                    RB_Masculine.Checked = true;
                    break;
                case Word.EGender.Feminine:
                    RB_Feminine.Checked = true;
                    break;
                case Word.EGender.Neutral:
                    RB_Neutral.Checked = true;
                    break;
                case Word.EGender.Plural:
                    RB_Plural.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tbx_Search_Singular.Text))
            {
                MessageBox.Show(StringLibrary.WarningMessages.SingularFormIsEmpty, StringLibrary.WarningMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            searchResult = null;
            foreach (var item in cards)
            {
                if (item.Singular.Length == Tbx_Search_Singular.Text.Length && item.Singular == Tbx_Search_Singular.Text)
                {
                    searchResult = item;
                    break;
                }
            }

            if (searchResult == null)
            {
                MessageBox.Show(StringLibrary.InformationMessages.WordNotFound, StringLibrary.InformationMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Gbx_Result.Enabled = true;
            Tbx_Singular.Text = searchResult.Singular;
            Tbx_Plural.Text = searchResult.Plural;
            Tbx_Translation.Text = searchResult.Translation;
            Tbx_Example.Text = searchResult.Example;
            RB_None.Checked = searchResult.Gender == Word.EGender.None;
            RB_Masculine.Checked = searchResult.Gender == Word.EGender.Masculine;
            RB_Feminine.Checked = searchResult.Gender == Word.EGender.Feminine;
            RB_Neutral.Checked = searchResult.Gender == Word.EGender.Neutral;
            RB_Plural.Checked = searchResult.Gender == Word.EGender.Plural;

            Btn_Remove.Enabled = true;
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (searchResult == null)
            {
                MessageBox.Show(StringLibrary.WarningMessages.NoResultToRemove, StringLibrary.WarningMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cards.Remove(searchResult);
            sortedCards.Remove(searchResult.Singular);
            Utility.RemoveWordFromXML(searchResult.Singular);

            MessageBox.Show(StringLibrary.DefaultMessages.WordRemoved);

            ClearForm();
        }

        private void RemoveWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(e.Shift || e.Alt || e.Control))
            {
                Btn_Search.PerformClick();
            }
        }
    }
}
