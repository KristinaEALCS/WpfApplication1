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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string a;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Scroll_UP_Click(object sender, RoutedEventArgs e)
        {
            a = textBox0.Text;
            textBox0.Text = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = textBox3.Text;
            textBox3.Text = a;
       
        }

        private void Scroll_Down_Click(object sender, RoutedEventArgs e)
        {
            a = textBox3.Text;
            textBox3.Text = textBox0.Text;
            textBox0.Text = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = a;
            

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textBox0.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
} 
