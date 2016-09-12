using System.Windows;
using Logic;

namespace UI
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
            var aIsInteger = int.TryParse(TxtA.Text, out sideA) && sideA >0;
            var bIsInteger = int.TryParse(TxtB.Text, out sideB) && sideB >0;
            var cIsInteger = int.TryParse(TxtC.Text, out sideC) && sideC >0;
            if (aIsInteger && bIsInteger && cIsInteger)
                LblResult.Content = TriangleLogic.GetTriangleType(sideA, sideB, sideC).ToString();
            else
            {
                var message = string.Empty;
                if (!aIsInteger)
                {
                    TxtA.Text = string.Empty;
                    message += string.Format(ErrorInput, "A");
                    TxtA.Text = string.Empty;
                }
                if (!bIsInteger)
                {
                    TxtB.Text = string.Empty;
                    if (!string.IsNullOrWhiteSpace(message))
                        message += "\n";
                    message += string.Format(ErrorInput, "B");
                    TxtB.Text = string.Empty;
                }
                if (!cIsInteger)
                {
                    TxtC.Text = string.Empty;
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