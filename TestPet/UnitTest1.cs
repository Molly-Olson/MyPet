using MyPet;
using MyPet.FSM;
using NUnit.Framework;

namespace TestPet
{
    public class Tests
    {
        MyPet.Tiger pet;
        [SetUp]
        public void Setup()
        {
            pet = new MyPet.Tiger();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
