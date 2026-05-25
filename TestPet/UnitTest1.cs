using MyPet;
using MyPet.FSM;
using NUnit.Framework;

namespace TestPet
{
    public class Tests
    {
        MyPet.Pet pet;
        [SetUp]
        public void Setup()
        {
            pet = new MyPet.Pet();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
