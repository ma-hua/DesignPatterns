using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.BridgePattern.Image
{
    public class ImageAttribute : Attribute
    {
        public ImageType ImageType { get; set; }

        public ImageAttribute(ImageType imageType)
        {
            ImageType = imageType;
        }
    }
}
