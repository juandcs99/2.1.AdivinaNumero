﻿using System;
using System.Windows;

namespace _2._1.AdivinaNumero
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Numero = GenerarAleatorio();
        }

        public int Numero { get; private set; }

        private int GenerarAleatorio()
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 101);
            return numero;

        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(numeroTextBox.Text) < Numero) pistaTextBlock.Text = "Te has quedado corto.";

                else if (int.Parse(numeroTextBox.Text) == Numero)
                {
                    pistaTextBlock.Text = "¡HAS ACERTADO!";
                }
                else pistaTextBlock.Text = "Te has pasado.";
            } catch(FormatException)
            {
                pistaTextBlock.Text = "Introduce un valor númerico";
            }
               
            }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            Numero = GenerarAleatorio();
            numeroTextBox.Text = "";
            // numeroTextBox.Clear();
            pistaTextBlock.Text = "";
            // pistaTextBlock.Clear();
        }
    }
}

