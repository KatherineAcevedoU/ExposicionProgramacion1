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

namespace DateTimePicker
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //Es un manejador de eventos en C# utilizando WPF. este metodo se invoca cuando la fecha seleccionada 
        //En un control DatePicker cambia.
        //DatePicker_SelectedDateChanged: Es el nombre del metodo que generalmente describe la accion que maneja
        //(Cambio de fecha seleccionada en un DatePicker)
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            
                //Esta linea de codigo almacena el texto actualmente seleccionado en el "ComboBox" a la 
                //variable "t"
                string t  = ComboB.Text;//El punto Text Asigna el valor del texto del "ComboBox"


                 //En esta linea de codigo almacena el texto de la fecha seleccionada en el "DatePicker" "DateP"
                 //En la variable "d"
                string d = DateP.Text;


                //Esta linea de codigo convierte una cadena que contiene una fecha (d) y una hora (t) en un objeto
                //DateTime, almacenando el resultado en la variable dt.
                DateTime dt = DateTime.Parse(d +" "+ t);


                 //Esta linea de codigo muestra la representacion en texto de la fecha y hora almacenada en 
                 //"dt"en el TextBlock llamado "Txtbloc"
                txtBlc.Text = dt.ToString();
            
          
        }

        
    }
}
