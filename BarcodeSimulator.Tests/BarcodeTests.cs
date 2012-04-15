using System.Collections.Generic;
using NUnit.Framework;

namespace BarcodeSimulator.Tests
{

    [TestFixture]
    public class BarcodeTests
    {

        [Test]
        public void IsUpcA_ValidUpcACodes_ReturnsTrue([Values("036000291452", "074312058004")] string code)
        {
            Assert.IsTrue(Barcode.IsUpcA(code), "Checking code " + code);
        }

        [Test]
        public void IsUpcA_InvalidUpcACodes_ReturnsTrue([Values("036000291459", "074312058009")] string code)
        {
            Assert.IsFalse(Barcode.IsUpcA(code), "Checking code " + code);
        }

        [Test(Description = "Make sure the codes are identified as invalid and no exceptions are thrown.")]
        public void IsUpcA_RightLengthButContainsLetters_ReturnsFalse([Values("X36000291459", "07431205800B")] string code) {
            Assert.IsFalse(Barcode.IsEan13(code));
        }

        [Test]
        public void IsEan13_ValidEan13Codes_ReturnsTrue(
            [Values("4006381333931", "4005808515608" /* Nivea cream */, "5030917071027" /* Call of Duty MW2 Euro */)] string code)
        {
            Assert.IsTrue(Barcode.IsEan13(code));
        }

        [Test(Description = "Make sure the codes are identified as invalid and no exceptions are thrown.")]
        public void IsEan13_RightLengthButContainsLetters_ReturnsFalse([Values("400580851560X", "B030917071027")] string code)
        {
            Assert.IsFalse(Barcode.IsEan13(code));
        }

        [Test]
        public void IsEan13_ValidEan8Codes_ReturnsTrue([Values("73123453", "96385074", "73513537")] string code)
        {
            Assert.IsTrue(Barcode.IsEan8(code));
        }

        public void IsCode39_ValidCode39_ReturnsTrue([Values("*HELLO*", "*THIS IS CODE-39*")] string code)
        {
            Assert.IsTrue(Barcode.IsCode39(code));
        }

        [Test]
        public void IsCode39_InvalidCode39_ReturnsFalse([Values("*MISSING END", "MISSING BEGINNING*", "*LOWER case*", "*INVALID CHAR ÅÄÖ*", "*INVALID SYMBOL £*")] string code)
        {
            Assert.IsFalse(Barcode.IsCode39(code));
        }

        [Test]
        public void GetTypeName()
        {
            var expectations = new Dictionary<string, string>
                                   {
                                       {"036000291452", "UPC-A"},
                                       {"074312058004", "UPC-A"},
                                       {"5030917071027", "EAN-13"},
                                       {"4005808515608", "EAN-13"},
                                       {"73123453", "EAN-8"},
                                       {"73513537", "EAN-8"}
                                   };

            foreach (var expectation in expectations)
                Assert.AreEqual(expectation.Value, Barcode.GetTypeName(expectation.Key), "Code {0} should be {1}", expectation.Key, expectation.Value);
        }
    }
}