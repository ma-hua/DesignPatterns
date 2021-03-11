using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.CompositePattern.SafeCompositePattern
{
    public class FolderFile
    {
        private List<IAbstractFile> fileList = new List<IAbstractFile>();

        public void Add(IAbstractFile file)
        {
            fileList.Add(file);
        }

        public IAbstractFile GetChild(int i)
        {
            return fileList[i];
        }

        public void Open()
        {
            foreach (var file in fileList)
            {
                file.Open();
            }
        }

        public void Remove(IAbstractFile file)
        {
            fileList.Remove(file);
        }
    }
}
