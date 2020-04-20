using App4.CSharpQuizes.CSharpBasicsTwo.AwaitRightPages;
using App4.CSharpQuizes.CSharpBasicsTwo.AwaitWrongPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsTwo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Basics7_20 : ContentPage
    {
        public Basics7_20()
        {
            InitializeComponent();
        }
        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (option1.IsChecked == true && option3.IsChecked == false
                && option4.IsChecked == false && option2.IsChecked == false)
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new Seven_To_Eight());
            }
            else
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new Seven_To_Eight_Wrong());
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