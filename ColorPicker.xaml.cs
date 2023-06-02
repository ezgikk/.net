namespace MauiApp6;

public partial class ColorPicker : ContentPage
{
	public ColorPicker()
	{
		InitializeComponent();
	}
    private void ChangeBackgroundColor(object sender, EventArgs e)
    {
        // Rastgele bir renk oluþtur
        Random random = new Random();
        Color randomColor = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));

        // Arka plan rengini deðiþtir
        this.BackgroundColor = randomColor;
    }
     
    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var stepper1 = sender as Stepper;
        sarı.Text = stepper1.Value.ToString("F2");
    }
}
