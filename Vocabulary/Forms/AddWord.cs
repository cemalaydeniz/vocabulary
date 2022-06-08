using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Vocabulary.Forms
{
    public partial class AddWord : Form
    {
        private List<Word> cards;
        private SortedList<string, Word> sortedCards;

        private Word.EGender selectedGender;

        public bool AddedWord { get; private set; }


        public AddWord(List<Word> cards, SortedList<string, Word> sortedCards)
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
            selectedGender = Word.EGender.None;

            Tbx_Singular.Clear();
            Tbx_Plural.Clear();
            RB_None.Checked = true;
            Tbx_Translation.Clear();
            Tbx_Example.Clear();
        }

        private void OnUpdateGender(object sender, EventArgs e, Word.EGender gender)
        {
            RadioButton rButton = (RadioButton)sender;
            if (rButton == null || !rButton.Checked)
                return;

            selectedGender = gender;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
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

            Word newWord = new Word(
                Tbx_Singular.Text,
                Tbx_Plural.Text,
                selectedGender,
                Tbx_Translation.Text,
                Tbx_Example.Text
                );

            cards.Add(newWord);
            sortedCards.Add(newWord.Singular, newWord);
            Utility.AddWordToXML(newWord);

            MessageBox.Show(StringLibrary.DefaultMessages.WordAdded);

            ClearForm();

            AddedWord = true;
        }
    }
}
