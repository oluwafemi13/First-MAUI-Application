﻿namespace First_MAUI_Application;

public partial class MainPage : ContentPage
{
	int count = 0;
    public const double FontSize = 30;

    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

public class GlobalFontSizeExtension : IMarkupExtension
{
	public object ProvideValue(IServiceProvider serviceProvider)
	{
		return MainPage.FontSize;
	}
}

