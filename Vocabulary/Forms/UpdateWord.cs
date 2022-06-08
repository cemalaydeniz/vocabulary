using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Vocabulary.Forms
{
    public partial class UpdateWord : Form
    {
        private List<Word> cards;
        private SortedList<string, Word> sortedCards;

        private Word searchResult;
        private Word.EGender selectedGender;


        public UpdateWord(List<Word> cards, SortedList<string, Word> sortedCards)
        {
            InitializeComponent();

            RB_None.CheckedChanged += (sender, e) => { OnUpdateGender(sender, e, Word.EGender.None); };
            RB_Masculine.CheckedChanged += (sender, e) => { OnUpdateGender(sender, e, Word.EGender.Masculine); };
            RB_Feminine.CheckedChanged += (sender, e) => { OnUpdateGender(sender, e, Word.EGender.Feminine); };
            RB_Neutral.CheckedChanged += (sender, e) => { OnUpdateGender(sender, e, Word.EGender.Neutral); };
            RB_Plural.CheckedChanged += (sender, e) => { OnUpdateGender(sender, e, Word.EGender.Plural); };

            this.cards = cards;
            this.sortedCards = sortedCards;

            ClearForm();
        }

        private void ClearForm()
        {
            searchResult = null;
            selectedGender = Word.EGender.None;

            Tbx_Search_Singular.Clear();

            Gbx_Result.Enabled = false;
            Tbx_Word.Clear();
            Tbx_Singular.Clear();
            Tbx_Plural.Clear();
            RB_None.Checked = false;
            RB_Masculine.Checked = false;
            RB_Feminine.Checked = false;
            RB_Neutral.Checked = false;
            RB_Plural.Checked = false;
            Tbx_Translation.Clear();
            Tbx_Example.Clear();

            Btn_Update.Enabled = false;

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
            Tbx_Word.Text = searchResult.Singular;
            Tbx_Singular.Text = searchResult.Singular;
            Tbx_Plural.Text = searchResult.Plural;
            Tbx_Translation.Text = searchResult.Translation;
            Tbx_Example.Text = searchResult.Example;
            RB_None.Checked = searchResult.Gender == Word.EGender.None;
            RB_Masculine.Checked = searchResult.Gender == Word.EGender.Masculine;
            RB_Feminine.Checked = searchResult.Gender == Word.EGender.Feminine;
            RB_Neutral.Checked = searchResult.Gender == Word.EGender.Neutral;
            RB_Plural.Checked = searchResult.Gender == Word.EGender.Plural;

            Btn_Update.Enabled = true;
        }

        private void OnUpdateGender(object sender, EventArgs e, Word.EGender gender)
        {
            RadioButton rButton = (RadioButton)sender;
            if (rButton == null || !rButton.Checked)
                return;

            selectedGender = gender;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (searchResult == null)
            {
                MessageBox.Show(StringLibrary.WarningMessages.NoResultToRemove, StringLibrary.WarningMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(Tbx_Singular.Text))
            {
                MessageBox.Show(StringLibrary.WarningMessages.SingularFormIsEmpty, StringLibrary.WarningMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Tbx_Translation.Text))
            {
                MessageBox.Show(StringLibrary.WarningMessages.TranslationIsEmpty, StringLibrary.WarningMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (searchResult.Singular != Tbx_Singular.Text && sortedCards.ContainsKey(Tbx_Singular.Text))
            {
                MessageBox.Show(StringLibrary.InformationMessages.WordExist, StringLibrary.InformationMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            searchResult.Update(Tbx_Singular.Text, Tbx_Plural.Text, selectedGender, Tbx_Translation.Text, Tbx_Example.Text);
            sortedCards.Remove(Tbx_Singular.Text);
            sortedCards.Add(Tbx_Singular.Text, searchResult);
            Utility.UpdateWordInXML(searchResult.Singular, searchResult);

            MessageBox.Show(StringLibrary.DefaultMessages.WordUpdated);

            ClearForm();
        }

        private void UpdateWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(e.Shift || e.Alt || e.Control))
            {
                Btn_Search.PerformClick();
            }
        }
    }
}
