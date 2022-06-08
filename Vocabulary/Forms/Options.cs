using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Vocabulary.Forms
{
    public partial class Options : Form
    {
        public static readonly Selections defaultOptions = new Selections(
            Color.Red, Color.DodgerBlue, Color.Green, Color.Goldenrod,
            Keys.NumPad7,
            Keys.NumPad4,
            Keys.NumPad5,
            Keys.Add,
            Keys.Subtract,
            Keys.NumPad1,
            Keys.NumPad9,
            Keys.NumPad2,
            Keys.NumPad3
            );

        public static Selections selections;


        private List<Label> pressKeyLabels = new List<Label>();
        private int keyIndex = 0;
        private bool isListeningKey = false;


        public Options()
        {
            InitializeComponent();

            Btn_Change_Masculine.Click += (sender, e) => { OnChangeColor(ref selections.colorMasculine); };
            Btn_Change_Feminine.Click += (sender, e) => { OnChangeColor(ref selections.colorFeminine); };
            Btn_Change_Neutral.Click += (sender, e) => { OnChangeColor(ref selections.colorNeutral); };
            Btn_Change_Plural.Click += (sender, e) => { OnChangeColor(ref selections.colorPlural); };

            Btn_Change_Hear_Word.Click += (sender, e) => { OnStartListeningKey(0); };
            Btn_Change_Hear_Example.Click += (sender, e) => { OnStartListeningKey(1); };
            Btn_Change_Stop_Speech.Click += (sender, e) => { OnStartListeningKey(2); };
            Btn_Change_Speed_Up.Click += (sender, e) => { OnStartListeningKey(3); };
            Btn_Change_Speed_Down.Click += (sender, e) => { OnStartListeningKey(4); };
            Btn_Change_Show.Click += (sender, e) => { OnStartListeningKey(5); };
            Btn_Change_Edit.Click += (sender, e) => { OnStartListeningKey(6); };
            Btn_Change_Correct.Click += (sender, e) => { OnStartListeningKey(7); };
            Btn_Change_Wrong.Click += (sender, e) => { OnStartListeningKey(8); };

            pressKeyLabels.Add(Lbl_PressKey_Hear_Word);
            pressKeyLabels.Add(Lbl_PressKey_Hear_Example);
            pressKeyLabels.Add(Lbl_PressKey_Stop_Speech);
            pressKeyLabels.Add(Lbl_PressKey_Speed_Up);
            pressKeyLabels.Add(Lbl_PressKey_Speed_Down);
            pressKeyLabels.Add(Lbl_PressKey_Show);
            pressKeyLabels.Add(Lbl_PressKey_Edit);
            pressKeyLabels.Add(Lbl_PressKey_Correct);
            pressKeyLabels.Add(Lbl_PressKey_Wrong);

            RefreshForm();
        }

        public void RefreshForm()
        {
            Pbox_Masculine.BackColor = selections.colorMasculine;
            Pbox_Feminine.BackColor = selections.colorFeminine;
            Pbox_Neutral.BackColor = selections.colorNeutral;
            Pbox_Plural.BackColor = selections.colorPlural;

            Tbx_Hear_Word.Text = selections.keyListenWord.ToString();
            Tbx_Hear_Example.Text = selections.keyListenExample.ToString();
            Tbx_Stop_Speech.Text = selections.keyStopSpeech.ToString();
            Tbx_Speed_Up.Text = selections.keySpeedUp.ToString();
            Tbx_Speed_Down.Text = selections.keySpeedDown.ToString();
            Tbx_Show.Text = selections.keyShow.ToString();
            Tbx_Edit.Text = selections.keyEdit.ToString();
            Tbx_Correct.Text = selections.keyCorrect.ToString();
            Tbx_Wrong.Text = selections.keyWrong.ToString();

            foreach (var item in pressKeyLabels)
            {
                item.Visible = false;
            }
        }

        private void OnChangeColor(ref Color color)
        {
            CD_GenderColor.Color = Color.White;
            DialogResult result = CD_GenderColor.ShowDialog();

            if (result == DialogResult.OK)
            {
                color = CD_GenderColor.Color;
                RefreshForm();
            }
        }

        private void OnStartListeningKey(int index)
        {
            keyIndex = index;

            pressKeyLabels[index].Visible = true;

            isListeningKey = true;
        }

        private void Options_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isListeningKey)
                return;

            if (selections.IsKeyInUse(e.KeyCode))
            {
                MessageBox.Show(StringLibrary.WarningMessages.KeyIsInUse, StringLibrary.WarningMessages.Header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (keyIndex)
            {
                case 0:
                    selections.keyListenWord = e.KeyCode;
                    break;
                case 1:
                    selections.keyListenExample = e.KeyCode;
                    break;
                case 2:
                    selections.keyStopSpeech = e.KeyCode;
                    break;
                case 3:
                    selections.keySpeedUp = e.KeyCode;
                    break;
                case 4:
                    selections.keySpeedDown = e.KeyCode;
                    break;
                case 5:
                    selections.keyShow = e.KeyCode;
                    break;
                case 6:
                    selections.keyEdit = e.KeyCode;
                    break;
                case 7:
                    selections.keyCorrect = e.KeyCode;
                    break;
                case 8:
                    selections.keyWrong = e.KeyCode;
                    break;
                default:
                    break;
            }

            isListeningKey = false;

            RefreshForm();
        }

        private void Btn_Default_Click(object sender, EventArgs e)
        {
            selections = defaultOptions;
            RefreshForm();
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utility.UpdateOptions();
        }


        public struct Selections
        {
            public Color colorMasculine;
            public Color colorFeminine;
            public Color colorNeutral;
            public Color colorPlural;

            public Keys keyListenWord;
            public Keys keyListenExample;
            public Keys keyStopSpeech;
            public Keys keySpeedUp;
            public Keys keySpeedDown;
            public Keys keyShow;
            public Keys keyEdit;
            public Keys keyCorrect;
            public Keys keyWrong;

            public Selections(Color masculine, Color feminine, Color neutral, Color plural,
                Keys listenWord, Keys listenExample, Keys stop, Keys speedUp, Keys speedDown, Keys show, Keys edit, Keys correct, Keys wrong)
            {
                colorMasculine = masculine;
                colorFeminine = feminine;
                colorNeutral = neutral;
                colorPlural = plural;

                keyListenWord = listenWord;
                keyListenExample = listenExample;
                keyStopSpeech = stop;
                keySpeedUp = speedUp;
                keySpeedDown = speedDown;
                keyShow = show;
                keyEdit = edit;
                keyCorrect = correct;
                keyWrong = wrong;
            }

            public bool IsKeyInUse(Keys key)
            {
                if (key == keyListenWord ||
                    key == keyListenExample ||
                    key == keyStopSpeech ||
                    key == keySpeedUp ||
                    key == keySpeedDown ||
                    key == keyShow ||
                    key == keyEdit ||
                    key == keyCorrect ||
                    key == keyWrong)
                    return true;

                return false;
            }
        }
    }
}
