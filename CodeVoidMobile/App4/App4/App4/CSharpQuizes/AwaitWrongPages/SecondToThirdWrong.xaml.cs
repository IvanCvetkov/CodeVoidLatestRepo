using App4.CSharpQuizes.CSharpBasicsOne;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.AwaitWrongPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondToThirdWrong : ContentPage
    {
        public SecondToThirdWrong()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            await Task.Delay(1000);
            dots.Play();
            await Task.Delay(1000);
            await Navigation.PushAsync(new Basics3_10());
        }
    }
}