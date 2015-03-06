using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral;

namespace RomanNumeralTests
{
    [TestClass]
    public class EncoderTests
    {
        [TestMethod]
        public void Encoder_1_Returns_I()
        {
            var encoder = new Encoder();
            var number = 1;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("I", actual);
        }

        [TestMethod]
        public void Encoder_2_Returns_II()
        {
            var encoder = new Encoder();
            var number = 2;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("II", actual);
        }

        [TestMethod]
        public void Encoder_4_Returns_IV()
        {
            var encoder = new Encoder();
            var number = 4;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("IV", actual);
        }

        [TestMethod]
        public void Encoder_5_Returns_V()
        {
            var encoder = new Encoder();
            var number = 5;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("V", actual);
        }

        [TestMethod]
        public void Encoder_8_Returns_VIII()
        {
            var encoder = new Encoder();
            var number = 8;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("VIII", actual);
        }

        [TestMethod]
        public void Encoder_9_Returns_IX()
        {
            var encoder = new Encoder();
            var number = 9;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("IX", actual);
        }

        [TestMethod]
        public void Encoder_10_Returns_X()
        {
            var encoder = new Encoder();
            var number = 10;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("X", actual);
        }

        [TestMethod]
        public void Encoder_14_Returns_XIV()
        {
            var encoder = new Encoder();
            var number = 14;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("XIV", actual);
        }

        [TestMethod]
        public void Encoder_18_Returns_XVIII()
        {
            var encoder = new Encoder();
            var number = 18;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("XVIII", actual);
        }

        [TestMethod]
        public void Encoder_19_Returns_XIX()
        {
            var encoder = new Encoder();
            var number = 19;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("XIX", actual);
        }

        [TestMethod]
        public void Encoder_69_Returns_LXIX()
        {
            var encoder = new Encoder();
            var number = 69;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("LXIX", actual);
        }

        [TestMethod]
        public void Encoder_99_Returns_XCIX()
        {
            var encoder = new Encoder();
            var number = 99;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("XCIX", actual);
        }

        [TestMethod]
        public void Encoder_100_Returns_C()
        {
            var encoder = new Encoder();
            var number = 100;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("C", actual);
        }

        [TestMethod]
        public void Encoder_455_Returns_CDLV()
        {
            var encoder = new Encoder();
            var number = 455;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("CDLV", actual);
        }

        [TestMethod]
        public void Encoder_999_Returns_CMXCIX()
        {
            var encoder = new Encoder();
            var number = 999;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("CMXCIX", actual);
        }

        [TestMethod]
        public void Encoder_1234_Returns_MCCXXXIV()
        {
            var encoder = new Encoder();
            var number = 1234;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("MCCXXXIV", actual);
        }

        [TestMethod]
        public void Encoder_3999_Returns_MMMCMXCIX()
        {
            var encoder = new Encoder();
            var number = 3999;

            var actual = encoder.ToRoman(number);

            Assert.AreEqual("MMMCMXCIX", actual);
        }

    }
}
