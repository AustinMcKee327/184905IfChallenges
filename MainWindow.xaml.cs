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

namespace _184905IfChallenges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CaseCheck_Click(object sender, RoutedEventArgs e)
        {
            char Letter = LetterBox.Text[0];
            int LetterValue = (int)Letter;
            if ((int)Letter >= 65 && (int)Letter <= 90)
            {
                OutputLabel.Content = "This is a Uppercase letter.";
            }
            else if ((int)Letter >=97 && (int)Letter <=122)
            {
                OutputLabel.Content = "This is a Lowercase letter";
            }
            else
            {
                OutputLabel.Content = "This is not a vaild character.";
            }
        }

        private void EvenOddChecker_Click(object sender, RoutedEventArgs e)
        {

            int Number;
            int.TryParse(DivideBox.Text, out Number);
            
            if(Number %2 == 0)
            {
                OutputLabel.Content = "This is an Even Number";
            }
            else
                OutputLabel.Content = "This is an Odd number";            
                
            
        }

        private void CharacterTypeChecker_Click(object sender, RoutedEventArgs e)
        {
            char Value = CharacterTypeBox.Text[0];
            int LetterValue = (int)Value;
            if ((int)Value >= 65 && (int)Value <= 90 || (int)Value >= 97 && (int)Value <= 122)
            {
                OutputLabel.Content = "This is a Letter type symbol";
            }
            else if ((int)Value >= 48 && (int)Value <= 57)
            {
                OutputLabel.Content = "This is a Digit type symbol";
            }
            else
            {
                OutputLabel.Content = "This is s Symbol type symbol";
            }
           
        }

        private void VowelButton_Click(object sender, RoutedEventArgs e)
        {
            VowelChecker.Text = VowelChecker.Text.ToLower();
            char TheLetter = VowelChecker.Text[0];

            bool isVowel = false;

            if (TheLetter == 'a')
            {
                isVowel = true;
            }
            else if (TheLetter == 'e')
            {
                isVowel = true;
            }
            else if (TheLetter == 'i')
            {
                isVowel = true;
            }
            else if (TheLetter == 'o')
            {
                isVowel = true;
            }
            else if (TheLetter == 'u')
            {
                isVowel = true;
            }
            else
            {
                isVowel = false;
            }
            if (isVowel)
            {
                OutputLabel.Content = "Vowel"; 
            }
            else
            {
                OutputLabel.Content = "Consonant";
            }
           
        }

        private void AlphabetChecker_Click(object sender, RoutedEventArgs e)
        {
            char Alphabet = AlphabetBox.Text[0];
            int LetterValue = (int)Alphabet;
            if ((int)Alphabet >= 65 && (int)Alphabet <= 90 || (int)Alphabet >= 97 && (int)Alphabet <= 122)
            {
                OutputLabel.Content = "This is a Letter";
            }
            else
            {
                OutputLabel.Content = "This is not in the Alphabet";
            }
        }
    }
}
