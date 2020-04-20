using App4.CSharpQuizes.CSharpBasicsTwo.AwaitRightPages;
using App4.CSharpQuizes.CSharpBasicsTwo.AwaitWrongPages;
using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsTwo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Basics6_20 : ContentPage
    {
        public Basics6_20()
        {
            InitializeComponent();
        }
        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (option1.IsChecked == true && option3.IsChecked == false
                && option4.IsChecked == false && option2.IsChecked == false)
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new Six_To_Seven());
            }
            else
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new Six_To_Seven_Wrong());
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