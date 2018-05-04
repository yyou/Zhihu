using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Zhihu.Core.ViewModels;

namespace Zhihu.Core.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeView : ContentPage
	{
        public HomeView()
		{
			InitializeComponent ();
        }

        //protected override async void OnAppearing() {
        //    var viewModel = this.BindingContext as HomeViewModel;
        //    await viewModel.InitializeAsync(null);
        //    base.OnAppearing();
        //}
    }
}