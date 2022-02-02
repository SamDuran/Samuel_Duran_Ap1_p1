using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Samuel_Duran_Ap1_p1_
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_DispatcherUnhandledException(object sander, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e){
            MessageBox.Show($"Ocurrio un error... {e.Exception.Message}", "Unhandled Error", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled=true;
        }
    }
}
