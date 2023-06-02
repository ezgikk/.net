namespace MauiApp6;

public partial class ColorPicker : ContentPage
{
	public ColorPicker()
	{
		InitializeComponent();
	}

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var stepper1 = sender as Stepper;
        sarı.Text = stepper1.Value.ToString("F2");
    }
}