using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPExtraWork
{
    public class ChefTest
    {
        [Test]
        public void TestChef()
        {
            Chef chef = new Chef("Gordon Ramsay");
            Console.WriteLine(chef.introduction());
            Console.WriteLine(chef.cook());
            Assert.Multiple(() =>
            {
                Assert.That(chef.NameChef, Is.EqualTo("Gordon Ramsay"));
                Assert.That(chef.introduction(), Is.EqualTo("Hi I am chef Gordon Ramsay"));
                Assert.That(chef.cook(), Is.EqualTo("Start cooking!"));
            });

            GreekChef greekChef = new GreekChef("Dimitris");
            Console.WriteLine(greekChef.introduction());
            Console.WriteLine(greekChef.cook());
            Assert.Multiple(() =>
            {
                Assert.That(greekChef.NameChef, Is.EqualTo("Dimitris"));
                Assert.That(greekChef.introduction(), Is.EqualTo("Hi I am greek chef Dimitris"));
                Assert.That(greekChef.cook(), Is.EqualTo("I am cooking gyros!"));
            });

            ItalianChef italianChef = new ItalianChef("Giovanni", 45);
            Console.WriteLine(italianChef.introduction());
            Console.WriteLine(italianChef.cook());
            italianChef.introduction();
            italianChef.cook();

            Assert.Multiple(() => {
                Assert.That(italianChef.NameChef, Is.EqualTo("Giovanni"));
                Assert.That(italianChef.Age, Is.EqualTo(45));
                Assert.That(italianChef.introduction(), Is.EqualTo("Hi I am chef Giovanni"));
                Assert.That(italianChef.cook(), Is.EqualTo("I am cooking pasta!"));
            });
        }
    }
}
