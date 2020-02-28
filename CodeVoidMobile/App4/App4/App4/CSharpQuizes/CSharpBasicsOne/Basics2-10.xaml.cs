using App4.CSharpQuizes.AwaitRightPages;
using App4.CSharpQuizes.AwaitWrongPages;
using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Basics2_10 : ContentPage
    {
        public Basics2_10()
        {
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
        }

        //public async void Await()
        //{
        //    await Task.Delay(2000);
        //}

        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (option1.IsChecked == true && option3.IsChecked == true
                && option2.IsChecked == false && option4.IsChecked == false)
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new SecondToThirdRight());
            }
            else
            {
                await Navigation.PushAsync(new SecondToThirdWrong());
                await Task.Delay(300);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new Basics1_10());
            return true;
        }
    }
}