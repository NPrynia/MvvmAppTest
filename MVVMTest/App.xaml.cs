using MVVMTest.Models;
using MVVMTest.Stores;
using MVVMTest.ViewModels;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MVVMTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ReservationBook reservationBook = new ReservationBook();
            reservationBook.addReservation(new Reservation(new RoomID(1, 2), "Priani",
                new DateTime(2023, 12, 12),
            new DateTime(2023, 12, 20)));
            reservationBook.addReservation(new Reservation(new RoomID(2, 4), "Priani",
               new DateTime(2023, 12, 1),
            new DateTime(2023, 12, 25)));
            reservationBook.addReservation(new Reservation(new RoomID(3, 6), "Mishel",
               new DateTime(2023, 12, 2),
               new DateTime(2023, 12, 12)));


            NavigationStore navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new ReservationListingViewModel();
            Hotel hotel = new Hotel("mY HOTEL", reservationBook);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        
    }

}
