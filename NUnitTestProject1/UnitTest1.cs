using NUnit.Framework;
using System;
using System.IO;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test] /// Test with valid input and known result
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                
                /// Fixed input 
                Console.WriteLine(RomanNumeralGenerator.Program.generate(3999));
                /// Expected output
                string Expected = "MMMCMXCIX";

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [Test] /// Test with 0 input, expects error
        public void Test2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                /// Fixed input 
                Console.WriteLine(RomanNumeralGenerator.Program.generate(0));
                /// Expected output
                string Expected = "Please enter a number between 1 and 3999";

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [Test] /// Test with 4000 input, expects error
        public void Test3()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                /// Fixed input 
                Console.WriteLine(RomanNumeralGenerator.Program.generate(4000));
                /// Expected output
                string Expected = "Please enter a number between 1 and 3999";

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [Test] /// Test with negative value, expects error
        public void Test4()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                /// Fixed input 
                Console.WriteLine(RomanNumeralGenerator.Program.generate(-1));
                /// Expected output
                string Expected = "Please enter a number between 1 and 3999";

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}