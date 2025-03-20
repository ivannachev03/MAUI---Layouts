namespace MauiApp1;

public partial class AbsoluteLayoutDemo : ContentPage
{
	public AbsoluteLayoutDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());

    }
}