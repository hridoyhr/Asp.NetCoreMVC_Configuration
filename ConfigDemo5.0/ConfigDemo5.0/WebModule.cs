using Autofac;
using ConfigDemo5._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigDemo5._0
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SimpleDatabaseService>().As<IDatabaseService>()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
