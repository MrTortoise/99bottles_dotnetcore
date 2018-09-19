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
    }
}