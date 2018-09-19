namespace NinetyNineBottles.Spec
{
    public class Bottles
    {
        public string Verse(int numberOfBottles)
        {
            var oneLessBottle = numberOfBottles-1;
            return "VERSE\n" 
                   + $"{numberOfBottles} bottles of beer on the wall, {numberOfBottles} bottles of beer.\n"
                   + ConstructVerseLineForOneLessBottle(oneLessBottle)
                   + "VERSE";
        }

        private static string ConstructVerseLineForOneLessBottle(int oneLessBottle)
        {
            var bottleString = GetBottlePlurarity(oneLessBottle);
            return $"Take one down and pass it around, {oneLessBottle} {bottleString} of beer on the wall.\n";
        }

        private static string GetBottlePlurarity(int oneLessBottle)
        {
            var bottleString = "bottles";
            if (oneLessBottle == 1)
            {
                bottleString = "bottle";
            }

            return bottleString;
        }
    }
}