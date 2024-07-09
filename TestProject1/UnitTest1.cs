using NumberToWors_WordToNumber;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using NumberToWord_WordToNumber;
using NumberToWord_WordToNumber.Controllers;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            NumberToWordController cd1 = new NumberToWordController();
            WordToNumberController cd2 = new WordToNumberController();


            Assert.AreEqual("one dollars", cd1.convertN(1));
            Assert.AreEqual(1, cd2.convertW("one dollars"));



            Assert.Pass();
        }
        [Test]
        public void Test2()
        {

            NumberToWordController cd1 = new NumberToWordController();
            WordToNumberController cd2 = new WordToNumberController();


            Assert.AreEqual("one hundred dollars", cd1.convertN(100));
            Assert.AreEqual(100, cd2.convertW("one hundred dollars"));



            Assert.Pass();
        }

        [Test]
        public void Test3()
        {

            NumberToWordController cd1 = new NumberToWordController();
            WordToNumberController cd2 = new WordToNumberController();


            Assert.AreEqual("Invalid input", cd1.convertN(1999999999));
            Assert.AreEqual("Invalid input", cd2.convertW("one aksvdjagwd dollars"));



            Assert.Pass();
        }
    }
}