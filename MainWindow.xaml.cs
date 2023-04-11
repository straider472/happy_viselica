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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace happy_viselica
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            methods_dictionary = new Dictionary<string, myDeleg>()
        {
            { "btA", Reshenie}, {"btB" , Reshenie}, {"btV" , Reshenie}, {"btG" , Reshenie}, {"btD" , Reshenie},
            {"btE" , Reshenie}, {"btYO" , Reshenie}, {"btJ" , Reshenie}, {"btZ" , Reshenie}, {"btI" , Reshenie},
            {"btIKR" , Reshenie}, {"btK" , Reshenie}, {"btL" , Reshenie}, {"btM" , Reshenie}, {"btN" , Reshenie},
            {"btO" , Reshenie}, {"btP" , Reshenie}, {"btR" , Reshenie}, {"btS" , Reshenie}, {"btT" , Reshenie},
            {"btU" , Reshenie}, {"btF" , Reshenie}, {"btH" , Reshenie}, {"btC" , Reshenie}, {"btCH" , Reshenie},
            {"btSH" , Reshenie}, {"btSHI" , Reshenie}, {"btTVERD" , Reshenie}, {"btMIGH" , Reshenie},
            {"btYE" , Reshenie}, {"btYU" , Reshenie}, {"btYA" , Reshenie}
        };  // инициализация словаря
        }
        private List<char> Word1 = new List<char>();
        public delegate void myDeleg(RoutedEventArgs e, char s);  // делегат для хранения методов
        private Dictionary<string, myDeleg> methods_dictionary; // словарь с функциями и ключами по названию кнопок
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            Random rnd = new Random();
            string[] fruit = { "банан", "авокадо", "личи", "ананас", "папайя" };
            string _word = fruit[rnd.Next(0, 5)];
            int count = _word.Length;
            Word1.Clear();
            for (int i = 0; i < count; i++)
            {
                Word1.Add(_word[i]);
            }
            var obj = e.OriginalSource as Label;
            lb1.Content = Word1[0];
            switch (count)
            {
                case 4:

                    lb5.Visibility = Visibility.Collapsed;
                    lb6.Visibility = Visibility.Collapsed;
                    lb7.Visibility = Visibility.Collapsed;
                    lb4.Content = Word1[3];
                    break;
                case 5:
                    lb5.Visibility = Visibility.Visible;
                    lb6.Visibility = Visibility.Collapsed;
                    lb7.Visibility = Visibility.Collapsed;
                    lb5.Content = Word1[4];
                    break;
                case 6:
                    lb5.Visibility = Visibility.Visible;
                    lb6.Visibility = Visibility.Visible;
                    lb7.Visibility = Visibility.Collapsed;
                    lb6.Content = Word1[5];
                    break;
                case 7:
                    lb5.Visibility = Visibility.Visible;
                    lb6.Visibility = Visibility.Visible;
                    lb7.Visibility = Visibility.Visible;
                    lb7.Content = Word1[6];
                    break;
            }
            lbproverka.Content = _word;
        }

        private void Vibor_Click(object sender, RoutedEventArgs e)
        {
            List<char> word = Word1;
            var obj = e.OriginalSource as Button;
            foreach (var item in methods_dictionary)
	            {
                    if (obj.Name == item.Key)
                        {
                            item.Value(e, Convert.ToChar(obj.Uid));
                            break;
                        }
	            }
        }

        public void Reshenie(RoutedEventArgs e, char a)
        {
            
            for(int i =1; i<Word1.Count - 1; i++)
            {
                switch (i)
                {
                    case 1:
                        if (Word1[i] == a)
                            lb2.Content = a; 
                        break;
                    case 2:
                        if (Word1[i] == a)
                            lb3.Content = a;
                        break;
                    case 3:
                        if (Word1[i] == a)
                            lb4.Content = a;
                        break;
                    case 4:
                        if (Word1[i] == a)
                            lb5.Content = a;
                        break;
                    case 5:
                        if (Word1[i] == a)
                            lb6.Content = a;
                        break;
                    case 6:
                        if (Word1[i] == a)
                            lb6.Content = a;
                        break;

                }
            }


        }
        private void Clear()
        {
            lb1.Content = null;
            lb2.Content = null;
            lb3.Content = null;
            lb4.Content = null;
            lb5.Content = null;
            lb6.Content = null;
            lb7.Content = null;
        }

    }
}
