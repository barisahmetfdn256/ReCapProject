using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilites.İntercaptors;
using Core.Utilites.IoS;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Chasing
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
