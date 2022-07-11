using Avalonia;
using Avalonia.Controls;

namespace AvaloniaPropsSample
{
    public class AttachedProps
    {
        #region TheText Attached Avalonia Property
        public static string GetTheText(IControl obj)
        {
            return obj.GetValue(TheTextProperty);
        }

        public static void SetTheText(IControl obj, string value)
        {
            obj.SetValue(TheTextProperty, value);
        }

        public static readonly AttachedProperty<string> TheTextProperty =
            AvaloniaProperty.RegisterAttached<AttachedProps, IControl, string>
            (
                "TheText"
            );
        #endregion TheText Attached Avalonia Property

    }
}
