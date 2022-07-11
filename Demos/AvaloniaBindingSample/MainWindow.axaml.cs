using Avalonia.Controls;
using System;

namespace AvaloniaBindingSample
{
    public partial class MainWindow : Window
    {
        private IDisposable? _subscription;

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
