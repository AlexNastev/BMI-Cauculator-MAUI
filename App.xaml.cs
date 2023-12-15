using BMICauculatorApp.MVVM.Views;

namespace BMICauculatorApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BMIView();
        }
    }
}
