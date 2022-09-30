namespace First_MAUI_Application;

public partial class PlatformSpecificValuePage : ContentPage
{
	public PlatformSpecificValuePage()
	{
		InitializeComponent();

		VstackLayout.Padding = DeviceInfo.Platform == DevicePlatform.iOS ? new Thickness(12, 10, 50, 45) : new Thickness(30);
		VstackLayout.Margin = DeviceInfo.Platform == DevicePlatform.iOS ? new Thickness(10,30,10,30): new Thickness(30);
	}
}