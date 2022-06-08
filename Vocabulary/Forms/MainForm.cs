using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;


namespace Vocabulary.Forms
{
    public partial class MainForm : Form
    {
        private List<Word> cards;
        private SortedSet<DateTime> studiedDates;

        // The selected dates by the user to review the old cards
        private List<string> reviewDates = new List<string>();

        // It is cached to show the list of cards in an alphabetic order. So, the user can search a word in the list boxes easily
        private SortedList<string, Word> sortedCards;

        
        public MainForm()
        {
            InitializeComponent();

            cards = Utility.GetCards();
            sortedCards = Utility.GetSortedCards(cards);

            RefreshReview();

            Utility.LoadOptions();
        }

        private void RefreshReview()
        {
            studiedDates = Utility.GetStudiedDates(cards);

            Cbx_Dates.SelectedItem = null;
            Cbx_Dates.Items.Clear();
            foreach (var item in studiedDates)
            {
                Cbx_Dates.Items.Add(item.ToString(StringLibrary.DateFormat));
            }

            Lbx_Dates.SelectedItem = null;
            Lbx_Dates.Items.Clear();
        }

        private void Btn_Study_Click(object sender, EventArgs e)
        {
            if (cards.Count == 0)
            {
                MessageBox.Show(StringLibrary.InformationMessages.NoCard, StringLibrary.InformationMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Flashcard flashcardForm = new Flashcard(cards, sortedCards, null, (int)NUD_NewWords.Value);
            Hide();
            flashcardForm.ShowDialog();
            flashcardForm.Dispose();

            RefreshReview();
            
            Show();
        }

        private void Btn_Add_Date_Click(object sender, EventArgs e)
        {
            if (Cbx_Dates.SelectedItem == null)
                return;

            string date = Cbx_Dates.GetItemText(Cbx_Dates.SelectedItem);
            reviewDates.Add(date);
            Lbx_Dates.Items.Add(date);
        }

        private void RightClick_Lbx_Dates_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            /** There is only one option. So, don't need to check the clicked item */

            if (Lbx_Dates.SelectedItem == null)
                return;

            string date = Lbx_Dates.GetItemText(Lbx_Dates.SelectedItem);
            reviewDates.Remove(date);
            Lbx_Dates.Items.Remove(date);
        }

        private void Btn_Review_Click(object sender, EventArgs e)
        {
            if (reviewDates.Count == 0)
            {
                MessageBox.Show(StringLibrary.InformationMessages.NoDateSelected, StringLibrary.InformationMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Word> reviews = cards.Where(x => reviewDates.Any(y => x.LastStudied.HasValue && x.LastStudied.Value.ToString(StringLibrary.DateFormat) == y)).ToList();
            if (reviews.Count == 0)
            {
                MessageBox.Show(StringLibrary.InformationMessages.NoCardFound, StringLibrary.InformationMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Flashcard flashcardForm = new Flashcard(null, sortedCards, reviews);
            Hide();
            flashcardForm.ShowDialog();
            flashcardForm.Dispose();

            RefreshReview();

            Show();
        }

        private void Btn_AddWord_Click(object sender, EventArgs e)
        {
            AddWord addWordForm = new AddWord(cards, sortedCards);
            Hide();
            addWordForm.ShowDialog();
            addWordForm.Dispose();

            Show();
        }

        private void Btn_UpdateWord_Click(object sender, EventArgs e)
        {
            if (cards.Count == 0)
            {
                MessageBox.Show(StringLibrary.InformationMessages.NoCard, StringLibrary.InformationMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UpdateWord updateWordForm = new UpdateWord(cards, sortedCards);
            Hide();
            updateWordForm.ShowDialog();
            updateWordForm.Dispose();

            Show();
        }

        private void Btn_RemoveWord_Click(object sender, EventArgs e)
        {
            if (cards.Count == 0)
            {
                MessageBox.Show(StringLibrary.InformationMessages.NoCard, StringLibrary.InformationMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RemoveWord removeWordForm = new RemoveWord(cards, sortedCards);
            Hide();
            removeWordForm.ShowDialog();
            removeWordForm.Dispose();

            Show();
        }

        private void Btn_Options_Click(object sender, EventArgs e)
        {
            Options optionsForm = new Options();
            Hide();
            optionsForm.ShowDialog();
            optionsForm.Dispose();

            Show();
        }
    }
}
