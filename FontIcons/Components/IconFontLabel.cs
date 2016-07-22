using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FontIcons
{
    /// <summary>
    /// This call allows the rendering of icon fonts held within the cc-fonts-4.ttf file on each of the platform projects. Use the IconFont property to set which icon should be used
    /// </summary>
    public class IconFontLabel : Label
    {

        public IconFontLabel ()
        {
            //We need to load the font family for iOS by specifying it here
            FontFamily = "FontAwesome";

            //For android, we set it in the custom rendered in the Droid project under the IconFontLabelRenderer
        }

        public static readonly BindableProperty IconFontProperty = BindableProperty.Create<IconFontLabel, Object> (
                                                                           p => p.IconFont,
                                                                       null,
                                                                       propertyChanged: (bindable,
                                                                                         oldValue,
                                                                                         newValue) => ((IconFontLabel)bindable).SetIconFontText (newValue)
                                                                   );

        /// <summary>
        /// This is the UTF-8 integer or hex representation of the character in the cc-fonts-4.ttf file in the assets folder for Android or the resources folder for iOS e.g. 0xE029 or E029
        /// </summary>
        public Object IconFont {
            get { return (Object)GetValue (IconFontProperty); }
            set { SetValue (IconFontProperty, value); }
        }

        public void SetIconFontText (object o)
        {
            if (o is String) {
                var utf8_ref = Int32.Parse ((String)o, System.Globalization.NumberStyles.HexNumber);
                Text = Char.ConvertFromUtf32 (utf8_ref);
            }

            if (o is Int32) {
                Text = Char.ConvertFromUtf32 ((Int32)o);
            }
        }
    }
}

