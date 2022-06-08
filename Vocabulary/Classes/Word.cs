using System;


namespace Vocabulary
{
    public class Word
    {
        public enum EGender { None = 0, Masculine = 1, Feminine = 2, Neutral = 3, Plural = 4 }
        public enum ECardFace { None = 0, Front = 1, Back = 2 }


        public string Singular { get; private set; }
        public string Plural { get; private set; }
        public EGender Gender { get; private set; }

        public string Translation { get; private set; }
        public string Example { get; private set; }

        public DateTime? LastStudied { get; private set; }


        // To check which side of the car has been shown so far
        public ECardFace shownFaces = ECardFace.None;


        public Word(in string singular = null, in string plural = null, EGender gender = EGender.None, in string translation = null, in string example = null, in string lastStudied = null)
        {
            Singular = singular;
            Plural = plural;
            Gender = gender;
            Translation = translation;
            Example = example;
            LastStudied = lastStudied != null && DateTime.TryParse(lastStudied, out DateTime date) ? date : null;
        }

        public void Update(in string singular = null, in string plural = null, EGender gender = EGender.None, in string translation = null, in string example = null)
        {
            Singular = singular;
            Plural = plural;
            Gender = gender;
            Translation = translation;
            Example = example;
        }

        public void UpdateStudyTime()
        {
            LastStudied = DateTime.Now.Date;
            shownFaces = ECardFace.None;
        }
    }
}
