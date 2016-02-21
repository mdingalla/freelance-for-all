using Abp.Web.Mvc.Views;

namespace FreelanceForAll.Web.Views
{
    public abstract class FreelanceForAllWebViewPageBase : FreelanceForAllWebViewPageBase<dynamic>
    {

    }

    public abstract class FreelanceForAllWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected FreelanceForAllWebViewPageBase()
        {
            LocalizationSourceName = FreelanceForAllConsts.LocalizationSourceName;
        }
    }
}