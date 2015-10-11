using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PMSchedule
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void CBUserType_Loaded(object sender, RoutedEventArgs e)
        {
            PMDbServiceReference.UserServiceClient userSvc = new PMDbServiceReference.UserServiceClient(); ;
            try
            {
                //userSvc = new PMDbServiceReference.UserServiceClient();
                string[][] userTypes = userSvc.GetData();
            }
            catch (TimeoutException exception)
            {
                Console.WriteLine("Got {0}", exception.GetType());
                userSvc.Abort();
            }
            catch (CommunicationException exception)
            {
                Console.WriteLine("Got {0}", exception.GetType());
                userSvc.Abort();
            }
        }
    }
}
