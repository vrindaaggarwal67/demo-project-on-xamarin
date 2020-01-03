using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ProjectApplication.Droid.DependencyServices;
using ProjectApplication.IDependencyService;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


   [assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(LabelCustomFontEffect), "LabelCustomFontEffect")]
namespace ProjectApplication.Droid.DependencyServices
{
    class LabelCustomFontEffect : PlatformEffect
    {
        Typeface oldFont;
        protected override void OnAttached()
        {
            if (Element is Label == false)
                return;
            var label = Control as TextView;
            oldFont = label.Typeface;
            string fontName = FontEffect.GetFontName(Element);
            var font = Typeface.CreateFromAsset(Android.App.Application.Context.Assets, fontName);// "materialdesignicons-webfont.ttf");
            label.Typeface = font;

        }


        protected override void OnDetached()
        {
            if (oldFont != null)
            {
                var label = Control as TextView;
                label.Typeface = oldFont;
            }
        }
    }
}
