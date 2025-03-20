namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";
            if (count == 5)
            {
                CounterBtn.BackgroundColor = Colors.Red;

            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void SHow_Flyout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContetPageTest());
        }
        private void FlexDemo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexDemo());
        }
    }

}
