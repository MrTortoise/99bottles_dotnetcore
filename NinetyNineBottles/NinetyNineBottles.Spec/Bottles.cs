namespace NinetyNineBottles.Spec
{
    public class Bottles
    {
        public string Verse(int numberOfBottles)
        {
            var bottle = new BottlesOfBeer(numberOfBottles);
            var bottlesOfBeer = bottle.GetBottlesOfBeer();
            return "VERSE\n" 
                   + $"{bottlesOfBeer} of beer on the wall, {bottlesOfBeer} of beer.\n"
                   + ConstructVerseLineForOneLessBottle(numberOfBottles)
                   + "VERSE";
        }

        private static string ConstructVerseLineForOneLessBottle(int numberOfBottles)
        {
            var bottlesOfBeer = new BottlesOfBeer(numberOfBottles-1).GetBottlesOfBeer();
            return $"Take one down and pass it around, {bottlesOfBeer} of beer on the wall.\n";
        }
    }

    public class BottlesOfBeer
    {
        public int NumberOfBottles { get; }

        public BottlesOfBeer(int numberOfBottles)
        {
            NumberOfBottles = numberOfBottles;
        }

        public string GetBottlesOfBeer()
        {
            return $"{NumberOfBottles} {GetBottlePlurarity(NumberOfBottles)}";
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