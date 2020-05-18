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
    public partial class ProgressPage : ContentPage
    {
        public ProgressPage()
        {
            InitializeComponent();
        }
        async Task RotateImageContinously()
        {
            for (int i = 1; i < 2; i++)
            {
                if (CSharpLogo.Rotation >= 360f) CSharpLogo.Rotation = 0;
                await CSharpLogo.RotateTo(i * (30), 300, Easing.CubicInOut);
                await CSharpLogo.RotateTo(i * (-30), 300, Easing.CubicInOut);
                await CSharpLogo.RotateTo(i * (0), 400, Easing.CubicInOut);
            }
        }
        protected override async void OnAppearing()
        {
            await RotateImageContinously();
        }
    }
}