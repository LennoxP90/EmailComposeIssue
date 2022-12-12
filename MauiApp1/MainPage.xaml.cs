namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
    string recipient = "{CHANGE THIS TO REAL EMAIL}";

    EmailMessage message = new()
    {
      Subject = "Test",
      Body = "Test EMAIL",
      BodyFormat = EmailBodyFormat.PlainText, 
      To = new List<string>() { recipient.Trim() }
    };

    await Email.Default.ComposeAsync( message );
  }
}

