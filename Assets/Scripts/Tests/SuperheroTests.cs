using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using SaveMeNow;

namespace Tests
{
    public class SuperheroTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestSuperheroHasPower()
        {
            Superhero CaptainCanine = new Superhero("Captain Canine", new List<Power> {
                new Power("Cats", -10),
                new Power("BarkBlast", +5)
            });

            Assert.IsTrue(CaptainCanine.HasPower("Cats"));
            Assert.IsTrue(CaptainCanine.HasPower("BarkBlast"));
            Assert.IsFalse(CaptainCanine.HasPower("LaserPointer"));
        }
    }
}
