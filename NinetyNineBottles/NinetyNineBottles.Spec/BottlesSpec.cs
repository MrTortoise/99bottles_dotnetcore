using System;
using System.Collections.Generic;
using System.Data;
using Xunit;

namespace NinetyNineBottles.Spec
{
    public class BottlesSpec
    {
        [Fact]
        public void Verse_99()
        {
            var expected = @"VERSE
99 bottles of beer on the wall, 99 bottles of beer.
Take one down and pass it around, 98 bottles of beer on the wall.
VERSE";
            Assert.Equal(expected, new Bottles().Verse(99));
        }

        [Fact]
        public void verse_89()
        {
            var expected = @"VERSE
89 bottles of beer on the wall, 89 bottles of beer.
Take one down and pass it around, 88 bottles of beer on the wall.
VERSE";
            Assert.Equal(expected, new Bottles().Verse(89));
        }

        [Fact]
        public void verse_2()
        {
            var expected = @"VERSE
2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.
VERSE";
            Assert.Equal(expected, new Bottles().Verse(2));
        }

        [Fact]
        public void verse_1()
        {
            var expected = @"VERSE
1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.
VERSE";
            Assert.Equal(expected, new Bottles().Verse(1));
        }

        [Fact]
        public void Verse_0()
        {
            var expected = @"VERSE
No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.
VERSE";
            Assert.Equal(expected, new Bottles().Verse(0));
        }

        [Fact]
        public void A_couple_of_verses()
        {
            var expected = @"VERSES
99 bottles of beer on the wall, 99 bottles of beer.
Take one down and pass it around, 98 bottles of beer on the wall.

98 bottles of beer on the wall, 98 bottles of beer.
Take one down and pass it around, 97 bottles of beer on the wall.
VERSES";
            Assert.Equal(expected, new Bottles().Verses(99,98));
        }

        [Fact]
        public void A_few_verses()
        {
            var expected = @"VERSES
2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.

1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.

No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.
VERSES";
            
            Assert.Equal(expected, new Bottles().Verses(2,0));
        }
    }
}