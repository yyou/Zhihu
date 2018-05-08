using Zhihu.Core.ViewModels;
using Zhihu.Core.ViewModels.Base;
using Xamarin.Forms;

namespace Zhihu.Core.Views
{
    public partial class MainView : TabbedPage
    {
        public MainView()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing() {
            base.OnAppearing();

            MessagingCenter.Subscribe<MainViewModel, int>(this, MessageKeys.ChangeTab, (sender, arg) => {
                switch (arg) {
                    case 0:
                        CurrentPage = HomeView;
                        break;
                    case 1:
                        CurrentPage = IdeasView;
                        break;
                    case 2:
                        CurrentPage = MarketView;
                        break;
                    case 3:
                        CurrentPage = NotificationView;
                        break;
                    case 4:
                        CurrentPage = MyView;
                        break;
                }
            });

            await ((HomeViewModel)HomeView.BindingContext).InitializeAsync(null);
            await ((IdeasViewModel)IdeasView.BindingContext).InitializeAsync(null);
            await ((MarketViewModel)MarketView.BindingContext).InitializeAsync(null);
            await ((NotificationViewModel)NotificationView.BindingContext).InitializeAsync(null);
            await ((MyViewModel)MyView.BindingContext).InitializeAsync(null);
        }

        protected override async void OnCurrentPageChanged() {
            base.OnCurrentPageChanged();

            if (CurrentPage is HomeView) {
                // Force basket view refresh every time we access it
                if (HomeView != null) {
                    await (HomeView.BindingContext as ViewModelBase).InitializeAsync(null);
                }
                
            } else if (CurrentPage is IdeasView) {
                if (IdeasView != null) {
                    await (IdeasView.BindingContext as IdeasViewModel).InitializeAsync(null);
                }
            } else if (CurrentPage is MarketView) {
                if (MarketView != null) {
                    await (MarketView.BindingContext as MarketViewModel).InitializeAsync(null);
                }
            } else if (CurrentPage is NotificationView) {
                if (NotificationView != null) {
                    await (NotificationView.BindingContext as NotificationViewModel).InitializeAsync(null);
                }
            } else if (CurrentPage is MyView) {
                if (MyView != null) {
                    await (MyView.BindingContext as MyViewModel).InitializeAsync(null);
                }
            }
        }
    }
}
