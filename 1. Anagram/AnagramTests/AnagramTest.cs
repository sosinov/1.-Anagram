namespace AnagramTests
{
    [TestClass]
    public class AnagramTest
    {
        [DataRow("", "")]
        [DataRow("Hello!", "olleH!")]
        [DataRow("a1bcd efg!h", "d1cba hgf!e")]
        [DataRow("  a1bcd    efg!h", "  d1cba    hgf!e")]
        [DataRow("hello world", "olleh dlrow")]
        [DataRow("Hello    world", "olleH    dlrow")]
        [DataRow("1 world", "1 dlrow")]
        [DataRow("H1llo world", "o1llH dlrow")]
        [DataRow("H1llo w2rld", "o1llH d2lrw")]
        [DataRow("1ello worl4", "1olle lrow4")]
        [DataRow("     H1llo world", "     o1llH dlrow")]
        [DataRow("H1llo      w2rld     ", "o1llH      d2lrw     ")]
        [DataRow("1ello           worl4", "1olle           lrow4")]
        [DataRow("12     345 352   ", "12     345 352   ")]
        [DataRow("12hellO     345 352   ", "12Olleh     345 352   ")]
        [DataRow("Hello world", "olleH dlrow")]
        [DataRow("___ --- ////     15972*963741 allo 321 ///", "___ --- ////     15972*963741 olla 321 ///")]
        [DataRow("/!*-+)(&#$%    Hello 153 86 _0()8?$5", "/!*-+)(&#$%    olleH 153 86 _0()8?$5")]

        [DataTestMethod]
        public void Test_Different_Examples(string x, string expected)
        {
            AnagramClass obj = new AnagramClass(x);

            string result = obj.Reverse();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "A null phrase was inappropriately allowed.")]
        public void NullConstructor()
        {
            AnagramClass testObject = new AnagramClass(null);
        }
    }
}