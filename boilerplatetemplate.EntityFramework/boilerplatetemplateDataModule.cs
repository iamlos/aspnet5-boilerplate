using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using boilerplatetemplate.EntityFramework;

namespace boilerplatetemplate
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(boilerplatetemplateCoreModule))]
    public class boilerplatetemplateDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
