using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace boilerplatetemplate
{
    [DependsOn(typeof(boilerplatetemplateCoreModule), typeof(AbpAutoMapperModule))]
    public class boilerplatetemplateApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
