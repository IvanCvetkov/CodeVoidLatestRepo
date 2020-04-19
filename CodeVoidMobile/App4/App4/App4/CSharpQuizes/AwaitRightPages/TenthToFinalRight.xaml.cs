using App4.CSharpQuizes.CSharpBasicsOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.AwaitRightPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TenthToFinalRight : ContentPage
    {
        public TenthToFinalRight()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            await Task.Delay(1000);
            dots.Play();
            await Task.Delay(1000);
            await Navigation.PushAsync(new Final());
        }
    }
}