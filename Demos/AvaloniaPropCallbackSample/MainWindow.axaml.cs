using Avalonia;
using Avalonia.Controls;
using System;

namespace AvaloniaPropsSample
{
    public partial class MainWindow : Window
    {
        private IDisposable? _subscription;

        public MainWindow()
        {
            InitializeComponent();

            ConnectButton.Click += ConnectButton_Click;
            DisconnectButton.Click += DisconnectButton_Click;
        }

        private void ConnectButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            _subscription?.Dispose();
            _subscription = null;

            _subscription =
                AttachedProps.TheTextProperty.Changed.Subscribe(OnValueChanged);

            // if you do not need old value
            //this.GetObservable(AttachedProps.TheTextProperty).Subscribe(...)
        }
        private void DisconnectButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            _subscription?.Dispose();
            _subscription = null;
        }

        private void OnValueChanged(AvaloniaPropertyChangedEventArgs<string> args)
        {
            this.BottomText.Text = args.NewValue.Value;
        }
    }
}
