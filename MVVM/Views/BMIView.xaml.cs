using BMICauculatorApp.MVVM.ViewModels;

namespace BMICauculatorApp.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}