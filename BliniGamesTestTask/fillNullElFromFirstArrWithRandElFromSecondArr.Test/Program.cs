using NUnit.Framework;
using BliniGamesTestTask;

namespace fillNullElFromFirstArrWithRandElFromSecondArr.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            GameObject obg = new GameObject();
            getConvertedGameObjArrayToList();
            Assert.Pass();
        }
    }
}