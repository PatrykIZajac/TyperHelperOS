using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TyperHelper;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void leagueStrengthTestMethod()
        {
            League testLeague = new League();

            //logika

            TyperForm testForm = new TyperForm();
            double actual = testForm.leagueStrength(testLeague);
            Assert.AreEqual(expected, actual, 0.001, "Błędne obliczenia!");
            
        }

        [TestMethod]
        public void teamStrengthTestMethod()
        {
            Teams testTeam = new Teams();
            TyperForm testForm = new TyperForm();

            //logika
            double actual = testForm.teamStrength(testTeam);
            Assert.AreEqual(expected, actual, 0.01, "Błędne obliczenia");
        }

        [TestMethod]
        public void chanceTestMethod()
        {
            //logika

            TyperForm testForm = new TyperForm();
            //przewidywana wartosc

            double leagueStrengthData = testForm.leagueStrength(testLeague);
            double actual = testForm.Chance(testTeam,leagueStrengthData);

            Assert.AreEqual(expected, actual, 0.001, "Błędne obliczenia");
        }

    }
}
