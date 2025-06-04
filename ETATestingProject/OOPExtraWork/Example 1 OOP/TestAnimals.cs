using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPExtraWork
{
    public class TestAnimals
    {
        [Test]
        public void TestAnimal()
        {
            Dog dog = new Dog("Azorel", 3, "Buldog");
            Assert.Multiple(() =>
            {
                Assert.That(dog.Name, Is.EqualTo("Azorel"));
                Assert.That(dog.Age, Is.EqualTo(3));
                Assert.That(dog.Breed, Is.EqualTo("Buldog"));
                Assert.That(dog.eat(), Is.EqualTo("Hi my name is Azorel and I am eating dog food"));
                Assert.That(dog.walk(), Is.EqualTo("Hi my name is Azorel, I am 3 years old and I am walking like a dog!"));
            });
        }

        [Test]

        public void DuckTest()
        {
            Duck duck = new Duck("Donald", 4);
            Assert.Multiple(() =>
            {
                Assert.That(duck.Name, Is.EqualTo("Donald"));
                Assert.That(duck.Age, Is.EqualTo(4));
                Assert.That(duck.eat(), Is.EqualTo("Hi my name is Donald, I am 4 years old and I am eating duck food"));
                Assert.That(duck.fly(), Is.EqualTo("I am flying like a duck"));
            });


        }
    }
}

