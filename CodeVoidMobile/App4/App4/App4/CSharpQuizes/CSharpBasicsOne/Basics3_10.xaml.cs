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
    public partial class Basics3_10 : ContentPage
    {
        public Basics3_10()
        {
            InitializeComponent();
        }

        private void Forward_Clicked(object sender, EventArgs e)
        {

        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new Basics2_10());
            return true;
        }
    }
}