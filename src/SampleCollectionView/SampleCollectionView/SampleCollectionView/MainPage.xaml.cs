using Xamarin.Forms;

namespace SampleCollectionView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CollectionView.ItemsSource = new[]
                                         {
                                             "avator.jpg",
                                             "avator.jpg",
                                             "avator.jpg",
                                             "avator.jpg"
                                         };
        }
    }
}
