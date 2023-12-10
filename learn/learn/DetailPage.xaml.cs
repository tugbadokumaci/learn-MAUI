using learn.ViewModel;

namespace learn;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel dvm)
	{
		InitializeComponent();
		this.BindingContext = dvm;
	}

}
