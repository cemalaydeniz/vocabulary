using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.IO;

using Vocabulary.Forms;


namespace Vocabulary
{
    public static class Utility
    {
        /**
         *
         * Initializations
         *
         */

        public static List<Word> GetCards()
        {
            List<Word> result = new List<Word>();

            if (!File.Exists(StringLibrary.CardsPath))
                return result;

            XmlDocument file = new XmlDocument();
            file.Load(StringLibrary.CardsPath);

            XmlNode list = file.DocumentElement.SelectSingleNode(StringLibrary.XML.Root);
            if (list == null || list.ChildNodes.Count == 0)
                return result;

            foreach (XmlNode item in list.ChildNodes)
            {
                if (item[StringLibrary.XML.SingularEntry] == null || item[StringLibrary.XML.GenderEntry] == null || item[StringLibrary.XML.TranslationEntry] == null)
                    continue;

                result.Add(new Word(
                    item[StringLibrary.XML.SingularEntry].InnerText,
                    item[StringLibrary.XML.PluralEntry]?.InnerText,
                    (Word.EGender)int.Parse(item[StringLibrary.XML.GenderEntry].InnerText),
                    item[StringLibrary.XML.TranslationEntry].InnerText,
                    item[StringLibrary.XML.ExampleEntry]?.InnerText,
                    item[StringLibrary.XML.LastStudiedEntry]?.InnerText
                    ));
            }

            return result;
        }

        public static SortedList<string, Word> GetSortedCards(List<Word> cards)
        {
            SortedList<string, Word> result = new SortedList<string, Word>();

            foreach (var item in cards)
            {
                result.Add(item.Singular, item);
            }

            return result;
        }

        public static SortedSet<DateTime> GetStudiedDates(List<Word> cards)
        {
            SortedSet<DateTime> result = new SortedSet<DateTime>();

            foreach (var item in cards)
            {
                if (!item.LastStudied.HasValue)
                    continue;

                result.Add(item.LastStudied.Value);
            }

            return result;
        }

        public static void LoadOptions()
        {
            if (File.Exists(StringLibrary.OptionsPath))
            {
                string[] fileEntries = File.ReadAllLines(StringLibrary.OptionsPath);
                if (fileEntries.Length >= 13)
                {
                    Options.selections = new Options.Selections(
                        ColorCodeToColor(fileEntries[0]),
                        ColorCodeToColor(fileEntries[1]),
                        ColorCodeToColor(fileEntries[2]),
                        ColorCodeToColor(fileEntries[3]),
                        Enum.TryParse(typeof(Keys), fileEntries[4], out object listenWord) ? (Keys)listenWord : Options.defaultOptions.keyListenWord,
                        Enum.TryParse(typeof(Keys), fileEntries[5], out object listenExample) ? (Keys)listenExample : Options.defaultOptions.keyListenExample,
                        Enum.TryParse(typeof(Keys), fileEntries[6], out object stopSpeech) ? (Keys)stopSpeech : Options.defaultOptions.keyStopSpeech,
                        Enum.TryParse(typeof(Keys), fileEntries[7], out object speedUp) ? (Keys)speedUp : Options.defaultOptions.keySpeedUp,
                        Enum.TryParse(typeof(Keys), fileEntries[8], out object speedDown) ? (Keys)speedDown : Options.defaultOptions.keySpeedDown,
                        Enum.TryParse(typeof(Keys), fileEntries[9], out object keyShow) ? (Keys)keyShow : Options.defaultOptions.keyShow,
                        Enum.TryParse(typeof(Keys), fileEntries[10], out object keyEdit) ? (Keys)keyEdit : Options.defaultOptions.keyEdit,
                        Enum.TryParse(typeof(Keys), fileEntries[11], out object keyCorrect) ? (Keys)keyCorrect : Options.defaultOptions.keyCorrect,
                        Enum.TryParse(typeof(Keys), fileEntries[12], out object keyWrong) ? (Keys)keyWrong : Options.defaultOptions.keyWrong
                        );

                    return;
                }
            }

            Options.selections = Options.defaultOptions;
        }

        /**
         *
         * IO Operations
         *
         */

        public static void AddWordToXML(Word word)
        {
            XmlDocument file = new XmlDocument();

            if (File.Exists(StringLibrary.CardsPath))
            {
                file.Load(StringLibrary.CardsPath);
            }
            else
            {
                XmlDeclaration xmlDecleration = file.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = file.DocumentElement;
                file.InsertBefore(xmlDecleration, root);

                root = file.CreateElement(StringLibrary.XML.RootEntry);
                file.AppendChild(root);
            }

            XmlElement wordEntry = file.CreateElement(StringLibrary.XML.WordEntry);

            XmlElement singular = file.CreateElement(StringLibrary.XML.SingularEntry);
            singular.InnerText = word.Singular;
            XmlElement gender = file.CreateElement(StringLibrary.XML.GenderEntry);
            gender.InnerText = ((int)word.Gender).ToString();
            XmlElement translation = file.CreateElement(StringLibrary.XML.TranslationEntry);
            translation.InnerText = word.Translation;

            wordEntry.AppendChild(singular);
            wordEntry.AppendChild(gender);
            wordEntry.AppendChild(translation);

            if (!string.IsNullOrEmpty(word.Plural))
            {
                XmlElement plural = file.CreateElement(StringLibrary.XML.PluralEntry);
                plural.InnerText = word.Plural;

                wordEntry.AppendChild(plural);
            }
            if (!string.IsNullOrEmpty(word.Example))
            {
                XmlElement example = file.CreateElement(StringLibrary.XML.ExampleEntry);
                example.InnerText = word.Example;

                wordEntry.AppendChild(example);
            }

            file.DocumentElement.SelectSingleNode(StringLibrary.XML.Root).AppendChild(wordEntry);
            file.Save(StringLibrary.CardsPath);
        }

        public static void UpdateWordInXML(in string singularForm, Word word)
        {
            if (!File.Exists(StringLibrary.CardsPath))
                return;

            XmlDocument file = new XmlDocument();
            file.Load(StringLibrary.CardsPath);

            XmlNode list = file.DocumentElement.SelectSingleNode(StringLibrary.XML.Root);
            foreach (XmlNode item in list.ChildNodes)
            {
                if (item[StringLibrary.XML.SingularEntry]?.InnerText.Length == singularForm.Length && item[StringLibrary.XML.SingularEntry]?.InnerText == singularForm)
                {
                    item[StringLibrary.XML.SingularEntry].InnerText = word.Singular;
                    item[StringLibrary.XML.GenderEntry].InnerText = ((int)word.Gender).ToString();
                    item[StringLibrary.XML.TranslationEntry].InnerText = word.Translation;

                    if (string.IsNullOrEmpty(word.Plural))
                    {
                        if (item[StringLibrary.XML.PluralEntry] != null)
                        {
                            item.RemoveChild(item[StringLibrary.XML.PluralEntry]);
                        }
                    }
                    else
                    {
                        if (item[StringLibrary.XML.PluralEntry] == null)
                        {
                            XmlElement plural = file.CreateElement(StringLibrary.XML.PluralEntry);
                            plural.InnerText = word.Plural;

                            item.AppendChild(plural);
                        }
                        else
                        {
                            item[StringLibrary.XML.PluralEntry].InnerText = word.Plural;
                        }
                    }

                    if (string.IsNullOrEmpty(word.Example))
                    {
                        if (item[StringLibrary.XML.ExampleEntry] != null)
                        {
                            item.RemoveChild(item[StringLibrary.XML.ExampleEntry]);
                        }
                    }
                    else
                    {
                        if (item[StringLibrary.XML.ExampleEntry] == null)
                        {
                            XmlElement example = file.CreateElement(StringLibrary.XML.ExampleEntry);
                            example.InnerText = word.Example;

                            item.AppendChild(example);
                        }
                        else
                        {
                            item[StringLibrary.XML.ExampleEntry].InnerText = word.Example;
                        }
                    }

                    if (!word.LastStudied.HasValue)
                    {
                        if (item[StringLibrary.XML.LastStudiedEntry] != null)
                        {
                            item.RemoveChild(item[StringLibrary.XML.LastStudiedEntry]);
                        }
                    }
                    else
                    {
                        if (item[StringLibrary.XML.LastStudiedEntry] == null)
                        {
                            XmlElement last = file.CreateElement(StringLibrary.XML.LastStudiedEntry);
                            last.InnerText = word.LastStudied.Value.ToString(StringLibrary.DateFormat);

                            item.AppendChild(last);
                        }
                        else
                        {
                            item[StringLibrary.XML.LastStudiedEntry].InnerText = word.LastStudied.Value.ToString(StringLibrary.DateFormat);
                        }
                    }

                    file.Save(StringLibrary.CardsPath);
                    return;
                }
            }
        }

        public static void RemoveWordFromXML(in string singularForm)
        {
            if (!File.Exists(StringLibrary.CardsPath))
                return;

            XmlDocument file = new XmlDocument();
            file.Load(StringLibrary.CardsPath);

            XmlNode list = file.DocumentElement.SelectSingleNode(StringLibrary.XML.Root);
            foreach (XmlNode item in list.ChildNodes)
            {
                if (item[StringLibrary.XML.SingularEntry]?.InnerText.Length == singularForm.Length && item[StringLibrary.XML.SingularEntry]?.InnerText == singularForm)
                {
                    list.RemoveChild(item);

                    file.Save(StringLibrary.CardsPath);
                    return;
                }
            }
        }

        public static void UpdateOptions()
        {
            List<string> entries = new List<string>();

            entries.Add(ColorToColorCode(Options.selections.colorMasculine));
            entries.Add(ColorToColorCode(Options.selections.colorFeminine));
            entries.Add(ColorToColorCode(Options.selections.colorNeutral));
            entries.Add(ColorToColorCode(Options.selections.colorPlural));

            entries.Add(Options.selections.keyListenWord.ToString());
            entries.Add(Options.selections.keyListenExample.ToString());
            entries.Add(Options.selections.keyStopSpeech.ToString());
            entries.Add(Options.selections.keySpeedUp.ToString());
            entries.Add(Options.selections.keySpeedDown.ToString());
            entries.Add(Options.selections.keyShow.ToString());
            entries.Add(Options.selections.keyEdit.ToString());
            entries.Add(Options.selections.keyCorrect.ToString());
            entries.Add(Options.selections.keyWrong.ToString());

            File.WriteAllLines(StringLibrary.OptionsPath, entries);
        }

        /**
         *
         * Math and string manipulations
         *
         */

        /// <summary>
        /// </summary>
        /// <param name="code">The code must be "R,G,B" format. E.g: "220,150,100"</param>
        /// <returns>Return the color. If code is not resolved, it return white color</returns>
        public static Color ColorCodeToColor(in string code)
        {
            string[] colors = code.Split(',');
            if (colors.Length != 3)
                return Color.White;

            return Color.FromArgb(int.TryParse(colors[0], out int r) ? r : 255,
                int.TryParse(colors[1], out int g) ? g : 255,
                int.TryParse(colors[2], out int b) ? b : 255
                );
        }

        public static string ColorToColorCode(in Color color)
        {
            return color.R + "," + color.G + "," + color.B;
        }
    }
}
