using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Jcd.DoWhenRun.Tests
{
    public class DoWhenRunExtensionsTests
    {
        [Fact]
        public void Do_Generic_Returns_Enumerable_Of_Same_Type_And_Does_Not_Enumerate()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            var enumerated = false;
            var result = ints.Do(_ => enumerated = true);
            Assert.False(enumerated);
            Assert.IsAssignableFrom<IEnumerable<int>>(result);
        }
        
        [Fact]
        public void Do_Returns_Enumerable_And_Does_Not_Enumerate()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            IEnumerable enumerable = ints;
            var enumerated = false;
            var result = enumerable.Do(_ => enumerated = true);
            Assert.False(enumerated);
            Assert.IsAssignableFrom<IEnumerable>(result);
        }

        [Fact]
        public void Run_Generic_Forces_Enumeration()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            var enumerated = false;
            ints.Do(_ => enumerated = true).Run();
            Assert.True(enumerated);
        }
        
        [Fact]
        public void Run_Forces_Enumeration()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            IEnumerable enumerable = ints;
            var enumerated = false;
            enumerable.Do(_ => enumerated = true).Run();
            Assert.True(enumerated);
        }

        [Fact]
        public void DoWhen_Generic_On_Only_Even_Indexed_Items_Captures_The_Values_When_Run_Executed()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            var expected = new List<int>(new[] { 1, 3, 5 });

            var result = new List<int>();
            ints.DoWhen((i, _) => i % 2 == 0, 
                (_, item) => result.Add(item))
                .Run();
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void DoWhen_Generic_On_Odd_Items_Captures_The_Values_When_Run_Executed()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            var expected = new List<int>(new[] { 1, 3, 5 });

            var result = new List<int>();
            ints.DoWhen((item) => item % 2 == 1, 
                    (_, item) => result.Add(item))
                .Run();
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void DoWhen_On_Only_Even_Indexed_Items_Captures_The_Values_When_Run_Executed()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            var enumerable = ints as IEnumerable;
            var expected = new List<int>(new[] { 1, 3, 5 });

            var result = new List<int>();
            enumerable.DoWhen((i, _) => i % 2 == 0, 
                    (_, item) => result.Add((int)item))
                .Run();
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void DoWhen_On_Odd_Items_Captures_The_Values_When_Run_Executed()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            var enumerable = ints as IEnumerable;
            IEnumerable expected = new List<int>(new[] { 1, 3, 5 });

            var result = new List<int>();
            enumerable.DoWhen((item) => (int)item % 2 == 1, 
                    (_, item) => result.Add((int)item))
                .Run();
            Assert.Equal(expected,result);
        }
    }
}