namespace MauiAppzzz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var x = Resources.MergedDictionaries;
            MainPage = new AppShell();
        }
    }
}