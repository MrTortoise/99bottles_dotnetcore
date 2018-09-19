using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NinetyNineBottles.Spec
{
    public class Bottles
    {
        public string Verse(int numberOfBottles)
        {
            var verse = new Verse(numberOfBottles).Sing();
            return $"VERSE\n{verse}\nVERSE";
        }

        public string Verses(int upperNumberOfBottles, int lowerNumberOfBottles)
        {
            StringBuilder verses = new StringBuilder();
            verses.AppendLine("VERSES");
            
            AppendVerses(upperNumberOfBottles, lowerNumberOfBottles, verses);

            verses.Append("VERSES");
            return verses.ToString();
        }

        private void AppendVerses(int upperNumberOfBottles, int lowerNumberOfBottles, StringBuilder verses)
        {
            for (int numberOfBottles = upperNumberOfBottles; numberOfBottles >= lowerNumberOfBottles; numberOfBottles--)
            {
                verses.AppendLine(new Verse(numberOfBottles).Sing());
                AddBlankLineIfMoreVerses(numberOfBottles, lowerNumberOfBottles, verses);
            }
        }

        private void AddBlankLineIfMoreVerses(int numberOfBottles, int lowerNumberOfBottles, StringBuilder verses)
        {
            if (numberOfBottles > lowerNumberOfBottles) verses.AppendLine();
        }

        public string Song()
        {
            var song = new StringBuilder();
            song.AppendLine("SONG");
            AppendVerses(99, 0, song);
            song.Append("SONG");
            return song.ToString();
        }
    }
}