namespace espwebserversteuerung
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent(); // Ohne das wird das XAML nicht geladen
        }

        private readonly WebServerController controller = new WebServerController();

        private async void On(object sender, EventArgs e)
        {
            string url = "http://172.16.221.90/l1"; // IP deines Servers
            string response = await controller.SendGetAsync(url);
            displaylbl.Text = response;
        }
        private async void Off(object sender, EventArgs e)
        {
            string url = "http://172.16.221.90/l0"; // IP deines Servers
            string response = await controller.SendGetAsync(url);
            displaylbl.Text = response;
        }

    }

}
