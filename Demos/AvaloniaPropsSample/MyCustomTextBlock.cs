using Avalonia;
using Avalonia.Controls;

namespace AvaloniaPropsSample
{
    public class MyCustomTextBlock : TextBlock
    {

        #region TheText Direct Avalonia Property
        private string? _TheText = null;

        public static readonly DirectProperty<MyCustomTextBlock, string?> TheTextProperty =
            AvaloniaProperty.RegisterDirect<MyCustomTextBlock, string?>
            (
                nameof(TheText),
                o => o.TheText,
                (o, v) => o.TheText = v
            );

        public string? TheText
        {
            get => _TheText;
            set
            {
                SetAndRaise(TheTextProperty, ref _TheText, value);
            }
        }

        #endregion TheText Direct Avalonia Property

    }
}
