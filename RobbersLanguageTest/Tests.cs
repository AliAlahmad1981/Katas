using System;
using RobbersLanguageSim;
using Xunit;

namespace RobbersLanguageTest
{
    public class Tests
    {
        // TODO l�gg till fler tester f�r att underl�tta ditt kodande
        [Fact]
        public void ApaTest()
        {
            string result = RobbersLanguage.Encode("apa");

            Assert.Equal("apopa", result);
        }
    }
}
