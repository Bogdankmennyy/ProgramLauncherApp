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
using System.Diagnostics;


namespace ProgramLauncherApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LaunchNotepad_Click(object sender, RoutedEventArgs e)
        {
            StartProcess("notepad.exe");
        }

        private void LaunchCalculator_Click(object sender, RoutedEventArgs e)
        {
            StartProcess("calc.exe");
        }

        private void LaunchPaint_Click(object sender, RoutedEventArgs e)
        {
            StartProcess("mspaint.exe");
        }

        private void LaunchCustomProgram_Click(object sender, RoutedEventArgs e)
        {
            // Замініть шлях і назву власної програми
            StartProcess(@"""C:\Users\bogda\Downloads\abstract-surface-and-textures-of-white-concrete-stone-wall_74190-8189.avif""");
        }

        private void StartProcess(string processFileName)
        {
            try
            {
                Process.Start(processFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка запуску програми: {ex.Message}");
            }
        }
    }
}
