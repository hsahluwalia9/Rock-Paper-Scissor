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

namespace A6_Group6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new VM();
            DataContext = vm;
        }

        public int randNum;
        int computerChoice;
        bool isClicked;
        bool playersChoiceIsClicked;
        const int rock = 1;
        const int paper = 2;
        const int scissors = 3;

        private void btnScissor_Click(object sender, RoutedEventArgs e)
        {
            if (playersChoiceIsClicked)
            {
                MessageBox.Show("You should click begin to start a game!");
            }
            else
            {
                if (isClicked)
                {
                    vm.playerChoice = scissors;
                    vm.ResultProperty = computerChoice;
                    tbCompChoice.Visibility = System.Windows.Visibility.Visible;
                    playersChoiceIsClicked = true;
                    gameWinner();
                }
                else
                {
                    MessageBox.Show("You should click begin first!");
                }
            }
        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            if (playersChoiceIsClicked)
            {
                MessageBox.Show("You should click begin to start a game!");
            }
            else
            {
                if (isClicked)
                {
                    vm.playerChoice = paper;
                    vm.ResultProperty = computerChoice;
                    tbCompChoice.Visibility = System.Windows.Visibility.Visible;
                    playersChoiceIsClicked = true;
                    gameWinner();
                }
                else
                {
                    MessageBox.Show("You should click begin first!");
                }
            }
        }

        private void btnRock_Click(object sender, RoutedEventArgs e)
        {
            if (playersChoiceIsClicked)
            {
                MessageBox.Show("You should click begin to start a game!");
            }
            else
            {
                if (isClicked)
                {
                    vm.playerChoice = rock;
                    vm.ResultProperty = computerChoice;
                    tbCompChoice.Visibility = System.Windows.Visibility.Visible;
                    playersChoiceIsClicked = true;
                    gameWinner();
                }
                else
                {
                    MessageBox.Show("You should click begin first!");
                }
            }
        }

        private void btnBegin_Click(object sender, RoutedEventArgs e)
        {
            isClicked = true;
            computerChoice = Random();
            playersChoiceIsClicked = false;
            tbCompChoice.Visibility = System.Windows.Visibility.Hidden;
            tbCompMessage.Text = "Please choose an option below.";
            if (computerChoice == 1)
            {
                computerChoice = rock;
            }
            if (computerChoice == 2)
            {
                computerChoice = paper;
            }
            if (computerChoice == 1)
            {
                computerChoice = scissors;
            }
        }

        
        public int Random()
        {
            Random r = new Random();
            randNum = r.Next(1, 4);
            return randNum;
        }

        public void gameWinner()
        {
            if ((computerChoice == rock && vm.playerChoice == scissors) || 
                (computerChoice == scissors && vm.playerChoice == rock))
            {
                MessageBox.Show("Rock wins!");
            }
            if ((computerChoice == paper && vm.playerChoice == scissors) || 
                (computerChoice == scissors && vm.playerChoice == paper))
            {
                MessageBox.Show("Scissors wins!");
            }
            if ((computerChoice == rock && vm.playerChoice == paper) || 
                (computerChoice == paper && vm.playerChoice == rock))
            {
                MessageBox.Show("Paper wins!");
            }
            if ((computerChoice == rock && vm.playerChoice == rock) || 
                (computerChoice == paper && vm.playerChoice == paper) || 
                (computerChoice == scissors && vm.playerChoice == scissors))
            {
                MessageBox.Show("You should play game again to determine the winner!");
            }

        }
    }
}
