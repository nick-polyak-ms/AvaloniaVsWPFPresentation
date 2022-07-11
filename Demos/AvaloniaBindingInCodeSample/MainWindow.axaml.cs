using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using System;

namespace AvaloniaBindingInCodeSample
{
    public partial class MainWindow : Window
    {
        IDisposable _subscription;

        public MainWindow()
        {
            InitializeComponent();

            // deleting subscription would unbind. 
            _subscription = TopText.Bind(TextBlock.TextProperty, this.GetObservable(AttachedProps.TheTextProperty));

            // bind without being able to unbind
            BottomText[!TextBlock.TextProperty] = TopText[!TextBlock.TextProperty];
        }
    }
}
