using learn.ViewModel;
namespace learn;

public partial class ResourcePage : ContentPage
{
    int count = 0;

    public ResourcePage(ResourceViewModel rvm)
	{
		InitializeComponent();
		this.BindingContext = rvm;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		CounterBtn.TextColor = (Color)Resources["myRedColor"];
		Resources["myRedColor"] = Colors.Yellow; // buradan da yazma yapabilirim.
		count++;
		if (count == 1)
			CounterBtn.Text = $"Clicked {count} times";
		else
			CounterBtn.Text = $"Clicked {count} times";
		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
