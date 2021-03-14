using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.ProxyPattern
{
    /// <summary>
    /// Sample代理;
    /// 代理还有 RemoteProxy， VirtualProxy, Cacheproxy, SmartReferenceProxy等
    /// </summary>
    public class AccessProxy : IAccessService
    {
        private readonly IAccessService accessService;
        private readonly AccessValidator accessValidator;
        private readonly AccessLog accessLog;

        public AccessProxy(IAccessService accessService, AccessValidator accessValidator, AccessLog accessLog)
        {
            this.accessService = accessService;
            this.accessValidator = accessValidator;
            this.accessLog = accessLog;
        }

        public string Search(string userId)
        {
            if (accessValidator.Validate(userId))
            {
                accessLog.Log(userId);

                return accessService.Search(userId);
            }

            return string.Empty;
        }
    }
}
