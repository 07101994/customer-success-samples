﻿using Xamarin.Forms;

namespace SecuritySampleApp
{
	public class App : Application
	{
		public App()
		{
			// Create 3 Pages to be included in the main carousel page
			var carouselPage1 = new GatePage("Page 1", 3)
			{
				BackgroundColor = Color.Maroon
			};
			var carouselPage2 = new GatePage("Page 2", 3)
			{
				BackgroundColor = Color.Green
			};
			var carouselPage3 = new GatePage("Page 3", 3)
			{
				BackgroundColor = Color.Fuchsia
			};
			var mainCarouselPage = new CarouselPage
			{
				Children = {
					carouselPage1,
					carouselPage2,
					carouselPage3
				},
				Title = "Carousel Page"
			};
			//Set the Main Page to be the Carousel Page with Navigation capabilities
			MainPage = new NavigationPage(mainCarouselPage);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

