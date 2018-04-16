using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mrealtime
{
	public partial class MainPage : ContentPage
	{
        ObservableCollection<Model.tdpdata> list = new ObservableCollection<Model.tdpdata>();
		public MainPage()
		{
			InitializeComponent();
            _lst.BindingContext = list;
		} 

        public async void Handle_Cliked(Object sender, System.EventArgs e)
        {
            var db = new Database.DBFire();
            var listAsync = await db.getList();
            System.Console.WriteLine("D: cry cry it");
            if (list != null)
            {
                foreach (var item in listAsync)
                {
                    list.Add(item);
                }
                //_lst.BindingContext = list;
            }
        }
	}
}
