namespace NinetyNineBottles.Spec
{
    public class Bottles
    {
        public string Verse(int numberOfBottles)
        {
            return $"VERSE\n{BuildVerse(numberOfBottles)}VERSE";
        }

        private static string BuildVerse(int numberOfBottles)
        {
            if (numberOfBottles == 0)
            {
                return "No more bottles of beer on the wall, no more bottles of beer.\n"
                       + "Go to the store and buy some more, 99 bottles of beer on the wall.\n";
            }

            var bottlesOfBeer = BuildNBottlesOfBeerWithPlurarity(numberOfBottles);
            return $"{bottlesOfBeer} of beer on the wall, {bottlesOfBeer} of beer.\n"
                   + ConstructVerseLineForOneLessBottle(numberOfBottles);
        }

        private static string ConstructVerseLineForOneLessBottle(int numberOfBottles)
        {
            if (numberOfBottles == 1)
            {
                return "Take it down and pass it around, no more bottles of beer on the wall.\n";
            }
            
            var bottlesOfBeer = BuildNBottlesOfBeerWithPlurarity(numberOfBottles-1);
            return $"Take one down and pass it around, {bottlesOfBeer} of beer on the wall.\n";
        }
        
        private static string BuildNBottlesOfBeerWithPlurarity(int numberOfBottles)
        {
            return $"{numberOfBottles} {GetBottlePlurarity(numberOfBottles)}";
        }
        
        private static string GetBottlePlurarity(int numberOfBottles)
        {
            var bottleString = "bottles";
            if (numberOfBottles == 1)
            {
                bottleString = "bottle";
            }

            return bottleString;
        }
    }
}