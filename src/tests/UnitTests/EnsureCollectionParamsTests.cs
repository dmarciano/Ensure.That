using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class EnsureCollectionParamsTests : UnitTestBase
    {
        [Fact]
        public void HasItems_WhenEmptyIReadonlyCollection_ThrowsArgumentException()
        {
            IReadOnlyCollection<int> emptyCollection = new ReadOnlyCollection<int>(new List<int>());

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyCollection, ParamName),
                () => EnsureArg.HasItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyIReadOnlyCollection_ShouldNotThrow()
        {
            IReadOnlyCollection<int> collection = new ReadOnlyCollection<int>(new List<int> { 1, 2, 3 });

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(collection, ParamName),
                () => EnsureArg.HasItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyIReadOnlyList_ThrowsArgumentException()
        {
            IReadOnlyList<int> emptyList = new List<int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyList, ParamName),
                () => EnsureArg.HasItems(emptyList, ParamName),
                () => Ensure.That(emptyList, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyIReadOnlyList_ShouldNotThrow()
        {
            IReadOnlyList<int> collection = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(collection, ParamName),
                () => EnsureArg.HasItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyICollection_ThrowsArgumentException()
        {
            ICollection<int> emptyCollection = new Collection<int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyCollection, ParamName),
                () => EnsureArg.HasItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyICollection_ShouldNotThrow()
        {
            ICollection<int> collection = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(collection, ParamName),
                () => EnsureArg.HasItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyCollection_ThrowsArgumentException()
        {
            var emptyCollection = new Collection<int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyCollection, ParamName),
                () => EnsureArg.HasItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyCollection_ShouldNotThrow()
        {
            var collection = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(collection, ParamName),
                () => EnsureArg.HasItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullArray_ThrowsArgumentNullException()
        {
            var nullArray = null as int[];

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullArray, ParamName),
                () => EnsureArg.HasItems(nullArray, ParamName),
                () => Ensure.That(nullArray, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullCollection_ThrowsArgumentNullException()
        {
            var nullCollection = null as Collection<int>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullCollection, ParamName),
                () => EnsureArg.HasItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullICollection_ThrowsArgumentNullException()
        {
            var nullCollection = null as ICollection<int>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullCollection, ParamName),
                () => EnsureArg.HasItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullList_ThrowsArgumentNullException()
        {
            var nullList = null as List<int>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullList, ParamName),
                () => EnsureArg.HasItems(nullList, ParamName),
                () => Ensure.That(nullList, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullIList_ThrowsArgumentNullException()
        {
            var nullList = null as IList<int>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullList, ParamName),
                () => EnsureArg.HasItems(nullList, ParamName),
                () => Ensure.That(nullList, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullDictionary_ThrowsArgumentNullException()
        {
            var nullDictionary = null as Dictionary<int, string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullDictionary, ParamName),
                () => EnsureArg.HasItems(nullDictionary, ParamName),
                () => Ensure.That(nullDictionary, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullIDictionary_ThrowsArgumentNullException()
        {
            var nullDictionary = null as IDictionary<int, string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullDictionary, ParamName),
                () => EnsureArg.HasItems(nullDictionary, ParamName),
                () => Ensure.That(nullDictionary, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyArray_ThrowsArgumentException()
        {
            var emptyArray = new int[] { };

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyArray, ParamName),
                () => EnsureArg.HasItems(emptyArray, ParamName),
                () => Ensure.That(emptyArray, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyArray_ShouldNotThrow()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(values, ParamName),
                () => EnsureArg.HasItems(values, ParamName),
                () => Ensure.That(values, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyIList_ThrowsArgumentException()
        {
            IList<int> emptyList = new List<int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyList, ParamName),
                () => EnsureArg.HasItems(emptyList, ParamName),
                () => Ensure.That(emptyList, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyIList_ShouldNotThrow()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(values, ParamName),
                () => EnsureArg.HasItems(values, ParamName),
                () => Ensure.That(values, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyList_ThrowsArgumentException()
        {
            var emptyList = new List<int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyList, ParamName),
                () => EnsureArg.HasItems(emptyList, ParamName),
                () => Ensure.That(emptyList, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyList_ShouldNotThrow()
        {
            var values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(values, ParamName),
                () => EnsureArg.HasItems(values, ParamName),
                () => Ensure.That(values, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyIDictionary_ThrowsArgumentException()
        {
            IDictionary<string, int> emptyDict = new Dictionary<string, int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyDict, ParamName),
                () => EnsureArg.HasItems(emptyDict, ParamName),
                () => Ensure.That(emptyDict, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyIDictionary_ShouldNotThrow()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(dict, ParamName),
                () => EnsureArg.HasItems(dict, ParamName),
                () => Ensure.That(dict, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyDictionary_ThrowsArgumentException()
        {
            var emptyDict = new Dictionary<string, int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyDict, ParamName),
                () => EnsureArg.HasItems(emptyDict, ParamName),
                () => Ensure.That(emptyDict, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyDictionary_ShouldNotThrow()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(dict, ParamName),
                () => EnsureArg.HasItems(dict, ParamName),
                () => Ensure.That(dict, ParamName).HasItems());
        }

        [Fact]
        public void SizeIs_When_matching_length_of_array_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(values, values.Length, ParamName),
                () => EnsureArg.SizeIs(values, values.Length, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Length));
        }

        [Fact]
        public void SizeIs_When_non_matching_length_of_array_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3 };
            var expected = values.Length + 1;

            AssertSizeIsWrong(
                values.Length,
                expected,
                () => Ensure.Collection.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_List_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(values, values.Count, ParamName),
                () => EnsureArg.SizeIs(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_List_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.Collection.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_IList_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(values, values.Count, ParamName),
                () => EnsureArg.SizeIs(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_IList_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.Collection.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_Collection_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(values, values.Count, ParamName),
                () => EnsureArg.SizeIs(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_Collection_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.Collection.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_ICollection_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(values, values.Count, ParamName),
                () => EnsureArg.SizeIs(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_ICollection_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.Collection.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(dict, dict.Count, ParamName),
                () => EnsureArg.SizeIs(dict, dict.Count, ParamName),
                () => Ensure.That(dict, ParamName).SizeIs(dict.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count + 1;

            AssertSizeIsWrong(
                dict.Count,
                expected,
                () => Ensure.Collection.SizeIs(dict, expected, ParamName),
                () => EnsureArg.SizeIs(dict, expected, ParamName),
                () => Ensure.That(dict, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(dict, dict.Count, ParamName),
                () => EnsureArg.SizeIs(dict, dict.Count, ParamName),
                () => Ensure.That(dict, ParamName).SizeIs(dict.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count + 1;

            AssertSizeIsWrong(
                dict.Count,
                expected,
                () => Ensure.Collection.SizeIs(dict, expected, ParamName),
                () => EnsureArg.SizeIs(dict, expected, ParamName),
                () => Ensure.That(dict, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_Array_is_null_It_should_throw_ArgumentNullException()
        {
            int[] values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_ICollection_is_null_It_should_throw_ArgumentNullException()
        {
            ICollection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_Collection_is_null_It_should_throw_ArgumentNullException()
        {
            Collection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_IList_is_null_It_should_throw_ArgumentNullException()
        {
            IList<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_List_is_null_It_should_throw_ArgumentNullException()
        {
            List<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }



        #region SizeIsNot/SizeIsGt/Lt/Gte/Lte
        [Fact]
        public void SizeIsNot_When_matching_length_of_array_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsNot(values, values.Length-1, ParamName),
                () => EnsureArg.SizeIsNot(values, values.Length-1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(values.Length-1));
        }

        [Fact]
        public void SizeIsNot_When_non_matching_length_of_array_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3 };
            var expected = values.Length;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, values.Length),
                () => Ensure.Collection.SizeIsNot(values, expected, ParamName),
                () => EnsureArg.SizeIsNot(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(expected));
        }

        [Fact]
        public void SizeIsNot_When_matching_count_of_List_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsNot(values, values.Count-1, ParamName),
                () => EnsureArg.SizeIsNot(values, values.Count-1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(values.Count-1));
        }

        [Fact]
        public void SizeIsNot_When_non_matching_count_of_List_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsNot(values, expected, ParamName),
                () => EnsureArg.SizeIsNot(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(expected));
        }

        [Fact]
        public void SizeIsNot_When_matching_count_of_IList_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsNot(values, values.Count-1, ParamName),
                () => EnsureArg.SizeIsNot(values, values.Count-1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(values.Count-1));
        }

        [Fact]
        public void SizeIsNot_When_non_matching_count_of_IList_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsNot(values, expected, ParamName),
                () => EnsureArg.SizeIsNot(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(expected));
        }

        [Fact]
        public void SizeIsNot_When_matching_count_of_Collection_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsNot(values, values.Count-1, ParamName),
                () => EnsureArg.SizeIsNot(values, values.Count-1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(values.Count-1));
        }

        [Fact]
        public void SizeIsNot_When_non_matching_count_of_Collection_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsNot(values, expected, ParamName),
                () => EnsureArg.SizeIsNot(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(expected));
        }

        [Fact]
        public void SizeIsNot_When_matching_count_of_ICollection_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsNot(values, values.Count-1, ParamName),
                () => EnsureArg.SizeIsNot(values, values.Count-1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(values.Count-1));
        }

        [Fact]
        public void SizeIsNot_When_non_matching_count_of_ICollection_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsNot(values, expected, ParamName),
                () => EnsureArg.SizeIsNot(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(expected));
        }

        [Fact]
        public void SizeIsNot_When_matching_count_of_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsNot(dict, dict.Count-1, ParamName),
                () => EnsureArg.SizeIsNot(dict, dict.Count-1, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsNot(dict.Count-1));
        }

        [Fact]
        public void SizeIsNot_When_non_matching_count_of_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, dict.Count),
                () => Ensure.Collection.SizeIsNot(dict, expected, ParamName),
                () => EnsureArg.SizeIsNot(dict, expected, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsNot(expected));
        }

        [Fact]
        public void SizeIsNot_When_matching_count_of_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsNot(dict, dict.Count-1, ParamName),
                () => EnsureArg.SizeIsNot(dict, dict.Count-1, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsNot(dict.Count-1));
        }

        [Fact]
        public void SizeIsNot_When_non_matching_count_of_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsNot_Failed, expected, dict.Count),
                () => Ensure.Collection.SizeIsNot(dict, expected, ParamName),
                () => EnsureArg.SizeIsNot(dict, expected, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsNot(expected));
        }

        [Fact]
        public void SizeIsNot_When_Array_is_null_It_should_throw_ArgumentNullException()
        {
            int[] values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsNot(values, 1, ParamName),
                () => EnsureArg.SizeIsNot(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(1));
        }

        [Fact]
        public void SizeIsNot_When_ICollection_is_null_It_should_throw_ArgumentNullException()
        {
            ICollection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsNot(values, 1, ParamName),
                () => EnsureArg.SizeIsNot(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(1));
        }

        [Fact]
        public void SizeIsNot_When_Collection_is_null_It_should_throw_ArgumentNullException()
        {
            Collection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsNot(values, 1, ParamName),
                () => EnsureArg.SizeIsNot(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(1));
        }

        [Fact]
        public void SizeIsNot_When_IList_is_null_It_should_throw_ArgumentNullException()
        {
            IList<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsNot(values, 1, ParamName),
                () => EnsureArg.SizeIsNot(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(1));
        }

        [Fact]
        public void SizeIsNot_When_List_is_null_It_should_throw_ArgumentNullException()
        {
            List<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsNot(values, 1, ParamName),
                () => EnsureArg.SizeIsNot(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(1));
        }

        [Fact]
        public void SizeIsNot_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsNot(values, 1, ParamName),
                () => EnsureArg.SizeIsNot(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(1));
        }

        [Fact]
        public void SizeIsNot_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsNot(values, 1, ParamName),
                () => EnsureArg.SizeIsNot(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsNot(1));
        }

        [Fact]
        public void SizeIsGt_When_matching_length_of_array_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGt(values, values.Length - 1, ParamName),
                () => EnsureArg.SizeIsGt(values, values.Length - 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(values.Length - 1));
        }

        [Fact]
        public void SizeIsGt_When_non_matching_length_of_array_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3 };
            var expected = values.Length;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, values.Length),
                () => Ensure.Collection.SizeIsGt(values, expected, ParamName),
                () => EnsureArg.SizeIsGt(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(expected));
        }

        [Fact]
        public void SizeIsGt_When_matching_count_of_List_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGt(values, values.Count - 1, ParamName),
                () => EnsureArg.SizeIsGt(values, values.Count - 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(values.Count - 1));
        }

        [Fact]
        public void SizeIsGt_When_non_matching_count_of_List_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsGt(values, expected, ParamName),
                () => EnsureArg.SizeIsGt(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(expected));
        }

        [Fact]
        public void SizeIsGt_When_matching_count_of_IList_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGt(values, values.Count - 1, ParamName),
                () => EnsureArg.SizeIsGt(values, values.Count - 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(values.Count - 1));
        }

        [Fact]
        public void SizeIsGt_When_non_matching_count_of_IList_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsGt(values, expected, ParamName),
                () => EnsureArg.SizeIsGt(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(expected));
        }

        [Fact]
        public void SizeIsGt_When_matching_count_of_Collection_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGt(values, values.Count - 1, ParamName),
                () => EnsureArg.SizeIsGt(values, values.Count - 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(values.Count - 1));
        }

        [Fact]
        public void SizeIsGt_When_non_matching_count_of_Collection_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsGt(values, expected, ParamName),
                () => EnsureArg.SizeIsGt(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(expected));
        }

        [Fact]
        public void SizeIsGt_When_matching_count_of_ICollection_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGt(values, values.Count - 1, ParamName),
                () => EnsureArg.SizeIsGt(values, values.Count - 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(values.Count - 1));
        }

        [Fact]
        public void SizeIsGt_When_non_matching_count_of_ICollection_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsGt(values, expected, ParamName),
                () => EnsureArg.SizeIsGt(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(expected));
        }

        [Fact]
        public void SizeIsGt_When_matching_count_of_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGt(dict, dict.Count - 1, ParamName),
                () => EnsureArg.SizeIsGt(dict, dict.Count - 1, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsGt(dict.Count - 1));
        }

        [Fact]
        public void SizeIsGt_When_non_matching_count_of_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, dict.Count),
                () => Ensure.Collection.SizeIsGt(dict, expected, ParamName),
                () => EnsureArg.SizeIsGt(dict, expected, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsGt(expected));
        }

        [Fact]
        public void SizeIsGt_When_matching_count_of_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGt(dict, dict.Count - 1, ParamName),
                () => EnsureArg.SizeIsGt(dict, dict.Count - 1, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsGt(dict.Count - 1));
        }

        [Fact]
        public void SizeIsGt_When_non_matching_count_of_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGt_Failed, expected, dict.Count),
                () => Ensure.Collection.SizeIsGt(dict, expected, ParamName),
                () => EnsureArg.SizeIsGt(dict, expected, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsGt(expected));
        }

        [Fact]
        public void SizeIsGt_When_Array_is_null_It_should_throw_ArgumentNullException()
        {
            int[] values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGt(values, 1, ParamName),
                () => EnsureArg.SizeIsGt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(1));
        }

        [Fact]
        public void SizeIsGt_When_ICollection_is_null_It_should_throw_ArgumentNullException()
        {
            ICollection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGt(values, 1, ParamName),
                () => EnsureArg.SizeIsGt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(1));
        }

        [Fact]
        public void SizeIsGt_When_Collection_is_null_It_should_throw_ArgumentNullException()
        {
            Collection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGt(values, 1, ParamName),
                () => EnsureArg.SizeIsGt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(1));
        }

        [Fact]
        public void SizeIsGt_When_IList_is_null_It_should_throw_ArgumentNullException()
        {
            IList<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGt(values, 1, ParamName),
                () => EnsureArg.SizeIsGt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(1));
        }

        [Fact]
        public void SizeIsGt_When_List_is_null_It_should_throw_ArgumentNullException()
        {
            List<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGt(values, 1, ParamName),
                () => EnsureArg.SizeIsGt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(1));
        }

        [Fact]
        public void SizeIsGt_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGt(values, 1, ParamName),
                () => EnsureArg.SizeIsGt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(1));
        }

        [Fact]
        public void SizeIsGt_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGt(values, 1, ParamName),
                () => EnsureArg.SizeIsGt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGt(1));
        }

        [Fact]
        public void SizeIsLt_When_matching_length_of_array_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLt(values, values.Length + 1, ParamName),
                () => EnsureArg.SizeIsLt(values, values.Length + 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(values.Length + 1));
        }

        [Fact]
        public void SizeIsLt_When_non_matching_length_of_array_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3 };
            var expected = values.Length;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, values.Length),
                () => Ensure.Collection.SizeIsLt(values, expected, ParamName),
                () => EnsureArg.SizeIsLt(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(expected));
        }

        [Fact]
        public void SizeIsLt_When_matching_count_of_List_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLt(values, values.Count + 1, ParamName),
                () => EnsureArg.SizeIsLt(values, values.Count + 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(values.Count + 1));
        }

        [Fact]
        public void SizeIsLt_When_non_matching_count_of_List_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsLt(values, expected, ParamName),
                () => EnsureArg.SizeIsLt(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(expected));
        }

        [Fact]
        public void SizeIsLt_When_matching_count_of_IList_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLt(values, values.Count + 1, ParamName),
                () => EnsureArg.SizeIsLt(values, values.Count + 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(values.Count + 1));
        }

        [Fact]
        public void SizeIsLt_When_non_matching_count_of_IList_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsLt(values, expected, ParamName),
                () => EnsureArg.SizeIsLt(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(expected));
        }

        [Fact]
        public void SizeIsLt_When_matching_count_of_Collection_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLt(values, values.Count + 1, ParamName),
                () => EnsureArg.SizeIsLt(values, values.Count + 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(values.Count + 1));
        }

        [Fact]
        public void SizeIsLt_When_non_matching_count_of_Collection_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsLt(values, expected, ParamName),
                () => EnsureArg.SizeIsLt(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(expected));
        }

        [Fact]
        public void SizeIsLt_When_matching_count_of_ICollection_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLt(values, values.Count + 1, ParamName),
                () => EnsureArg.SizeIsLt(values, values.Count + 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(values.Count + 1));
        }

        [Fact]
        public void SizeIsLt_When_non_matching_count_of_ICollection_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, values.Count),
                () => Ensure.Collection.SizeIsLt(values, expected, ParamName),
                () => EnsureArg.SizeIsLt(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(expected));
        }

        [Fact]
        public void SizeIsLt_When_matching_count_of_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLt(dict, dict.Count + 1, ParamName),
                () => EnsureArg.SizeIsLt(dict, dict.Count + 1, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsLt(dict.Count + 1));
        }

        [Fact]
        public void SizeIsLt_When_non_matching_count_of_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, dict.Count),
                () => Ensure.Collection.SizeIsLt(dict, expected, ParamName),
                () => EnsureArg.SizeIsLt(dict, expected, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsLt(expected));
        }

        [Fact]
        public void SizeIsLt_When_matching_count_of_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLt(dict, dict.Count + 1, ParamName),
                () => EnsureArg.SizeIsLt(dict, dict.Count + 1, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsLt(dict.Count + 1));
        }

        [Fact]
        public void SizeIsLt_When_non_matching_count_of_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLt_Failed, expected, dict.Count),
                () => Ensure.Collection.SizeIsLt(dict, expected, ParamName),
                () => EnsureArg.SizeIsLt(dict, expected, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsLt(expected));
        }

        [Fact]
        public void SizeIsLt_When_Array_is_null_It_should_throw_ArgumentNullException()
        {
            int[] values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLt(values, 1, ParamName),
                () => EnsureArg.SizeIsLt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(1));
        }

        [Fact]
        public void SizeIsLt_When_ICollection_is_null_It_should_throw_ArgumentNullException()
        {
            ICollection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLt(values, 1, ParamName),
                () => EnsureArg.SizeIsLt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(1));
        }

        [Fact]
        public void SizeIsLt_When_Collection_is_null_It_should_throw_ArgumentNullException()
        {
            Collection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLt(values, 1, ParamName),
                () => EnsureArg.SizeIsLt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(1));
        }

        [Fact]
        public void SizeIsLt_When_IList_is_null_It_should_throw_ArgumentNullException()
        {
            IList<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLt(values, 1, ParamName),
                () => EnsureArg.SizeIsLt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(1));
        }

        [Fact]
        public void SizeIsLt_When_List_is_null_It_should_throw_ArgumentNullException()
        {
            List<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLt(values, 1, ParamName),
                () => EnsureArg.SizeIsLt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(1));
        }

        [Fact]
        public void SizeIsLt_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLt(values, 1, ParamName),
                () => EnsureArg.SizeIsLt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(1));
        }

        [Fact]
        public void SizeIsLt_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLt(values, 1, ParamName),
                () => EnsureArg.SizeIsLt(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLt(1));
        }

        [Fact]
        public void SizeIsGte_When_matching_length_of_array_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGte(values, values.Length, ParamName),
                () => EnsureArg.SizeIsGte(values, values.Length, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(values.Length));
        }

        [Fact]
        public void SizeIsGte_When_non_matching_length_of_array_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3 };
            var expected = values.Length;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected+1, values.Length),
                () => Ensure.Collection.SizeIsGte(values, expected + 1, ParamName),
                () => EnsureArg.SizeIsGte(values, expected + 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(expected + 1));
        }

        [Fact]
        public void SizeIsGte_When_matching_count_of_List_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGte(values, values.Count, ParamName),
                () => EnsureArg.SizeIsGte(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(values.Count - 1));
        }

        [Fact]
        public void SizeIsGte_When_non_matching_count_of_List_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected + 1, values.Count),
                () => Ensure.Collection.SizeIsGte(values, expected + 1, ParamName),
                () => EnsureArg.SizeIsGte(values, expected + 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(expected + 1));
        }

        [Fact]
        public void SizeIsGte_When_matching_count_of_IList_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGte(values, values.Count, ParamName),
                () => EnsureArg.SizeIsGte(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(values.Count - 1));
        }

        [Fact]
        public void SizeIsGte_When_non_matching_count_of_IList_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected + 1, values.Count),
                () => Ensure.Collection.SizeIsGte(values, expected + 1, ParamName),
                () => EnsureArg.SizeIsGte(values, expected + 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(expected + 1));
        }

        [Fact]
        public void SizeIsGte_When_matching_count_of_Collection_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGte(values, values.Count, ParamName),
                () => EnsureArg.SizeIsGte(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(values.Count - 1));
        }

        [Fact]
        public void SizeIsGte_When_non_matching_count_of_Collection_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected + 1, values.Count),
                () => Ensure.Collection.SizeIsGte(values, expected+1, ParamName),
                () => EnsureArg.SizeIsGte(values, expected+1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(expected + 1));
        }

        [Fact]
        public void SizeIsGte_When_matching_count_of_ICollection_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGte(values, values.Count, ParamName),
                () => EnsureArg.SizeIsGte(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(values.Count - 1));
        }

        [Fact]
        public void SizeIsGte_When_non_matching_count_of_ICollection_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected + 1, values.Count),
                () => Ensure.Collection.SizeIsGte(values, expected + 1, ParamName),
                () => EnsureArg.SizeIsGte(values, expected + 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(expected + 1));
        }

        [Fact]
        public void SizeIsGte_When_matching_count_of_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGte(dict, dict.Count, ParamName),
                () => EnsureArg.SizeIsGte(dict, dict.Count, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsGte(dict.Count));
        }

        [Fact]
        public void SizeIsGte_When_non_matching_count_of_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected + 1, dict.Count),
                () => Ensure.Collection.SizeIsGte(dict, expected + 1, ParamName),
                () => EnsureArg.SizeIsGte(dict, expected + 1, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsGte(expected + 1));
        }

        [Fact]
        public void SizeIsGte_When_matching_count_of_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsGte(dict, dict.Count, ParamName),
                () => EnsureArg.SizeIsGte(dict, dict.Count, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsGte(dict.Count - 1));
        }

        [Fact]
        public void SizeIsGte_When_non_matching_count_of_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsGte_Failed, expected + 1, dict.Count),
                () => Ensure.Collection.SizeIsGte(dict, expected + 1, ParamName),
                () => EnsureArg.SizeIsGte(dict, expected + 1, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsGte(expected + 1));
        }

        [Fact]
        public void SizeIsGte_When_Array_is_null_It_should_throw_ArgumentNullException()
        {
            int[] values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGte(values, 1, ParamName),
                () => EnsureArg.SizeIsGte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(1));
        }

        [Fact]
        public void SizeIsGte_When_ICollection_is_null_It_should_throw_ArgumentNullException()
        {
            ICollection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGte(values, 1, ParamName),
                () => EnsureArg.SizeIsGte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(1));
        }

        [Fact]
        public void SizeIsGte_When_Collection_is_null_It_should_throw_ArgumentNullException()
        {
            Collection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGte(values, 1, ParamName),
                () => EnsureArg.SizeIsGte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(1));
        }

        [Fact]
        public void SizeIsGte_When_IList_is_null_It_should_throw_ArgumentNullException()
        {
            IList<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGte(values, 1, ParamName),
                () => EnsureArg.SizeIsGte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(1));
        }

        [Fact]
        public void SizeIsGte_When_List_is_null_It_should_throw_ArgumentNullException()
        {
            List<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGte(values, 1, ParamName),
                () => EnsureArg.SizeIsGte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(1));
        }

        [Fact]
        public void SizeIsGte_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGte(values, 1, ParamName),
                () => EnsureArg.SizeIsGte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(1));
        }

        [Fact]
        public void SizeIsGte_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsGte(values, 1, ParamName),
                () => EnsureArg.SizeIsGte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsGte(1));
        }

        [Fact]
        public void SizeIsLte_When_matching_length_of_array_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLte(values, values.Length, ParamName),
                () => EnsureArg.SizeIsLte(values, values.Length, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(values.Length + 1));
        }

        [Fact]
        public void SizeIsLte_When_non_matching_length_of_array_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3 };
            var expected = values.Length;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected - 1, values.Length),
                () => Ensure.Collection.SizeIsLte(values, expected - 1, ParamName),
                () => EnsureArg.SizeIsLte(values, expected - 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(expected - 1));
        }

        [Fact]
        public void SizeIsLte_When_matching_count_of_List_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLte(values, values.Count, ParamName),
                () => EnsureArg.SizeIsLte(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(values.Count + 1));
        }

        [Fact]
        public void SizeIsLte_When_non_matching_count_of_List_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected - 1, values.Count),
                () => Ensure.Collection.SizeIsLte(values, expected - 1, ParamName),
                () => EnsureArg.SizeIsLte(values, expected - 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(expected - 1));
        }

        [Fact]
        public void SizeIsLte_When_matching_count_of_IList_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLte(values, values.Count, ParamName),
                () => EnsureArg.SizeIsLte(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(values.Count + 1));
        }

        [Fact]
        public void SizeIsLte_When_non_matching_count_of_IList_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected - 1, values.Count),
                () => Ensure.Collection.SizeIsLte(values, expected - 1, ParamName),
                () => EnsureArg.SizeIsLte(values, expected - 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(expected - 1));
        }

        [Fact]
        public void SizeIsLte_When_matching_count_of_Collection_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLte(values, values.Count, ParamName),
                () => EnsureArg.SizeIsLte(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(values.Count + 1));
        }

        [Fact]
        public void SizeIsLte_When_non_matching_count_of_Collection_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected-1, values.Count),
                () => Ensure.Collection.SizeIsLte(values, expected - 1, ParamName),
                () => EnsureArg.SizeIsLte(values, expected - 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(expected - 1));
        }

        [Fact]
        public void SizeIsLte_When_matching_count_of_ICollection_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLte(values, values.Count, ParamName),
                () => EnsureArg.SizeIsLte(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(values.Count + 1));
        }

        [Fact]
        public void SizeIsLte_When_non_matching_count_of_ICollection_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected - 1, values.Count),
                () => Ensure.Collection.SizeIsLte(values, expected - 1, ParamName),
                () => EnsureArg.SizeIsLte(values, expected - 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(expected - 1));
        }

        [Fact]
        public void SizeIsLte_When_matching_count_of_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLte(dict, dict.Count, ParamName),
                () => EnsureArg.SizeIsLte(dict, dict.Count, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsLte(dict.Count + 1));
        }

        [Fact]
        public void SizeIsLte_When_non_matching_count_of_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected - 1, dict.Count),
                () => Ensure.Collection.SizeIsLte(dict, expected - 1, ParamName),
                () => EnsureArg.SizeIsLte(dict, expected - 1, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsLte(expected - 1));
        }

        [Fact]
        public void SizeIsLte_When_matching_count_of_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIsLte(dict, dict.Count, ParamName),
                () => EnsureArg.SizeIsLte(dict, dict.Count, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsLte(dict.Count + 1));
        }

        [Fact]
        public void SizeIsLte_When_non_matching_count_of_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count;

            ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIsLte_Failed, expected - 1, dict.Count),
                () => Ensure.Collection.SizeIsLte(dict, expected - 1, ParamName),
                () => EnsureArg.SizeIsLte(dict, expected - 1, ParamName),
                () => Ensure.That(dict, ParamName).SizeIsLte(expected - 1));
        }

        [Fact]
        public void SizeIsLte_When_Array_is_null_It_should_throw_ArgumentNullException()
        {
            int[] values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLte(values, 1, ParamName),
                () => EnsureArg.SizeIsLte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(1));
        }

        [Fact]
        public void SizeIsLte_When_ICollection_is_null_It_should_throw_ArgumentNullException()
        {
            ICollection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLte(values, 1, ParamName),
                () => EnsureArg.SizeIsLte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(1));
        }

        [Fact]
        public void SizeIsLte_When_Collection_is_null_It_should_throw_ArgumentNullException()
        {
            Collection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLte(values, 1, ParamName),
                () => EnsureArg.SizeIsLte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(1));
        }

        [Fact]
        public void SizeIsLte_When_IList_is_null_It_should_throw_ArgumentNullException()
        {
            IList<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLte(values, 1, ParamName),
                () => EnsureArg.SizeIsLte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(1));
        }

        [Fact]
        public void SizeIsLte_When_List_is_null_It_should_throw_ArgumentNullException()
        {
            List<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLte(values, 1, ParamName),
                () => EnsureArg.SizeIsLte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(1));
        }

        [Fact]
        public void SizeIsLte_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLte(values, 1, ParamName),
                () => EnsureArg.SizeIsLte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(1));
        }

        [Fact]
        public void SizeIsLte_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIsLte(values, 1, ParamName),
                () => EnsureArg.SizeIsLte(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIsLte(1));
        }
        #endregion

        #region IsInAscending/Descending Order
        [Fact]
        public void IsInAscendingOrder_Array_Should_Not_Throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                ()=>Ensure.Collection.IsInAscendingOrder(values, paramName: ParamName),
                ()=>EnsureArg.IsInAscendingOrder(values, paramName: ParamName),
                ()=>Ensure.That(values, ParamName).IsInAscendingOrder());
        }

        [Fact]
        public void IsInAscendingOrder_Array_Should_Throw()
        {
            var values = new[] { 3, 2, 1 };

            ShouldThrow<ArgumentException>(ExceptionMessages.Collections_IsInAscendingOrder_Failed,
                () => Ensure.Collection.IsInAscendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInAscendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInAscendingOrder());
        }

        [Fact]
        public void IsInAscendingOrder_List_Should_Not_Throw()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.IsInAscendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInAscendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInAscendingOrder());
        }

        [Fact]
        public void IsInAscendingOrder_List_Should_Throw()
        {
            IList<int> values = new List<int> { 3, 2, 1 };

            ShouldThrow<ArgumentException>(ExceptionMessages.Collections_IsInAscendingOrder_Failed,
                () => Ensure.Collection.IsInAscendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInAscendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInAscendingOrder());
        }

        [Fact]
        public void IsInAscendingOrder_Collection_Should_Not_Throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.IsInAscendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInAscendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInAscendingOrder());
        }

        [Fact]
        public void IsInAscendingOrder_Collection_Should_Throw()
        {
            ICollection<int> values = new Collection<int> { 3, 2, 1 };

            ShouldThrow<ArgumentException>(ExceptionMessages.Collections_IsInAscendingOrder_Failed,
                () => Ensure.Collection.IsInAscendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInAscendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInAscendingOrder());
        }

        [Fact]
        public void IsInAscendingOrder_Dictionary_Should_Not_Throw()
        {
            IDictionary<int, int> values = new Dictionary<int, int> { { 1, 2 }, { 2, 3 }, { 3, 4 } };

            ShouldNotThrow(
                () => Ensure.Collection.IsInAscendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInAscendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInAscendingOrder());
        }

        [Fact]
        public void IsInAscendingOrder_Dictionary_Should_Throw()
        {
            IDictionary<int, int> values = new Dictionary<int, int> { { 4, 3 }, { 3, 2 }, { 2, 1 } };

            ShouldThrow<ArgumentException>(ExceptionMessages.Collections_IsInAscendingOrder_Failed,
                () => Ensure.Collection.IsInAscendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInAscendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInAscendingOrder());
        }

        [Fact]
        public void IsInDescendingOrder_Array_Should_Not_Throw()
        {
            var values = new[] { 3, 2, 1 };

            ShouldNotThrow(
                () => Ensure.Collection.IsInDescendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInDescendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInDescendingOrder());
        }

        [Fact]
        public void IsInDescendingOrder_Array_Should_Throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldThrow<ArgumentException>(ExceptionMessages.Collections_IsInDescendingOrder_Failed,
                () => Ensure.Collection.IsInDescendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInDescendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInDescendingOrder());
        }

        [Fact]
        public void IsInDescendingOrder_List_Should_Not_Throw()
        {
            IList<int> values = new List<int> { 3, 2, 1 };

            ShouldNotThrow(
                () => Ensure.Collection.IsInDescendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInDescendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInDescendingOrder());
        }

        [Fact]
        public void IsInDescendingOrder_List_Should_Throw()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldThrow<ArgumentException>(ExceptionMessages.Collections_IsInDescendingOrder_Failed,
                () => Ensure.Collection.IsInDescendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInDescendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInDescendingOrder());
        }

        [Fact]
        public void IsInDescendingOrder_Collection_Should_Not_Throw()
        {
            ICollection<int> values = new Collection<int> { 3, 2, 1 };

            ShouldNotThrow(
                () => Ensure.Collection.IsInDescendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInDescendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInDescendingOrder());
        }

        [Fact]
        public void IsInDescendingOrder_Collection_Should_Throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };

            ShouldThrow<ArgumentException>(ExceptionMessages.Collections_IsInDescendingOrder_Failed,
                () => Ensure.Collection.IsInDescendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInDescendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInDescendingOrder());
        }

        [Fact]
        public void IsInDescendingOrder_Dictionary_Should_Not_Throw()
        {
            IDictionary<int, int> values = new Dictionary<int, int> { { 4, 3 }, { 3, 2 }, { 2, 1 } };

            ShouldNotThrow(
                () => Ensure.Collection.IsInDescendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInDescendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInDescendingOrder());
        }

        [Fact]
        public void IsInDescendingOrder_Dictionary_Should_Throw()
        {
            IDictionary<int, int> values = new Dictionary<int, int> { { 1, 2 }, { 2, 3 }, { 3, 4 } };

            ShouldThrow<ArgumentException>(ExceptionMessages.Collections_IsInDescendingOrder_Failed,
                () => Ensure.Collection.IsInDescendingOrder(values, paramName: ParamName),
                () => EnsureArg.IsInDescendingOrder(values, paramName: ParamName),
                () => Ensure.That(values, ParamName).IsInDescendingOrder());
        }
        #endregion

        [Fact]
        public void ContainsKey_When_key_does_not_exist_in_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };
            const string expectedKey = "Foo";

            AssertContainsKey(
                expectedKey,
                () => Ensure.Collection.ContainsKey(dict, expectedKey, ParamName),
                () => EnsureArg.ContainsKey(dict, expectedKey, ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey(expectedKey));
        }

        [Fact]
        public void ContainsKey_When_key_exists_in_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.ContainsKey(dict, "B", ParamName),
                () => EnsureArg.ContainsKey(dict, "B", ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey("B"));
        }

        [Fact]
        public void ContainsKey_When_key_does_not_exist_in_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };
            const string expectedKey = "Foo";

            AssertContainsKey(
                expectedKey,
                () => Ensure.Collection.ContainsKey(dict, expectedKey, ParamName),
                () => EnsureArg.ContainsKey(dict, expectedKey, ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey(expectedKey));
        }

        [Fact]
        public void ContainsKey_When_key_exists_in_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.ContainsKey(dict, "B", ParamName),
                () => EnsureArg.ContainsKey(dict, "B", ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey("B"));
        }

        [Fact]
        public void ContainsKey_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> dict = null;

            AssertIsNotNull(
                () => Ensure.Collection.ContainsKey(dict, "B", ParamName),
                () => EnsureArg.ContainsKey(dict, "B", ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey("B"));
        }

        [Fact]
        public void ContainsKey_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> dict = null;

            AssertIsNotNull(
                () => Ensure.Collection.ContainsKey(dict,"B", ParamName),
                () => EnsureArg.ContainsKey(dict, "B", ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey("B"));
        }

        [Fact]
        public void HasAny_When_IList_predicate_yields_none_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_IList_predicate_yields_something_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 1;

            ShouldNotThrow(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_List_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_List_predicate_yields_something_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 1;

            ShouldNotThrow(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_ICollection_predicate_yields_none_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_ICollection_predicate_yields_something_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 1;

            ShouldNotThrow(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Collection_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Collection_predicate_yields_something_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 1;

            ShouldNotThrow(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Array_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Array_predicate_yields_something_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 1;

            ShouldNotThrow(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Array_is_null_It_throws_ArgumentNullException()
        {
            int[] values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Collection_is_null_It_throws_ArgumentNullException()
        {
            Collection<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_ICollection_is_null_It_throws_ArgumentNullException()
        {
            ICollection<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_List_is_null_It_throws_ArgumentNullException()
        {
            List<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_IList_is_null_It_throws_ArgumentNullException()
        {
            IList<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Dictionary_is_null_It_throws_ArgumentNullException()
        {
            Dictionary<int, int> values = null;
            Func<KeyValuePair<int, int>, bool> predicate = i => i.Value == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_IDictionary_is_null_It_throws_ArgumentNullException()
        {
            IDictionary<int, int> values = null;
            Func<KeyValuePair<int, int>, bool> predicate = i => i.Value == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        private void AssertIsEmptyCollection(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_HasItemsFailed, actions);

        private void AssertIsNotNull(params Action[] actions) => ShouldThrow<ArgumentNullException>(ExceptionMessages.Common_IsNotNull_Failed, actions);

        private void AssertSizeIsWrong(int actualSize, int expectedSize, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIs_Failed, expectedSize, actualSize), actions);

        private void AssertContainsKey(string expectedKey, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_ContainsKey_Failed, expectedKey), actions);

        private void AssertAnyPredicateYieldedNone(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_Any_Failed, actions);
    }
}