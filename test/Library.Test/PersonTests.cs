using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void CorrectCi()
        {
            Person bruno = new Person("Bruno Villero", "4770816-8");
            Assert.AreEqual(bruno.ID, "4770816-8");
        }

        [Test]
        public void IncorrectCi()
        {
            Person bruno = new Person("Bruno Villero", "4770816-7");
            Assert.AreEqual(bruno.ID, null);
        }

        [Test]
        public void CorrectName()
        {
            Person bruno = new Person("Bruno Villero", "4770816-7");
            Assert.AreEqual(bruno.Name, "Bruno Villero");
        }

        [Test]
        public void IncorrectNameEmptyString()
        {
            Person bruno = new Person("", "4770816-7");
            Assert.AreEqual(bruno.Name, null);
        }

        [Test]
        public void IncorrectNameNullString()
        {
            Person bruno = new Person(null, "4770816-7");
            Assert.AreEqual(bruno.Name, null);
        }
    }
}