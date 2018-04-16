﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTestValues.Tests.ShouldExtensions;

namespace RandomTestValues.Tests.ValuesTests
{
    [TestClass]
    public class DateTimeOffsetShould
    {
        [TestMethod]
        public void GiveUniqueValuesForEachCall()
        {
            var offset1 = RandomValue.DateTimeOffset();
            var offset2 = RandomValue.DateTimeOffset();

            offset1.ShouldNotEqual(offset2);
        }
    }
}