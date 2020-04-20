using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App4.CSharpQuizes.CSharpBasicsTwo.AwaitRightPages;
using App4.CSharpQuizes.CSharpBasicsTwo.AwaitWrongPages;

namespace App4.CSharpQuizes.CSharpBasicsTwo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Basics8_20 : ContentPage
    {
        public Basics8_20()
        {
            InitializeComponent();
        }
        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (option4.IsChecked == true && option3.IsChecked == false
                && option1.IsChecked == false && option2.IsChecked == false)
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new Eight_To_Nine());
            }
            else
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new Eight_To_Nine_Wrong());
            }
        }

        protected override bool OnBackButtonPressed()
        {
            BackButtonPressed();
            return true;
        }

        public async Task BackButtonPressed()
        {
            var action = await DisplayAlert("Предупреждение", "Найстина ли искаш да излезеш от текущия тест?" +
                " Ако го направиш ще изгубиш своя прогрес до тук!", "Не", "Да");
            if (!action)
            {
                await Navigation.PushAsync(new CSharpQuiz());
            }
        }
    }
}