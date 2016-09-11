using System.Windows;
using Logic;

namespace TradeshiftAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ErrorInput = "Lenght of side {0} should be a positive integer value";

        private void BtnResultClicked(object sender, RoutedEventArgs e)
        {
            LblResult.Content = string.Empty;
            int sideA, sideB, sideC;
            var aIsInteger = int.TryParse(TxtA.Text, out sideA);
            var bIsInteger = int.TryParse(TxtB.Text, out sideB);
            var cIsInteger = int.TryParse(TxtC.Text, out sideC);
            if (aIsInteger && bIsInteger && cIsInteger)
                LblResult.Content = TriangleLogic.GetTriangleType(sideA, sideB, sideC).ToString();
            else
            {
                var message = string.Empty;
                if (!aIsInteger)
                {
                    message += string.Format(ErrorInput, "A");
                    TxtA.Text = string.Empty;
                }
                if (!bIsInteger)
                {
                    if (!string.IsNullOrWhiteSpace(message))
                        message += "\n";
                    message += string.Format(ErrorInput, "B");
                    TxtB.Text = string.Empty;
                }
                if (!cIsInteger)
                {
                    if (!string.IsNullOrWhiteSpace(message))
                        message += "\n"; 
                    message += string.Format(ErrorInput, "C");
                    TxtC.Text = string.Empty;
                }

                MessageBox.Show(Application.Current.MainWindow, message);
            }
        }
        

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}