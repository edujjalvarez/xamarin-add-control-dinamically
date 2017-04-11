using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xam.Test.View
{
    public partial class XamTest1View : ContentPage
    {
        public XamTest1View()
        {
            InitializeComponent();
        }

        private void BtnAddItem_Clicked(object sender, EventArgs e)
        {
            Grid grid = new Grid
            {
                BackgroundColor = Color.BurlyWood,
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto }, // Fila 0
                    new RowDefinition { Height = GridLength.Auto }, // Fila 1
                    new RowDefinition { Height = GridLength.Auto }, // Fila 2
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }, //Columna 0
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }, //Columna 1
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }, //Columna 2
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }, //Columna 3
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }, //Columna 4
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }, //Columna 5
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }, //Columna 6
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }, //Columna 7
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }, //Columna 8
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }, //Columna 9
                }
            };

            // Agrego Entry en la fila 0 expandida 8 columnas
            Entry entry1 = new Entry
            {
                Placeholder = "Buscar..."
            };
            grid.Children.Add(entry1, 0, 8, 0, 1);

            // Agrego un boton de búsqueda en la fila 0 columna 8 expandida 2 columanas
            Button button1 = new Button
            {
                FontSize = 10,
                Text = "Buscar"
            };
            button1.Clicked += async (sender2, args) =>
            {
                await DisplayAlert("Notificación", string.Format("Texto: {0}", entry1.Text), "Ok");
            };
            grid.Children.Add(button1, 8, 10, 0, 1);
            
            //Agrego un Entry para mostrar el valor del Stepper
            Entry entry2 = new Entry
            {
                Text = "1"
            };
            grid.Children.Add(entry2, 0, 5, 1, 2);

            //Agrego Stepper
            Stepper stepper1 = new Stepper
            {
                Minimum = 1,
                Maximum = 100,
                Value = 1,
                Increment = 1
            };
            stepper1.ValueChanged += (sernder3, args3) =>
            {
                entry2.Text = args3.NewValue.ToString();
            };
            grid.Children.Add(stepper1, 5, 10, 1, 2);

            // Agrego el grid creado al StackLayout
            SLXamTest1.Children.Add(grid);
        }
    }
}
