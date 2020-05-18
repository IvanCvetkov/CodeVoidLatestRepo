﻿using System;
using App4.Awaitable;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Basics9_10 : ContentPage
    {
        public Basics9_10()
        {
            InitializeComponent();
        }

        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (option2.IsChecked == true && option3.IsChecked == false
                     && option4.IsChecked == false && option1.IsChecked == false)
            {
                await Task.Delay(250);
                await Navigation.PushAsync(new SuccessPage());
                await Task.Delay(2500);
                await Navigation.PushAsync(new Basics10_10());
            }
            else
            {
                App.Counter++;
                if (App.Counter == 3)
                {
                    await Navigation.PushAsync(new QuizFail());
                }
                else
                {
                    await Task.Delay(250);
                    await Navigation.PushAsync(new FailurePage());
                    await Task.Delay(2500);
                    await Navigation.PushAsync(new Basics10_10());
                }
            }
        }

        protected override bool OnBackButtonPressed()
        {
            BackButtonPressed();
            return true;
        }

        public async Task BackButtonPressed()
        {
            App.Counter = 0;
            var action = await DisplayAlert("Предупреждение", "Найстина ли искаш да излезеш от текущия тест?" +
                " Ако го направиш ще изгубиш своя прогрес до тук!", "Не", "Да");
            if (!action)
            {
                await Navigation.PushAsync(new CSharpQuiz());
            }
        }
    }
}