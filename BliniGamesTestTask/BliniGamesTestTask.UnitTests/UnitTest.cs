using NUnit.Framework;
using BliniGamesTestTask;

namespace BliniGamesTestTask.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            NullElementsFiller filler = new NullElementsFiller();
            GameObject obj = new BliniGamesTestTask.GameObject();
        }

        [Test]
        public void getIndexesFromNullElements_ReturnCorrectIndexes()
        {
            GameObject[] testArrayNullOnTheCenter = new GameObject[5] { new GameObject(), null, null, null, new GameObject() };
            GameObject[] testArrayNullOnTheEdges = new GameObject[5] { null, new GameObject(), new GameObject(), new GameObject(), null };
            GameObject[] testArrayNullOnTheEdgesAndCenter = new GameObject[5] { null, new GameObject(), null, new GameObject(), null };
            GameObject[] testArrayNoNull = new GameObject[5] { new GameObject(), new GameObject(), new GameObject(), new GameObject(), new GameObject() };
            GameObject[] testArrayOnlyNull = new GameObject[5] { new GameObject(), new GameObject(), new GameObject(), new GameObject(), new GameObject() };

            Assert.AreEqual(filler.getIndexesFromNullElements()
            Assert.Pass();
        }
    }
}