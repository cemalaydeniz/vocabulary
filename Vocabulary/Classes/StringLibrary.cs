namespace Vocabulary
{
    public class StringLibrary
    {
        public static readonly string CardsPath = "..\\..\\..\\data\\cards.xml";
        public static readonly string OptionsPath = "..\\..\\..\\data\\options.txt";

        public static readonly string DateFormat = "dd'/'MM'/'yyyy";


        public static class XML
        {
            public static readonly string Root = "/list";

            public static readonly string RootEntry = "list";
            public static readonly string WordEntry = "word";
            public static readonly string SingularEntry = "singular";
            public static readonly string PluralEntry = "plural";
            public static readonly string GenderEntry = "gender";
            public static readonly string TranslationEntry = "translation";
            public static readonly string ExampleEntry = "example";
            public static readonly string LastStudiedEntry = "last";
        }

        public static class ErrorMessages
        {
            public static readonly string Header = "Error";
        }

        public static class WarningMessages
        {
            public static readonly string Header = "Warnung";

            public static readonly string SingularFormIsEmpty = "Das Textfeld der Singularform ist leer";
            public static readonly string TranslationIsEmpty = "Das Textfeld der Übersetzung ist leer";

            public static readonly string NoResultToRemove = "Es gibt kein Wort zu entfernen. Suchen Sie bitte zuerst ein Wort";
            public static readonly string NoResultToUpdate = "Es gibt kein Wort zu aktualisieren. Suchen Sie bitte zuerst ein Wort";

            public static readonly string NoGermanSpeechFound = "Es gibt keine deutsche Sprache auf dem Computer zu finden. Bitte laden Sie die deutsche Sprache herunter, um die Anhörfunktion zu nutzen";

            public static readonly string KeyIsInUse = "Die Taste ist in Gebrauch";
        }

        public static class InformationMessages
        {
            public static readonly string Header = "Informationen";

            public static readonly string NoCard = "Es gibt keine Karte. Fügen Sie bitte einige Wörter hinzu";
            public static readonly string NoDateSelected = "Fügen Sie Bitte Datum/Daten hinzu, um die Überprüfung zu beginnen";
            public static readonly string NoCardFound = "";

            public static readonly string WordExist = "Das Wort existiert schon";
            public static readonly string WordNotFound = "Das Wort konnte nicht gefunden werden";

            public static readonly string StudyDone = "Sie haben Ihr Training für heute beendet";
        }

        public static class DefaultMessages
        {
            public static readonly string WordAdded = "Das Wort wurde hinzugefügt";
            public static readonly string WordRemoved = "Das Wort wurde entfernt";
            public static readonly string WordUpdated = "Das Wort wurde aktualisiert";
        }
    }
}
