//using AndroidX.Core.View;

namespace First_MAUI_Application;

public class TestPage : ContentPage
{
	Label labelCounter;
	Button buttonCounter;
	int count;

	
	
	public TestPage()
	{

		var scrollView  = new ScrollView();
		var stackLayout = new StackLayout()
		{
			Orientation = StackOrientation.Vertical,
			Margin = new Thickness(10),
			Padding = new Thickness(10),
		};

		scrollView.Content = stackLayout;

		labelCounter = new Label()
		{
			WidthRequest= 150,
			HeightRequest= 50,
			HorizontalOptions= LayoutOptions.Center,
			Text="Display Count",
			HorizontalTextAlignment= TextAlignment.Center,
			FontSize = 30,
			FontAttributes = FontAttributes.Bold,
			
		};

		buttonCounter = new Button()
		{

			WidthRequest = 150,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			HeightRequest = 60,
			Text = "Click Me"

		};
		stackLayout.Children.Add(labelCounter);
		stackLayout.Children.Add(buttonCounter);
		this.Content = scrollView;

		buttonCounter.Clicked += onClickButtonCounter;

		
	}

	public void onClickButtonCounter(object Sender,EventArgs e)
	{
		count++;
		buttonCounter.Text = $"clicked {count}";
		labelCounter.Text = count.ToString();
	}
}