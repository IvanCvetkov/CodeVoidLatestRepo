using App4.CSharpQuizes.CSharpBasicsTwo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsTwo.AwaitRightPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Five_To_Six : ContentPage
    {
        public Five_To_Six()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            await Task.Delay(2000);
            await Navigation.PushAsync(new Basics6_20());
        }
    }
}