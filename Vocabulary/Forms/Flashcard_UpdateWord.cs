using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Vocabulary.Forms
{
    public partial class Flashcard_UpdateWord : Form
    {
        private Word word;
        private SortedList<string, Word> sortedCards;

        private Word.EGender selectedGender;


        public Flashcard_UpdateWord(Word word, SortedList<string, Word> sortedCards)
        {
            InitializeComponent();

            RB_None.CheckedChanged += (sender, e) => { OnUpdateGender(sender, e, Word.EGender.None); };
            RB_Masculine.CheckedChanged += (sender, e) => { OnUpdateGender(sender, e, Word.EGender.Masculine); };
            RB_Feminine.CheckedChanged += (sender, e) => { OnUpdateGender(sender, e, Word.EGender.Feminine); };
            RB_Neutral.CheckedChanged += (sender, e) => { OnUpdateGender(sender, e, Word.EGender.Neutral); };
            RB_Plural.CheckedChanged += (sender, e) => { OnUpdateGender(sender, e, Word.EGender.Plural); };

            this.word = word;
            this.sortedCards = sortedCards;

            UpdateForm();
        }

        private void UpdateForm()
        {
            selectedGender = word.Gender;

            Tbx_Word.Text = word.Singular;
            Tbx_Singular.Text = word.Singular;
            Tbx_Plural.Text = word.Plural;
            RB_None.Checked = word.Gender == Word.EGender.None;
            RB_Masculine.Checked = word.Gender == Word.EGender.Masculine;
            RB_Feminine.Checked = word.Gender == Word.EGender.Feminine;
            RB_Neutral.Checked = word.Gender == Word.EGender.Neutral;
            RB_Plural.Checked = word.Gender == Word.EGender.Plural;
            Tbx_Translation.Text = word.Translation;
            Tbx_Example.Text = word.Example;
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

            if (sortedCards.ContainsKey(Tbx_Singular.Text))
            {
                MessageBox.Show(StringLibrary.InformationMessages.WordExist, StringLibrary.InformationMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            word.Update(Tbx_Singular.Text, Tbx_Plural.Text, selectedGender, Tbx_Translation.Text, Tbx_Example.Text);
            sortedCards.Remove(Tbx_Singular.Text);
            sortedCards.Add(Tbx_Singular.Text, word);
            Utility.UpdateWordInXML(word.Singular, word);

            MessageBox.Show(StringLibrary.DefaultMessages.WordUpdated);

            Close();
        }
    }
}
