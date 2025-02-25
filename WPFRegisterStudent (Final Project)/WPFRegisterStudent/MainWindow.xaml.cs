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

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;
        int totalCredit = 0; //initialize totalCredit at class level so it will get updated

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");


            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);


            this.textBox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem);
            int credit = 3; //make credit hours variable

            if (choice == null) //if there is no course selected
            {
                label3.Content = "You must select a course to add to the registration."; //output error message (in label3 box) telling user to select a course
                label3.Foreground = Brushes.Red; //output the message in red to indicate error
                return;
            }

            else //if there is a course selected
            {
                if (choice.IsRegisteredAlready() == true) //check if the course is already registered
                {
                    label3.Content = ($"You have already registered for {choice.getName()}."); //output error message (in label3 box) telling user they have already registered for the course
                    label3.Foreground = Brushes.Red; //output the message in red to indicate error
                    return;
                }

                else //if the course is not already registered
                {
                    totalCredit += credit; //add credit hours to totalCredit

                    if (totalCredit > 9) //check if totalCredit is greater than 9
                    {
                        label3.Content = ("You cannot register for more than 9 credit hours."); //output error message (in label3 box) telling user they cannot register for more than 9 credit hours
                        label3.Foreground = Brushes.Red; //output the message in red to indicate error
                        return;
                    }

                    else //totalCredit is less than or equal to 9
                    {
                        choice.SetToRegistered(); //set course to registered
                        label3.Content = ($"You have registered for {choice.getName()}."); //output message (in label3 box) telling user they have registered for the course
                        listBox.Items.Add(choice); //add course to listBox
                        label3.Foreground = Brushes.Green; //output the message in green to indicate success
                        textBox.Text = totalCredit.ToString(); //output totalCredit to textBox
                        return;
                    }
                }
            }
        }
    }
}
