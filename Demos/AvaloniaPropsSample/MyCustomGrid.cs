using Avalonia;
using Avalonia.Controls;

namespace AvaloniaPropsSample
{
    public class MyCustomGrid : Grid
    {

        #region TheText Styled Avalonia Property
        public string TheText
        {
            get { return GetValue(TheTextProperty); }
            set { SetValue(TheTextProperty, value); }
        }

        public static readonly StyledProperty<string> TheTextProperty =
            AvaloniaProperty.Register<MyCustomGrid, string>
            (
                nameof(TheText)
            );
        #endregion TheText Styled Avalonia Property

    }
}
