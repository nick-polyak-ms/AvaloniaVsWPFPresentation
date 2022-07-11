using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using System;

namespace AvaloniaCommandSample
{
    public partial class MainWindow : Window
    {
        IDisposable _subscription;

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
