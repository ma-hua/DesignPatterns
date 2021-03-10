using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.AdapterPattern
{
    public abstract class AbstractOperationAdapter : IArrayOperation
    {
        public virtual int Search(int[] array, int key) => 0;

        public virtual int[] Sort(int[] array) => array;

        public virtual int[] Filter(int[] array) => array;

    }
}
