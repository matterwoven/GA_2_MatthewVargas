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

namespace GA_2_MatthewVargas
{
      /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Buttons, Labels, and TextBoxes

        public MainWindow()
        {
            InitializeComponent();
        } // MainWindow()

        // Display a full name in a Message Box

        private void btnFullName_Click(object sender, RoutedEventArgs e)
        {
            //DisplayFullName();
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string concatenate = firstName + " " + lastName;

            MessageBox.Show(concatenate);

        } // btnFullName_Click

        // Organizing my code into methods
        public void DisplayFullName()
        {
            // Declare two string variables to hold our first and last name
            //bool firstNameNotEmpty = txtFirstName.Text != "";
            //bool lastNameNoteEmpty = txtLastName.Text != "";

            bool nameBoxesNotEmpty = ValidateTextBoxes(txtFirstName.Text, txtLastName.Text);

            if (nameBoxesNotEmpty)
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;

                // Declare a third string, full name
                // Concatenate ( combine ) the first and last name into one long string
                string fullName = $"{firstName} {lastName}";

                // Display full name on button click
                MessageBox.Show(fullName);
            }
            else
            {
                MessageBox.Show("Please enter your first and last name in the text boxes");
            }
        } // DisplayFullName

        public bool ValidateTextBoxes(string textBox1, string textBox2)
        {
            bool textBox1NotEmpty = textBox1 != "";
            bool textBox2NotEmpty = textBox2 != "";

            return textBox1NotEmpty && textBox2NotEmpty;
        } // ValidateTextBoxes

        //---------------------------------------------------------

        // Add or Subtract Two Numbers - Display in a text box

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddMethod();

            string plus = "+";
            plusorminus.Content = plus;
        }

        public void AddMethod()
        {
            string number1String = txtNumber1.Text;
            string number2String = txtNumber2.Text;

            bool numbersAreNotEmpty = ValidateTextBoxes(number1String, number2String);

            if (numbersAreNotEmpty)
            {
                //double number1 = double.Parse(number1String);
                //double number2 = double.Parse(number2String);

                double number1 = 0;
                double number2 = 0;

                bool number1IsANumber = double.TryParse(number1String, out number1);
                bool number2IsANumber = double.TryParse(number2String, out number2);

                bool bothAreNumbers = number1IsANumber && number2IsANumber;

                if (bothAreNumbers)
                {
                    // Display the full equation and result to the label, lblEquation
                    // Example :
                    // If number 1 is 20, and number 2 is 10, and they add the numbers, we will display
                    // 20 + 10 = 30

                    double result = number1 + number2;

                    string formattedResult = $"{number1} + {number2} = {result}";
                    lblEquation.Text = formattedResult;

                }
                else
                {
                    MessageBox.Show("Please enter 2 VALID numbers");
                }


            }
            else
            {
                MessageBox.Show("Please enter in 2 numbers");
            }
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            SubtractMethod();
            string minus = "-";
            plusorminus.Content = minus;
        }

        public void SubtractMethod()
        {
            string number1String = txtNumber1.Text;
            string number2String = txtNumber2.Text;

            bool numbersAreNotEmpty = ValidateTextBoxes(number1String, number2String);

            if (numbersAreNotEmpty)
            {
                //double number1 = double.Parse(number1String);
                //double number2 = double.Parse(number2String);

                double number1 = 0;
                double number2 = 0;

                bool number1IsANumber = double.TryParse(number1String, out number1);
                bool number2IsANumber = double.TryParse(number2String, out number2);

                bool bothAreNumbers = number1IsANumber && number2IsANumber;

                if (bothAreNumbers)
                {
                    // Display the full equation and result to the label, lblEquation
                    // Example :
                    // If number 1 is 20, and number 2 is 10, and they add the numbers, we will display
                    // 20 + 10 = 30

                    double result = number1 - number2;

                    string formattedResult = $"{number1} - {number2} = {result}";
                    lblEquation.Text = formattedResult;

                }
                else
                {
                    MessageBox.Show("Please enter 2 VALID numbers");
                }


            }
            else
            {
                MessageBox.Show("Please enter in 2 numbers");
            }
        }
        //----------------------------------------------

        // Display a single character from a Word in a Label

        private void BtnDisplayLetter_Click(object sender, RoutedEventArgs e)
        {
            DisplayCharacterMethod();
        } // btnDisplayLetter_Click

        public void DisplayCharacterMethod()
        {
            // Validate if Text Boxes are empty
            string word = txtWord.Text;
            string characterNumber = txtCharIndex.Text;
            bool boxesAreNotEmpty = ValidateTextBoxes(word, characterNumber);

            if (boxesAreNotEmpty)
            {
                // Check if valid number entered
                int selectedCharacter = -1;
                bool isCharacterSelected = int.TryParse(characterNumber, out selectedCharacter);

                // Check if number is in range
                // All arrays START at an index of 0
                // All arrays Last Index is array.Length - 1
                // We need to make sure the number entered is between 0 and array.Length - 1
                // All strings are arrays

                int numberOfCharacters = word.Length;
                bool numberInRange = selectedCharacter > 0 && selectedCharacter < numberOfCharacters;

                if (numberInRange)
                {
                    char selectedChar = word[selectedCharacter];
                    txtDisplayLetter.Text = selectedChar.ToString();
                }
                else
                {
                    MessageBox.Show($"Please enter a valid number in between 0 and {numberOfCharacters - 1}");
                }


            }
            else
            {
                MessageBox.Show("Enter a word and number");
            }


        } // DisplayCharacterMethod

        private void TxtWord_TextChanged(object sender, TextChangedEventArgs e)
        {
            string usersWord = txtWord.Text;
            int stringLength = usersWord.Length;
            int lastIndex = stringLength - 1;
            string formatedString = $"Enter a number between 0 and {lastIndex}";

            lblNumberOfLetters.Content = formatedString;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtCharIndex_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    } // class

} // namespace

