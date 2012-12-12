namespace RIABooks
{
    using System.Windows.Controls;
    using System.Windows.Navigation;

    /// <summary>
    /// <see cref="Page"/> class to present information about the current application.
    /// </summary>
    public partial class Authors : Page
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Authors"/> class.
        /// </summary>
        public Authors()
        {
            InitializeComponent();

            this.Title = ApplicationStrings.AuthorsPageTitle;
        }

        /// <summary>
        /// Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}