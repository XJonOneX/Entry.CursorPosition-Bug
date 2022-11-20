namespace Ugg;

public partial class MainPage : ContentPage
{
	int count = 0;

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

	private void Entry_TextChanged(object sender, TextChangedEventArgs e)
	{
		entryText.CursorPosition = 0;
	}

	private void entryText_Focused(object sender, FocusEventArgs e)
	{
		entryText.CursorPosition = 0;
	}
}

