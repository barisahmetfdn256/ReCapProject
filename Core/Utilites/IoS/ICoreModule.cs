using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.IoS
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
