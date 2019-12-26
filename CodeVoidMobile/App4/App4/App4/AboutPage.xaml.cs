using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
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
        private async void CodeVoidGithub_Clicked(object sender, EventArgs e)
        {
            await RotateImageContinously();
            Device.OpenUri(new Uri("https://github.com/ivancvetkov/codevoid"));
        }
    }
}