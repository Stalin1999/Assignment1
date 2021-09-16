using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_returns_all_elements_in_stream_of_int_1_and_2 ()
        {
            //Arrange
            IEnumerable<IEnumerable<int>> outerlist = new [] { new[] {1, 2}, new [] {1, 2} };

            //Act
            IEnumerable<int> actual = Iterators.Flatten(outerlist);

            //Assert
            IEnumerable<int> expected = new [] {1, 2, 1, 2};

            Assert.Equal(expected, actual);
        }

        public static bool Even(int i)
        {
            return i % 2 == 0;
        }

        [Fact]
        public void Filter_returns_all_even_numbers_based_on_predicate_even()
        {
            //Arrange
            Predicate<int> even = Even;
            IEnumerable<int> arranged = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9};

            //Act
            IEnumerable<int> actual = Iterators.Filter(arranged, even);

            //Assert
            IEnumerable<int> expected = new [] {2, 4, 6, 8};
            Assert.Equal(expected, actual);
            
        }
    }
}
