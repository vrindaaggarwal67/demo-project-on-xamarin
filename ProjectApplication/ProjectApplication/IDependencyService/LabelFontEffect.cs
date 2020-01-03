using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ProjectApplication.IDependencyService
{
    public class LabelFontEffect : RoutingEffect
    {
        public LabelFontEffect() : base("Xamarin.LabelCustomFontEffect")
        {

        }
    }

    public static class FontEffect
    {
        public static readonly BindableProperty ColorProperty =
            BindableProperty.CreateAttached("Color", typeof(Color), typeof(FontEffect), Color.Black);

        public static Color GetColor(BindableObject view)
        {
            return (Color)view.GetValue(ColorProperty);
        }

        public static void SetColor(BindableObject view, Color value)
        {
            view.SetValue(ColorProperty, value);
        }

        public static readonly BindableProperty FontNameProperty =
  BindableProperty.CreateAttached("FontName", typeof(string), typeof(FontEffect), "materialdesignicons-webfont.ttf", propertyChanged: OnFontNameChanged);

        public static string GetFontName(BindableObject view)
        {
            return (string)view.GetValue(FontNameProperty);
        }

        public static void SetFontName(BindableObject view, string value)
        {
            view.SetValue(FontNameProperty, value);
        }

        static void OnFontNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as View;
            if (view == null)
            {
                return;
            }

            string fontName = (string)newValue;
            if (!string.IsNullOrEmpty(fontName))
            {
                view.Effects.Add(new LabelFontEffect());
            }
            else
            {
                var toRemove = view.Effects.FirstOrDefault(e => e is LabelFontEffect);
                if (toRemove != null)
                {
                    view.Effects.Remove(toRemove);
                }
            }
        }
    }

}
