using Xamarin.Forms;
using System.Threading.Tasks;
using System;
using SwitchingTabbedPageDemo.Views;

namespace SwitchingTabbedPageDemo {
	public class MainTabbedPage : TabbedPage {

		public MainTabbedPage() {

			var twitter = new NavigationPage(new TwitterPage()) {
				Title = "Twitter",
				Icon = "square.png"
			};

			var instagram = new NavigationPage(new InstagramPage()) {
				Title = "Instagram",
				Icon = "circle.png" 
			};

			var facebook = new NavigationPage (new FacebookPage ()) { 
				Title = "Facebook",
				Icon = "square.png"
			};

			Children.Add (twitter);
			Children.Add (instagram);
			Children.Add (facebook);
		}
	}
}