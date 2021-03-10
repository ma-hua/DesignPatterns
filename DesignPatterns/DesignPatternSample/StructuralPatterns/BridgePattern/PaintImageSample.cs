using DesignPatternSample.StructuralPatterns.BridgePattern.Image;
using DesignPatternSample.StructuralPatterns.BridgePattern.Implementor;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace DesignPatternSample.StructuralPatterns.BridgePattern
{
    public class PaintImageSample
    {
        private readonly IServiceProvider _serviceProvider;

        public PaintImageSample(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
         
        public void Paint(ImageType imageType, ImpType impType, string fileName)
        {
            var images = _serviceProvider.GetServices<IImage>();
            var image = images.FirstOrDefault(x => x.GetType().GetCustomAttribute<ImageAttribute>().ImageType == imageType);

            var imps = _serviceProvider.GetServices<ImageImp>();
            var imp = imps.FirstOrDefault(x => x.GetType().GetCustomAttribute<ImpAttribute>().ImpType == impType);

            image?.SetImp(imp);
            image.ParseFile(fileName);
        }
    }
}
