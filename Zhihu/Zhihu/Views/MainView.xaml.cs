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
                        //case 1:
                        //    CurrentPage = IdeasView;
                        //    break;
                        //case 2:
                        //    CurrentPage = MarketView;
                        //    break;
                        //case 3:
                        //    CurrentPage = NotificationView;
                        //    break;
                        //case 4:
                        //    CurrentPage = MyView;
                        //    break;
                }
            });

            await ((HomeViewModel)HomeView.BindingContext).InitializeAsync(null);
            //await (()IdeasView.BindingContext).InitializeAsync(null);
            //await ((ProfileViewModel)ProfileView.BindingContext).InitializeAsync(null);
            //         await ((CampaignViewModel)CampaignView.BindingContext).InitializeAsync(null);
        }

        //     protected override async void OnCurrentPageChanged()
        //     {
        //         base.OnCurrentPageChanged();

        //         if (CurrentPage is HomeView)
        //         {
        //             // Force basket view refresh every time we access it
        //             if (HomeView != null) {
        //                 await (HomeView.BindingContext as ViewModelBase).InitializeAsync(null);
        //             }
        //         }
        //         //else if (CurrentPage is CampaignView)
        //         //{
        //         //    // Force campaign view refresh every time we access it
        //         //    await (CampaignView.BindingContext as ViewModelBase).InitializeAsync(null);
        //         //}
        //         //else if (CurrentPage is ProfileView)
        //         //{
        //         //    // Force profile view refresh every time we access it
        //         //    await (ProfileView.BindingContext as ViewModelBase).InitializeAsync(null);
        //         //}
        //     }
    }
}
