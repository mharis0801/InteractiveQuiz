using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Interactive_Quiz
{
    public partial class MainPage : ContentPage
    {
        public Quiz quiz = new Quiz();
        public MainPage()
        {
            
            InitializeComponent();

            
        }

        void A1Butt_Clicked(System.Object sender, System.EventArgs e)
        {
            Button button = sender as Button;




        }

        void NextButt_Clicked(System.Object sender, System.EventArgs e)
        {
            quiz.GetNextQuestion();
        }

    }
}
