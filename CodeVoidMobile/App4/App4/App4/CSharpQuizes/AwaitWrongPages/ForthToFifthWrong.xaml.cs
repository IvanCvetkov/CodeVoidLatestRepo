using App4.CSharpQuizes.CSharpBasicsOne;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.AwaitWrongPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForthToFifthWrong : ContentPage
    {
        public ForthToFifthWrong()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            await Task.Delay(2000);
            await Navigation.PushAsync(new Basics5_10());
        }
    }
}