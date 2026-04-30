using Combinations;

namespace CombinationsTest
{
    public class Tests
    {
        Class1 sut;
        [SetUp]
        public void Setup()
        {
            sut = new Class1();
        }

        [Test]
        public void Test1()
        {
            int n = 4;
            int k = 2;
            List< List<int> > expected = new List< List<int> >();
            expected.Add(new List<int> { 1, 2 });
            expected.Add(new List<int> { 1, 3 });
            expected.Add(new List<int> { 1, 4 });
            expected.Add(new List<int> { 2, 3 });
            expected.Add(new List<int> { 2, 4 });
            expected.Add(new List<int> { 3, 4 });

            var result = sut.combine(n, k);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            int n = 1;
            int k = 1;
            List<List<int>> expected = new List<List<int>>();
            expected.Add(new List<int> { 1 });

            var result = sut.combine(n, k);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}