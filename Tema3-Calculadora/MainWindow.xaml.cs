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

namespace Tema3_Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            creaBotones();
            Texto_TextBlock.Text = "";
        }
        private void creaBotones()
        { 
            for(int i=1; i<=9; i++)
            {
                    
                    
                    TextBlock numero = new TextBlock
                    {
                        Text = i.ToString()
                        
                    };

                    Viewbox viewbox = new Viewbox();
                    viewbox.Child = numero;

                    Button boton = new Button
                    {
                        Content = viewbox,
                        Tag = i.ToString()
                    };
                    boton.Click += addNumero;
                    botones_UniformGrid.Children.Add(boton);
            }
        }

        private void addNumero(object sender, RoutedEventArgs e)
        {
            Texto_TextBlock.Text += (sender as Button).Tag;
        }
    }
}
