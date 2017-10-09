using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemoUITest
{
    public partial class MainPage : ContentPage
    {
        ViewModel VM;
        public MainPage()
        {
            InitializeComponent();
            //VM = new ViewModel();
            //BindingContext = VM;
        }

        private void cmdAddClicked(object sender, EventArgs e)
        {
            //VM.Add();
            int result = Int32.Parse(txtValueA.Text) + Int32.Parse(txtValueB.Text);
            lblResult.Text = result.ToString();
        }

        private void cmdMultiplyClicked(object sender, EventArgs e)
        {
            //VM.Multiply();
            int result = Int32.Parse(txtValueA.Text) * Int32.Parse(txtValueB.Text);
            lblResult.Text = result.ToString();
        }
    }
}
