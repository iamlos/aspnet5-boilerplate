using Abp.Web.Mvc.Views;

namespace boilerplatetemplate.Web.Views
{
    public abstract class boilerplatetemplateWebViewPageBase : boilerplatetemplateWebViewPageBase<dynamic>
    {

    }

    public abstract class boilerplatetemplateWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected boilerplatetemplateWebViewPageBase()
        {
            LocalizationSourceName = boilerplatetemplateConsts.LocalizationSourceName;
        }
    }
}