using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Todo.Views
{
    public class Buttons : Window
    {
        private Button myButton;

        public Buttons()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            myButton = this.FindControl<Button>("myButton");
        }

        public void MyButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle click here.
        }
    }
}
