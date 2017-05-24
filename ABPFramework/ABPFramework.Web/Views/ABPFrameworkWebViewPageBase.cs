using Abp.Web.Mvc.Views;

namespace ABPFramework.Web.Views
{
    public abstract class ABPFrameworkWebViewPageBase : ABPFrameworkWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPFrameworkWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPFrameworkWebViewPageBase()
        {
            LocalizationSourceName = ABPFrameworkConsts.LocalizationSourceName;
        }
    }
}