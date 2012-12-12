namespace RIABooks
{
    using System.Windows.Controls;
    using System.Windows.Navigation;
    using RIABooks.Web.Models;

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

        private void authorDomainDataSource_LoadedData_1(object sender, System.Windows.Controls.LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void addAuthorButton_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            var author = new Author { FirstName = firstNameTextBox.Text, LastName = lastNameTextBox.Text };
            authorDomainDataSource.DataView.Add(author);
            authorDomainDataSource.SubmitChanges();
        }
    }
}