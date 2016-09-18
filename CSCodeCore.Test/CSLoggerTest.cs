using NUnit.Framework;
using CSLogger.Extension_Classes;
using System.IO;
using System;
using System.Collections.Generic;

namespace CSCodeCore.Test
{
    [TestFixture]
    public class CSLoggerTest
    {
        [Test]
        public void VerifyBooleanExtension_WriteToConsole()
        {
            var isTrue = true;
            isTrue.WriteToConsole();
        }

        [Test]
        public void VerifyIntegerExtension_WriteToConsole()
        {
            var i = 10;
            i.WriteToConsole();
        }

        [Test]
        public void VerifyStringExtension_WriteToConsole()
        {
            var s = "string";
            s.WriteToConsole();
        }

        [Test]
        public void VerifyDoubleExtension_WriteToConsole()
        {
            var test = 0.0;
            test.WriteToConsole();
        }

        [Test]
        public void VerifyEnumerableExtension_WriteToConsole()
        {
            var listOfInt = new List<int>{ 1, 2, 3, 4, 5, 6 };
            var listOfString = new List<string> { "a", "c", "d" };

            listOfInt.WriteToConsole();
            listOfString.WriteToConsole();
        }
    }
}
