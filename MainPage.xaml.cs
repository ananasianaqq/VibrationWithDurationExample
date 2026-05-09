namespace VibrationWithDurationExample;

public partial class MainPage : ContentPage
{
    public int Duration { get; set; } = 1000;

    public MainPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        Vibration.Default.Vibrate(Duration);
    }
}