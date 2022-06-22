global using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingApp;

namespace UnitTesting
{
    [TestClass]
    public class CocktailSortTesting
    {
        [TestMethod]
        public void StaticIntegers()
        {
            // arrange

            List<int> input = new List<int> { 6, 1, 3, 7, 2, 7, 9, 8 };
            List<int> expected = new List<int> { 1, 2, 3, 6, 7, 7, 8, 9 };

            // act

            var actual = Cocktail.Sort(input);

            // assert

            for(int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void RandomDoubles()
        {
            // arrange

            int size = 200;
            List<double> expected = new List<double>(size);

            Random random = new Random();
            expected.Add(random.NextDouble());
            for(int i = 1; i < size; i++)
            {
                var delta = random.NextDouble();
                expected.Add(expected[i - 1] + delta);
            }

            List<double> input = new List<double>(expected);
            int swaps_amount = random.Next(4, 50);
            for(int c = 0; c < swaps_amount; c++)
            {
                int i = random.Next(0, size - 1);
                int j = random.Next(0, size - 1);
                double buffer = input[i];
                input[i] = input[j];
                input[j] = buffer;
            }

            // act

            var actual = Cocktail.Sort(input);

            // assert

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void AlphabeticalStrings()
        {
            // arrange

            List<string> expected = new List<string>
            {
                "actually",
                "bacon",
                "cards",
                "dump",
                "fifty",
                "human",
                "keep",
                "manual",
                "peanut",
                "tool",
                "visible",
                "xylophone",
                "zoom"
            };

            List<string> input = new List<string>
            {
                "human",
                "keep",
                "tool",
                "visible",
                "xylophone",
                "zoom",
                "actually",
                "manual",
                "peanut",
                "dump",
                "fifty",
                "bacon",
                "cards",
            };

            // act

            var actual = Cocktail.Sort(input);

            // assert

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(actual[i]));
            }
        }
    }
}