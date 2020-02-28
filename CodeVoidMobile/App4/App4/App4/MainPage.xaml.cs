using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async Task RotateImageContinously()
        {
            for (int i = 1; i < 2; i++)
            {
                if (Logo.Rotation >= 360f) Logo.Rotation = 0;
                await Logo.RotateTo(i * (360), 1000, Easing.CubicInOut);
            }
        }

        private async void Quizes_Clicked(object sender, EventArgs e)
        {
            await RotateImageContinously();

            if (Navigation.NavigationStack.Count == 0 || 
                Navigation.NavigationStack.Last().GetType() != typeof(QuizesPage))
            await Navigation.PushAsync(new QuizesPage(), true);
        }

        private async void About_Clicked(object sender, EventArgs e)
        {
            await RotateImageContinously();

            if (Navigation.NavigationStack.Count == 0 ||
                Navigation.NavigationStack.Last().GetType() != typeof(AboutPage))
                await Navigation.PushAsync(new AboutPage(), true);
        }

        private async void Progress_Clicked(object sender, EventArgs e)
        {
            await RotateImageContinously();

            if (Navigation.NavigationStack.Count == 0 ||
                Navigation.NavigationStack.Last().GetType() != typeof(ProgressPage))
                await Navigation.PushAsync(new ProgressPage(), true);
        }
    }
}
