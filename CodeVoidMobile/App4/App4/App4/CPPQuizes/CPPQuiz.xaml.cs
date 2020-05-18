using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CPPQuizes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CPPQuiz : ContentPage
    {
        public CPPQuiz()
        {
            InitializeComponent();
        }
        async Task RotateImageContinously()
        {
            for (int i = 1; i < 2; i++)
            {
                if (Logo.Rotation >= 360f) Logo.Rotation = 0;
                await Logo.RotateTo(i * (120), 400, Easing.CubicInOut);
                await Logo.RotateTo(i * (-240), 1000, Easing.CubicInOut);
                await Logo.RotateTo(i * (0), 1500, Easing.SinInOut);
            }
        }

        protected override async void OnAppearing()
        {
            await RotateImageContinously();
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new QuizesPage());
            return true;
        }

        private void BasicsFirst_Clicked(object sender, EventArgs e)
        {

        }

        private void AdvancedFirst_Clicked(object sender, EventArgs e)
        {

        }

        private void BasicsSecond_Clicked(object sender, EventArgs e)
        {

        }

        private void AdvancedSecond_Clicked(object sender, EventArgs e)
        {

        }

        private void AdvancedThird_Clicked(object sender, EventArgs e)
        {

        }

        private void BasicsThird_Clicked(object sender, EventArgs e)
        {

        }
    }
}