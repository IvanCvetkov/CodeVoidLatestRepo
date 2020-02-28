using App4.CSharpQuizes.CSharpBasicsOne;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.AwaitRightPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AwaitRight : ContentPage
    {
        public AwaitRight()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            await Task.Delay(1000);
            dots.Play();
            await Task.Delay(1000);
            await Navigation.PushAsync(new Basics2_10());
        }
    }
}