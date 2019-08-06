using Beers.Core.Services;
using Beers.Core.ViewModels;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Beers.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IRestService, RestService>();
            
            RegisterAppStart<WelcomeViewModel>();
        }
    }
}
