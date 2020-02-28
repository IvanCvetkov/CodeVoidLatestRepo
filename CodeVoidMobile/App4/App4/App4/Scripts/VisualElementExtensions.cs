using System.Threading.Tasks;
using Xamarin.Forms;

public static class VisualElementExtensions
{
    public static async Task FadeOut(this VisualElement element, uint duration = 400, Easing easing = null)
    {
        await element.FadeTo(0, duration, easing);
        element.IsVisible = false;
    }

    public static async Task FadeIn(this VisualElement element, uint duration = 400, Easing easing = null)
    {
        await element.FadeTo(1, duration, easing);
        element.IsVisible = true;
    }
    public static async Task RotateImageContinously(this VisualElement element)
    {
        for (int i = 1; i < 2; i++)
        {
            if (element.Rotation >= 360f) element.Rotation = 0;
            await element.RotateTo(i * (360), 1000, Easing.CubicInOut);
        }
    }
}