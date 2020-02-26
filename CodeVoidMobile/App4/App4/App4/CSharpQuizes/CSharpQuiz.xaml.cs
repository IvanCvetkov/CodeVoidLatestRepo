using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
namespace App4.CSharpQuizes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CSharpQuiz : ContentPage
    {
        public CSharpQuiz()
        {
            InitializeComponent();
        }

        private void BasicsFirst_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CSharpBasicsOne.Basics1_10());
        }

        private void BasicsSecond_Clicked(object sender, EventArgs e)
        {

        }

        private void AdvancedFirst_Clicked(object sender, EventArgs e)
        {

        }

        private void AdvancedSecond_Clicked(object sender, EventArgs e)
        {

        }

        private void AdvancedThird_Clicked(object sender, EventArgs e)
        {

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
    }
}