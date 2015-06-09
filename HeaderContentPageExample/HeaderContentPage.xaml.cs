using Xamarin.Forms;

namespace HeaderContentPageExample
{
    public partial class HeaderContentPage : ContentPage
    {
        private View _mainContent;

        public HeaderContentPage()
        {
            InitializeComponent();
        }

        public View MainContent
        {
            get { return _mainContent; }

            set
            {
                if (_mainContent != value)
                {
                    _mainContent = value;
                    MainContentContainer.Children.Clear();
                    MainContentContainer.Children.Add(_mainContent);

                    OnPropertyChanged("MainContent");
                }
            }
        }
    }
}

