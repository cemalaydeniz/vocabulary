using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Linq;


namespace Vocabulary.Forms
{
    public partial class Flashcard : Form
    {
        private List<Word> cards;
        private SortedList<string, Word> sortedCards;
        private List<Word> reviews;

        private List<Word> currentList = new List<Word>();
        private Word currentWord;
        private Word.ECardFace currentCardFace;

        private SpeechSynthesizer speech = new SpeechSynthesizer();
        private bool isSpeechInitialized = false;


        public Flashcard(List<Word> cards, SortedList<string, Word> sortedCards, List<Word> reviews, int numofWords = 0)
        {
            InitializeComponent();

            this.cards = cards;
            this.sortedCards = sortedCards;
            this.reviews = reviews;
            
            speech.Volume = 70;
            speech.Rate = 0;

            foreach (var item in speech.GetInstalledVoices())
            {
                if (item.VoiceInfo.Culture.Name == "de-DE")
                {
                    speech.SelectVoice(item.VoiceInfo.Name);
                    isSpeechInitialized = true;
                    break;
                }
            }

            if (!isSpeechInitialized)
            {
                MessageBox.Show(StringLibrary.WarningMessages.NoGermanSpeechFound, StringLibrary.WarningMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            InitializeList(numofWords);
            if (GetNextWord())
            {
                RefreshForm();
            }
        }

        private void InitializeList(int numofWord)
        {
            if (numofWord <= 0)
            {
                // Review the cards
                currentList = reviews;
            }
            else
            {
                // Study new cards

                /* Get all the unstudied cards in the list. The unstudied cards have higher priorities. If there's enough unstudied cards in the XML file then select randomly among them
                 * If there is no or less unstuied cards than the number of words that is going to be studied then order them by their last studied dates and start selecting from the oldest
                 */
                List<Word> unstudiedCards = cards.FindAll(x => !x.LastStudied.HasValue).ToList();
                if (unstudiedCards.Count >= numofWord)
                {
                    if (unstudiedCards.Count == numofWord)
                    {
                        currentList.AddRange(unstudiedCards);
                    }
                    else
                    {
                        Random rnd = new Random();

                        for (int i = 0; i < numofWord; i++)
                        {
                            int index = rnd.Next(0, unstudiedCards.Count);

                            currentList.Add(unstudiedCards[index]);
                            unstudiedCards.RemoveAt(index);
                        }
                    }
                }
                else if (unstudiedCards.Count == 0)
                {
                    List<Word> sorted = cards.OrderBy(x => x.LastStudied).ToList();

                    for (int i = 0; i < numofWord; i++)
                    {
                        if (i >= sorted.Count)
                            break;

                        currentList.Add(sorted[i]);
                    }
                }
                else
                {
                    currentList.AddRange(unstudiedCards);

                    List<Word> sorted = cards.OrderBy(x => x.LastStudied).ToList();

                    int remaining = numofWord - unstudiedCards.Count;
                    for (int i = 0; i < remaining; i++)
                    {
                        if (i >= sorted.Count)
                            break;

                        currentList.Add(sorted[i]);
                    }
                }
            }
        }

        private bool GetNextWord()
        {
            if (currentList.Count == 0)
            {
                MessageBox.Show(StringLibrary.InformationMessages.StudyDone, StringLibrary.InformationMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

                return false;
            }
            else
            {
                Random rnd = new Random();
                currentWord = currentList[rnd.Next(0, currentList.Count)];

                return true;
            }
        }

        private void RefreshForm()
        {
            // Set which side of the car will be shown
            switch (currentWord.shownFaces)
            {
                case Word.ECardFace.None:
                    if (new Random().Next(0, 2) == 0)
                    {
                        currentCardFace = Word.ECardFace.Front;
                    }
                    else
                    {
                        currentCardFace = Word.ECardFace.Back;
                    }
                    break;
                case Word.ECardFace.Front:
                    currentCardFace = Word.ECardFace.Back;
                    break;
                case Word.ECardFace.Back:
                    currentCardFace = Word.ECardFace.Front;
                    break;
                default:
                    break;
            }

            // Adjust the colors
            switch (currentWord.Gender)
            {
                case Word.EGender.None:
                    Lbl_Singular.ForeColor = Color.Gainsboro;
                    Lbl_Plural.ForeColor = Color.Gainsboro;
                    break;
                case Word.EGender.Masculine:
                    Lbl_Singular.ForeColor = Options.selections.colorMasculine;
                    Lbl_Plural.ForeColor = Options.selections.colorPlural;
                    break;
                case Word.EGender.Feminine:
                    Lbl_Singular.ForeColor = Options.selections.colorFeminine;
                    Lbl_Plural.ForeColor = Options.selections.colorPlural;
                    break;
                case Word.EGender.Neutral:
                    Lbl_Singular.ForeColor = Options.selections.colorNeutral;
                    Lbl_Plural.ForeColor = Options.selections.colorPlural;
                    break;
                case Word.EGender.Plural:
                    Lbl_Singular.ForeColor = Options.selections.colorPlural;
                    Lbl_Plural.ForeColor = Options.selections.colorPlural;
                    break;
                default:
                    break;
            }

            // Resize the fonts depending on the length of the texts
            if (currentWord.Singular.Length <= 28)
            {
                Lbl_Singular.Font = new Font(Lbl_Singular.Font.FontFamily, 20, Lbl_Singular.Font.Style);
            }
            else if (currentWord.Singular.Length > 28 && currentWord.Singular.Length <= 35)
            {
                Lbl_Singular.Font = new Font(Lbl_Singular.Font.FontFamily, 16, Lbl_Singular.Font.Style);
            }
            else
            {
                Lbl_Singular.Font = new Font(Lbl_Singular.Font.FontFamily, 14, Lbl_Singular.Font.Style);
            }

            if (currentWord.Plural != null)
            {
                if (currentWord.Plural.Length <= 28)
                {
                    Lbl_Plural.Font = new Font(Lbl_Plural.Font.FontFamily, 20, Lbl_Plural.Font.Style);
                }
                else if (currentWord.Plural.Length > 28 && currentWord.Plural.Length <= 35)
                {
                    Lbl_Plural.Font = new Font(Lbl_Plural.Font.FontFamily, 16, Lbl_Plural.Font.Style);
                }
                else
                {
                    Lbl_Plural.Font = new Font(Lbl_Plural.Font.FontFamily, 14, Lbl_Plural.Font.Style);
                } 
            }

            // Fill the fields
            switch (currentCardFace)
            {
                case Word.ECardFace.Front:
                    Lbl_Singular.Text = currentWord.Singular;
                    Lbl_Plural.Text = currentWord.Plural;

                    Tbx_Translation.Clear();
                    Tbx_Example.Text = currentWord.Example;

                    Btn_Listen_Word.Enabled = true;
                    Btn_Listen_Example.Enabled = true;
                    Btn_Stop.Enabled = true;
                    break;
                case Word.ECardFace.Back:
                    Lbl_Singular.Text = string.Empty;
                    Lbl_Plural.Text = string.Empty;

                    Tbx_Translation.Text = currentWord.Translation;
                    Tbx_Example.Clear();

                    Btn_Listen_Word.Enabled = false;
                    Btn_Listen_Example.Enabled = false;
                    Btn_Stop.Enabled = false;
                    break;
                default:
                    break;
            }

            Btn_Show.Enabled = true;
            Btn_Edit.Enabled = false;
            Btn_Correct.Enabled = false;
            Btn_Wrong.Enabled = false;
        }

        private void Btn_Listen_Word_Click(object sender, EventArgs e)
        {
            if (!isSpeechInitialized)
            {
                MessageBox.Show(StringLibrary.WarningMessages.NoGermanSpeechFound, StringLibrary.WarningMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            speech.SpeakAsyncCancelAll();

            string textToSpeech = Lbl_Singular.Text;
            if (currentWord.Gender != Word.EGender.None && !string.IsNullOrEmpty(Lbl_Plural.Text))
            {
                textToSpeech += ", " + Lbl_Plural.Text;
            }

            speech.Rate = (int)Math.Clamp(NUD_Speed.Value, -10, 10);
            speech.SpeakAsync(textToSpeech);
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            if (currentCardFace == Word.ECardFace.Front)
            {
                Tbx_Translation.Text = currentWord.Translation;
            }
            else
            {
                Lbl_Singular.Text = currentWord.Singular;
                Lbl_Plural.Text = currentWord.Plural;
                Tbx_Example.Text = currentWord.Example;

                Btn_Listen_Word.Enabled = true;
                Btn_Listen_Example.Enabled = true;
                Btn_Stop.Enabled = true;
            }

            Btn_Show.Enabled = false;
            Btn_Edit.Enabled = true;
            Btn_Correct.Enabled = true;
            Btn_Wrong.Enabled = true;
        }

        private void Btn_Listen_Example_Click(object sender, EventArgs e)
        {
            if (!isSpeechInitialized)
            {
                MessageBox.Show(StringLibrary.WarningMessages.NoGermanSpeechFound, StringLibrary.WarningMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            speech.SpeakAsyncCancelAll();

            if (!string.IsNullOrEmpty(Tbx_Example.Text))
            {
                speech.Rate = (int)Math.Clamp(NUD_Speed.Value, -10, 10);
                speech.SpeakAsync(Tbx_Example.Text);
            }
        }

        private void Btn_Correct_Click(object sender, EventArgs e)
        {
            if (currentWord.shownFaces != Word.ECardFace.None)
            {
                // Studied the both sides of the card. Add it to the today's list
                currentWord.UpdateStudyTime();
                Utility.UpdateWordInXML(currentWord.Singular, currentWord);

                currentList.Remove(currentWord);
            }
            else
            {
                currentWord.shownFaces = currentCardFace;
            }

            speech.SpeakAsyncCancelAll();

            GetNextWord();
            RefreshForm();
        }

        private void Btn_Wrong_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();

            GetNextWord();
            RefreshForm();
        }

        private void Flashcard_FormClosing(object sender, FormClosingEventArgs e)
        {
            speech.Dispose();
        }

        private void Flashcard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Options.selections.keyListenWord)
            {
                if (Btn_Listen_Word.Enabled)
                {
                    Btn_Listen_Word.PerformClick();
                }
            }
            else if (e.KeyCode == Options.selections.keyListenExample)
            {
                if (Btn_Listen_Example.Enabled)
                {
                    Btn_Listen_Example.PerformClick();
                }
            }
            else if (e.KeyCode == Options.selections.keyStopSpeech)
            {
                if (Btn_Stop.Enabled)
                {
                    Btn_Stop.PerformClick();
                }
            }
            else if (e.KeyCode == Options.selections.keyShow)
            {
                if (Btn_Show.Enabled)
                {
                    Btn_Show.PerformClick();
                }
            }
            else if (e.KeyCode == Options.selections.keyEdit)
            {
                if (Btn_Edit.Enabled)
                {
                    Btn_Edit.PerformClick();
                }
            }
            else if (e.KeyCode == Options.selections.keyCorrect)
            {
                if (Btn_Correct.Enabled)
                {
                    Btn_Correct.PerformClick();
                }
            }
            else if (e.KeyCode == Options.selections.keyWrong)
            {
                if (Btn_Wrong.Enabled)
                {
                    Btn_Wrong.PerformClick();
                }
            }
            else if (e.KeyCode == Options.selections.keySpeedUp)
            {
                NUD_Speed.Value = Math.Clamp(NUD_Speed.Value + 1, -10, 10);
            }
            else if (e.KeyCode == Options.selections.keySpeedDown)
            {
                NUD_Speed.Value = Math.Clamp(NUD_Speed.Value - 1, -10, 10);
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Flashcard_UpdateWord updateWordForm = new Flashcard_UpdateWord(currentWord, sortedCards);
            updateWordForm.ShowDialog();

            RefreshForm();
            Btn_Show.PerformClick();
        }
    }
}
