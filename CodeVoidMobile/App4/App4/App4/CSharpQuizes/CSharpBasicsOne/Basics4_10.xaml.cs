using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Basics4_10 : ContentPage
    {
        public Basics4_10()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new Basics3_10());
            return true;
        }
    }
}