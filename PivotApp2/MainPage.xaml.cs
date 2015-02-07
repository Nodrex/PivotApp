using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PivotApp2.Resources;
using Windows.UI;
using System.Data.Linq;


namespace PivotApp2
{
    public partial class MainPage : PhoneApplicationPage
    {
        List<string> ls = new List<string>();
        private const string strConnectionString = @"isostore:/Quick_Note_Base.sdf";
        private static int counter = 0;

        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();

            ls.Add("start");
            ls.Add("item 2");
            ls.Add("item 3");
            ls.Add("item 4");
            ls.Add("item 5");
            ls.Add("item 6");
            ls.Add("item 7");
            ls.Add("item 8");
            ls.Add("item 9");
            ls.Add("item 10 test 0123456789ABCDEFGHIJKLMNOP");
            ls.Add("item 11");
            ls.Add("item 12");
            ls.Add("item 13");
            ls.Add("item 14");
            ls.Add("item 15");
            ls.Add("item 16");
            ls.Add("item 17");
            ls.Add("item 18");
            ls.Add("item 19");
            ls.Add("item 20");
            ls.Add("item 21");
            ls.Add("item 22");
            ls.Add("item 23");
            ls.Add("item 24");
            ls.Add("item 25");
            ls.Add("item 26");
            ls.Add("item 27");
            ls.Add("item 28");
            ls.Add("item 29");
            ls.Add("item 30");
            ls.Add("item 31");
            ls.Add("item 32");
            ls.Add("item 33");
            ls.Add("item 34");
            ls.Add("item 35");
            ls.Add("last");

            longListSelector.ItemsSource = ls;

        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void selectItem(object sender, RoutedEventArgs e)
        {
            String item = ((String)((LongListSelector)sender).SelectedItem);
            int indexOfItem = ((LongListSelector)sender).ItemsSource.IndexOf(item);
            //messagbox ok click
            /*
            MessageBoxResult ms = MessageBox.Show(item, "Title", MessageBoxButton.OKCancel);

            if (ms == MessageBoxResult.OK)
            {
                MessageBox.Show("You clicked yes!");
            }
            */
            NavigationService.Navigate(new Uri("/SecondPivotPage.xaml?text="+item, UriKind.Relative));
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            using (DB db = new DB(strConnectionString))
            {
                if (db.DatabaseExists())
                {
                    MessageBox.Show("Base already exists");
                }
                else
                {
                    db.CreateDatabase();
                    MessageBox.Show("Base created");
                }
            }
        }

        private void Button_Add_Item_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DB db = new DB(strConnectionString))
                {
                    if (!db.DatabaseExists())
                    {
                        MessageBox.Show("base does not exists");
                        return;
                    }
                    Note note = new Note();
                    note.Text = "Test note" + counter;

                    db.Notes.InsertOnSubmit(note);
                    db.SubmitChanges();
                    MessageBox.Show("Item is added");
                }
                counter++;
            }
            catch (Exception ex)
            {
                //how to see exception message
                MessageBox.Show("ex");
                Console.WriteLine(ex.InnerException);
            }
        }

        private void Button_Delete_Item_Click(object sender, RoutedEventArgs e)
        {
            using (DB db = new DB(strConnectionString))
            {
                if (!db.DatabaseExists())
                {
                    MessageBox.Show("base does not exists");
                    return;
                }
                IQueryable<Note> NoteQuery = from NOTE in db.Notes where NOTE.Text == "Test note0" select NOTE;
                Note note = NoteQuery.FirstOrDefault();
                if (note == null)
                {
                    MessageBox.Show("item does not exists");
                    return;
                }
                db.Notes.DeleteOnSubmit(note);
                db.SubmitChanges();
                MessageBox.Show("item is deleted");
            }
        }

        private void Button_Get_All_Data_From_Base_Click(object sender, RoutedEventArgs e)
        {
            IList<Note> NoteList = null;
            using (DB db = new DB(strConnectionString))
            {
                if (!db.DatabaseExists())
                {
                    MessageBox.Show("base does not exists");
                    return;
                }
                IQueryable<Note> NoteQuery = from NOTE in db.Notes select NOTE;
                NoteList = NoteQuery.ToList();
            }
            string str = "";
            foreach (Note item in NoteList)
            {
                str += item.Text + System.Environment.NewLine;
            }
            str += "last str hardcoded";
            MessageBox.Show(str);
        }

        private void Button_Delete_Base_Click(object sender, RoutedEventArgs e)
        {
            using (DB db = new DB(strConnectionString))
            {
                if (db.DatabaseExists())
                {
                    db.DeleteDatabase();
                    MessageBox.Show("base is deleted");
                }
                else
                {
                    MessageBox.Show("base does not exists");
                }
            }
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}