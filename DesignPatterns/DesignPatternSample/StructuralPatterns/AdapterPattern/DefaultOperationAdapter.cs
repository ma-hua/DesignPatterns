using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.AdapterPattern
{
    /// <summary>
    /// 缺省适配器模式
    /// </summary>
    public class DefaultOperationAdapter : AbstractOperationAdapter
    {
        private readonly BinarySearchClass _binarySearch;
        private readonly QuickSortClass _quickSort;

        public DefaultOperationAdapter(BinarySearchClass binarySearch, QuickSortClass quickSort)
        {
            _binarySearch = binarySearch;
            _quickSort = quickSort;
        }

        public override int Search(int[] array, int key) => _binarySearch.BinarySearch(array, key);

        public override int[] Sort(int[] array) => _quickSort.QuickSort(array);
    }
}
