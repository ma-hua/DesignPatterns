using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.AdapterPattern
{
    /// <summary>
    /// 适配者接口
    /// </summary>
    public interface IArrayOperation
    {
        int Search(int[] array, int key);
        
        int[] Sort(int[] array);

        int[] Filter(int[] array);
    }
}
