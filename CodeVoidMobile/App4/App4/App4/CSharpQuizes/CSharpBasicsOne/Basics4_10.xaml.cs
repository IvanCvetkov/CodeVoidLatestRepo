using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App4.CSharpQuizes.AwaitRightPages;
using App4.CSharpQuizes.AwaitWrongPages;

namespace App4.CSharpQuizes.CSharpBasicsOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Basics4_10 : ContentPage
    {
        public Basics4_10()
        {
            InitializeComponent();
        }

        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (option3.IsChecked == true && option1.IsChecked == false
                && option2.IsChecked == false && option4.IsChecked == false)
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new ForthToFifthRight());
            }
            else
            {
                await Navigation.PushAsync(new ForthToFifthWrong());
                await Task.Delay(300);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}