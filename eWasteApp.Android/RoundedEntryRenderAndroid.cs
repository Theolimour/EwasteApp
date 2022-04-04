using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using eWasteApp;
using eWasteApp.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

 [assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRenderAndroid))]
namespace eWasteApp.Droid
{
    [Obsolete]
    public class RoundedEntryRenderAndroid :  EntryRenderer

    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement == null)
            {
                var gradientDrawable = new GradientStrokeDrawable();
                gradientDrawable.SetCornerRadius(10f);
                gradientDrawable.SetStroke(10, Android.Graphics.Color.Gray);
            
                gradientDrawable.SetColor(Android.Graphics.Color.White);
                Control.SetBackground(gradientDrawable);

                Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }
        }

    }

}