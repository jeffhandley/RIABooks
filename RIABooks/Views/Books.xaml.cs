namespace RIABooks
{
    using System.Windows.Controls;
    using System.Windows.Navigation;

    /// <summary>
    /// Home page for the application.
    /// </summary>
    public partial class Books : Page
    {
        /// <summary>
        /// Creates a new <see cref="Books"/> instance.
        /// </summary>
        public Books()
        {
            InitializeComponent();

            this.Title = ApplicationStrings.BooksPageTitle;
        }

        /// <summary>
        /// Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}