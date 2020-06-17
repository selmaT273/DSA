using System;
using System.Collections.Generic;
using Challenges;
using Xunit;

namespace Challenges.Tests
{
    public class LeftJoinTests
    {
        [Fact]
        public void CanLeftJoinTest()
        {
            var synonyms = new Dictionary<string, string>()
            {
                { "can", "able" },
                { "will", "compliant" },
                { "wet", "moist" }
            };

            var antonyms = new Dictionary<string, string>()
            {
                { "can", "cant" },
                { "wet", "dry" },
                { "rise", "fall" }
            };

            string result = LeftJoin.PerformLeftJoin(synonyms, antonyms);

            Assert.Equal("[can, able, cant], \n[will, compliant, NULL], \n[wet, moist, dry] \n", result);
        }
    }
}
