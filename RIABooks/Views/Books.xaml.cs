namespace RIABooks
{
    using System.Windows.Controls;
    using System.Windows.Navigation;
    using RIABooks.Web.Models;
    using RIABooks.Web.Services;

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

        private void bookDomainDataSource_LoadedData_1(object sender, System.Windows.Controls.LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void authorDomainDataSource_LoadedData_1(object sender, System.Windows.Controls.LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }

            this.bookTypeComboBox.Items.Clear();
            this.bookTypeComboBox.Items.Add(BookType.Fiction);
            this.bookTypeComboBox.Items.Add(BookType.Nonfiction);
        }

        private void addButton_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            var book = new Book { AuthorId = (int)authorComboBox.SelectedValue, BookType = (BookType)bookTypeComboBox.SelectedValue, Title = titleTextBox.Text };
            bookDomainDataSource.DataView.Add(book);
            bookDomainDataSource.SubmitChanges();
        }
    }
}