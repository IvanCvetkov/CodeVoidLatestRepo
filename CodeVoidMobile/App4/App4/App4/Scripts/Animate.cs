using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App4.Scripts
{
    public class Animate
    {
        public static async void RotateAnimate(View view)
        {
            do
            {
                await view.RotateTo(-360, 2000);
            } while (true);
        }
    }
}
