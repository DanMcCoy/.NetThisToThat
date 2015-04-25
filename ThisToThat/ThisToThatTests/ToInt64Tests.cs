﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToInt64Tests
    {


        /* 
        SByte to Int64: Test omitted
        There is a predefined implicit conversion from SByte to Int64
        */

        /* 
        Byte to Int64: Test omitted
        There is a predefined implicit conversion from Byte to Int64
        */

        /* 
        Int16 to Int64: Test omitted
        There is a predefined implicit conversion from Int16 to Int64
        */

        /* 
        UInt16 to Int64: Test omitted
        There is a predefined implicit conversion from UInt16 to Int64
        */

        /* 
        Int32 to Int64: Test omitted
        There is a predefined implicit conversion from Int32 to Int64
        */

        /* 
        UInt32 to Int64: Test omitted
        There is a predefined implicit conversion from UInt32 to Int64
        */


        /// <summary>
        /// Makes multiple UInt64 to Int64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt64 tests")]
        public void TestUInt64ToInt64OrDefault()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            Int64? result = source.ToInt64OrDefault(86L);
            Assert.AreEqual(0L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));
            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt64OrDefault(86L);
            Assert.AreEqual(42L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt64OrDefault(86L);
            // Here we would expect this conversion to fail (and return the default value of 86L), 
            // since the source type's maximum value (1.84467440737096E+19) is greater than the target type's maximum value (9.22337203685478E+18).
            Assert.AreEqual(86L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

        }


        /// <summary>
        /// Makes multiple UInt64 to nullable Int64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt64 tests")]
        public void TestUInt64ToInt64Nullable()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            Int64? result = source.ToInt64Nullable();
            Assert.AreEqual(0L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt64Nullable();
            Assert.AreEqual(42L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (1.84467440737096E+19) is greater than the target type's maximum value (9.22337203685478E+18).
            Assert.IsNull(result);

        }


        /// <summary>
        /// Makes multiple Single to Int64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt64 tests")]
        public void TestSingleToInt64OrDefault()
        {
            // Test conversion of source type minimum value
            Single source = Single.MinValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            Int64? result = source.ToInt64OrDefault(86L);
            // Here we would expect this conversion to fail (and return the default value of 86L), 
            // since the source type's minimum value (-3.40282346638529E+38) is less than the target type's minimum value (-9.22337203685478E+18).
            Assert.AreEqual(86L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type value 42 to target type
            source = 42f;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToInt64OrDefault(86L);
            Assert.AreEqual(42L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type maximum value
            source = Single.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToInt64OrDefault(86L);
            // Here we would expect this conversion to fail (and return the default value of 86L), 
            // since the source type's maximum value (3.40282346638529E+38) is greater than the target type's maximum value (9.22337203685478E+18).
            Assert.AreEqual(86L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

        }


        /// <summary>
        /// Makes multiple Single to nullable Int64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt64 tests")]
        public void TestSingleToInt64Nullable()
        {
            // Test conversion of source type minimum value
            Single source = Single.MinValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            Int64? result = source.ToInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-3.40282346638529E+38) is less than the target type's minimum value (-9.22337203685478E+18).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42f;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToInt64Nullable();
            Assert.AreEqual(42L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type maximum value
            source = Single.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (3.40282346638529E+38) is greater than the target type's maximum value (9.22337203685478E+18).
            Assert.IsNull(result);

        }


        /// <summary>
        /// Makes multiple Double to Int64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt64 tests")]
        public void TestDoubleToInt64OrDefault()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            Int64? result = source.ToInt64OrDefault(86L);
            // Here we would expect this conversion to fail (and return the default value of 86L), 
            // since the source type's minimum value (-1.79769313486232E+308) is less than the target type's minimum value (-9.22337203685478E+18).
            Assert.AreEqual(86L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToInt64OrDefault(86L);
            Assert.AreEqual(42L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToInt64OrDefault(86L);
            // Here we would expect this conversion to fail (and return the default value of 86L), 
            // since the source type's maximum value (1.79769313486232E+308) is greater than the target type's maximum value (9.22337203685478E+18).
            Assert.AreEqual(86L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

        }


        /// <summary>
        /// Makes multiple Double to nullable Int64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt64 tests")]
        public void TestDoubleToInt64Nullable()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            Int64? result = source.ToInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-1.79769313486232E+308) is less than the target type's minimum value (-9.22337203685478E+18).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToInt64Nullable();
            Assert.AreEqual(42L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (1.79769313486232E+308) is greater than the target type's maximum value (9.22337203685478E+18).
            Assert.IsNull(result);

        }


        /// <summary>
        /// Makes multiple Decimal to Int64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt64 tests")]
        public void TestDecimalToInt64OrDefault()
        {
            // Test conversion of source type minimum value
            Decimal source = Decimal.MinValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            Int64? result = source.ToInt64OrDefault(86L);
            // Here we would expect this conversion to fail (and return the default value of 86L), 
            // since the source type's minimum value (-7.92281625142643E+28) is less than the target type's minimum value (-9.22337203685478E+18).
            Assert.AreEqual(86L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type value 42 to target type
            source = 42m;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToInt64OrDefault(86L);
            Assert.AreEqual(42L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type maximum value
            source = Decimal.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToInt64OrDefault(86L);
            // Here we would expect this conversion to fail (and return the default value of 86L), 
            // since the source type's maximum value (7.92281625142643E+28) is greater than the target type's maximum value (9.22337203685478E+18).
            Assert.AreEqual(86L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

        }


        /// <summary>
        /// Makes multiple Decimal to nullable Int64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt64 tests")]
        public void TestDecimalToInt64Nullable()
        {
            // Test conversion of source type minimum value
            Decimal source = Decimal.MinValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            Int64? result = source.ToInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-7.92281625142643E+28) is less than the target type's minimum value (-9.22337203685478E+18).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42m;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToInt64Nullable();
            Assert.AreEqual(42L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type maximum value
            source = Decimal.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (7.92281625142643E+28) is greater than the target type's maximum value (9.22337203685478E+18).
            Assert.IsNull(result);

        }


    }
}