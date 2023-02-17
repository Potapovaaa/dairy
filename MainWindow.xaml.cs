using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ежедневниквпф
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       /* List<classnotes> Notes = new List<classnotes>();*/
        List<string> Notes=new List<string>();
        public string spisok;
        private object txtSearch;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void createbutton1_Click(object sender, RoutedEventArgs e)
        {
            /*            classnotes note = new classnotes();
                        note.Name = name.Text;
                        note.Content = opisanie.Text;
                        note.Date = Convert.ToDateTime(data.Text);
                        Notes.Add(note);*/

            classnotes note = new classnotes();
            spisok = name.Text;
            Notes.Add(spisok);
            notepole.ItemsSource = null;
            notepole.ItemsSource= Notes;

           

        }

        private void redactbutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deletebutton_Click(object sender, RoutedEventArgs e)
        {
            notepole.ItemsSource = null;

        }


        private void notepole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void opisanie_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
