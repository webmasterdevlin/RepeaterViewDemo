using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RepeaterViewDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BindingContext = new MainViewModel();
		}

	    private void OnTap_Student(object sender, EventArgs e)
	    {
	        var view = sender as View;

	        var employee = view?.BindingContext as string;

	        DisplayAlert("Tap Event", "You have selected " + employee, "Ok");
	    }

	    private void OnTap_Employee(object sender, EventArgs e)
	    {
	        var view = sender as View;

	        var student = view?.BindingContext as string;

	        DisplayAlert("Tap Event", "You have selected " + student, "Ok");

            var vm = BindingContext as MainViewModel;

	        vm.SelectStudentCommand.Execute(student);
	    }
    }
}
