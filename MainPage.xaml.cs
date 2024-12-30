namespace WebViewReproductionApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 

            // Problem occur because of "&  => %26"
            webView.Source = "https://github.com/Pelinalpp/TestFiles/blob/main/01-A%C4%9F-Sistem%20Bilgi%20G%C3%BCvenli%C4%9Fi%20Md/Ortak%20Rehberler/Change%20Password%20Guide.pdf";


        }
    }
    

}
