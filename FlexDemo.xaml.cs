namespace MauiApp1;

public partial class FlexDemo : ContentPage
{
	public FlexDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}