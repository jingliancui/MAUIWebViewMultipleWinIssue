namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NewWindowsBtn_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(PageNumber.Text); i++)
            {
                Application.Current?.OpenWindow(new Window(new WebPage()));
            }
        }
    }

}
