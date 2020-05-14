using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Diagnostics;

namespace Todo.Views
{
    public class TodoListView : UserControl
    {
        public TodoListView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle click here.
            //MessageBox.Avalonia.BaseWindows.

            Trace.WriteLine("click");
        }
    }
}
