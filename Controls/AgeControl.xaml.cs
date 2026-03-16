using System.Windows;
using System.Windows.Controls;

namespace StudentApp.Controls
{
    public partial class AgeControl : UserControl
    {
        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(int), typeof(AgeControl),
                new PropertyMetadata(18));

        public int MinAge { get; set; } = 18;

        public int MaxAge { get; set; } = 60;

        public AgeControl()
        {
            InitializeComponent();
        }

        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            if (Age < MaxAge)
                Age++;
        }

        private void Decrease_Click(object sender, RoutedEventArgs e)
        {
            if (Age > MinAge)
                Age--;
        }
    }
}