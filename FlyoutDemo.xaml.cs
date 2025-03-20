namespace MauiApp1;

public partial class ContetPageTest : FlyoutPage
{
	public ContetPageTest()
	{
		InitializeComponent();
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}