using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Chapter12_LinqToOther.Test
{
    [TestFixture]
    public class Tests
    {
        private static readonly IEnumerable<int> Sample = Enumerable.Range(0, 100);

        [Test]
        public void NullSource_ThrowsArgumentNullException()
        {
            IEnumerable<int> source = null;
            Assert.Throws<ArgumentNullException>(() => source.RandomElement(new Random()));
        }

        [Test]
        public void NullRandom_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Sample.RandomElement(null));
        }

        [Test]
        public void EmptyListSource_ThrowsInvalidOperationException()
        {
            IEnumerable<int> source = new List<int>();
            Assert.Throws<InvalidOperationException>(() => source.RandomElement(new Random()));
        }

        [Test]
        public void EmptyLazySource_ThrowsInvalidOperationException()
        {
            IEnumerable<int> source = Enumerable.Range(0, 0);
            Assert.Throws<InvalidOperationException>(() => source.RandomElement(new Random()));
        }

        [Test]
        public void ListSource_GivesReasonableDistribution()
        {
            VerifyDistribution(Sample.ToList());
        }

        [Test]
        public void CollectionSource_GivesReasonableDistribution()
        {
            VerifyDistribution(new List<int>(Sample));
        }

        [Test]
        public void GenericCollectionSource_GivesReasonableDistribution()
        {
            VerifyDistribution(Sample);
        }

        public void VerifyDistribution(IEnumerable<int> source)
        {
            var random = new Random();
            // Take 100,000 samples... each value should come up *roughly* 1000 times
            var groups = Enumerable.Range(0, 100000)
                .Select(x => source.RandomElement(random))
                .GroupBy(y => y)
                .ToList();//Only do it once
            // First check there actually *were* 100 groups (i.e. every value came up at least once)
            Assert.AreEqual(100, groups.Count());
            foreach (var group in groups)
            {
                Assert.That(group.Count(), Is.InRange(800, 1200), "Count for " + group.Key);
            }
        }
    }
}
