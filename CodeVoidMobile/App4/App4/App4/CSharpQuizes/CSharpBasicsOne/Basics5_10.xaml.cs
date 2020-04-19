using App4.CSharpQuizes.AwaitRightPages;
using App4.CSharpQuizes.AwaitWrongPages;
using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Basics5_10 : ContentPage
    {
        public Basics5_10()
        {
            InitializeComponent();
        }

        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (option2.IsChecked == true && option1.IsChecked == false
               && option3.IsChecked == false && option4.IsChecked == false)
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new FifthToSixthRight());
            }
            else
            {
                await Navigation.PushAsync(new FifthToSixthWrong());
                await Task.Delay(300);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new Basics4_10());
            return true;
        }
    }
}