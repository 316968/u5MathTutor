/*Quinn Parker-Joyes
May 30 2019
ics3u
math tutor program*/


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

namespace U5MathTutor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Random r = new Random();
        double text;
        double q1;
        double q2;
        double correct;
        int selected;
        //bool abool;

        public MainWindow()
        {
            InitializeComponent();
            selected = r.Next(1, 5);
           // int.TryParse(txtInput.Text, out text);

            lblQuestion.Content = "";
            q1 = r.Next(1, 10);
            q2 = r.Next(1, 10);
            double tempDivide = q1 / q2;
            
            double tempSub;
            if(selected == 1 && (q1 - q2) < 0)
            {
                tempSub = q1;
                q1 = q2;
                q2 = tempSub;
            }
            if(tempDivide.ToString().Length > 5)
            {
                selected = r.Next(1, 3);
            }
            if (selected == 4)
            {
                lblQuestion.Content = q1 + "/" + q2;
                correct = Math.Round(tempDivide, 1);
            }
            else if (selected == 2)
            {
                lblQuestion.Content = q1 + "+" + q2;
                correct = q1 + q2;
            }
            else if (selected == 3)
            {
                lblQuestion.Content = q1 + "*" + q2;
                correct = q1 * q2;
            }
            else if (selected == 1)
            {
                lblQuestion.Content = q1 + "-" + q2;
                correct = q1 - q2;
            }
        }

        private void btnTutor_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtInput.Text, out text);
            if (text == correct)
            {
                
                MessageBox.Show("correct");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("incorrect. the an");
                this.Close();
            }
        }
    }
}
