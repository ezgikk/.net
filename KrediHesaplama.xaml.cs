namespace MauiApp6;

public partial class KrediHesaplama : ContentPage
{
	public KrediHesaplama()
	{
        InitializeComponent();
	}

    

    private static KrediHesaplama instance;
    private int taksit;

    public static KrediHesaplama Page
    {
        get
        {
            if (instance == null)
                instance = new KrediHesaplama();
            return instance;
        }
    }

    
    public int Toplam { get; private set; }
    public int Taksit { get; private set; }
    public object TextBox { get; private set; }
    public int BrutFaiz { get; private set; }

    
    protected override void OnAppearing()
    {
        base.OnAppearing();
        

    }
    private int GetTaksit()
    {
        return Taksit;
    }


    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        var s = sender as Button;
        DisplayAlert ("HESAPLANIYOR", $"Tıkladın", "ok");
        int Oran = int.Parse((string)TextBox);
        int Vade = int.Parse((string)TextBox);
        int Tutar = int.Parse((string)TextBox);

        Toplam = 0;
        taksit = 0;

        BrutFaiz = (Oran + Oran + (10 / 100) + Oran + (15 / 100)) / 100;
        taksit = (int)(Math.Pow(1 + BrutFaiz, Vade) * BrutFaiz / (Math.Pow(1 + BrutFaiz, Vade) - 1) * Tutar);
        Toplam = taksit * Vade;

    }

    private void stepper2_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var stepper1 = sender as Stepper;
        Tutar.Text = stepper1.Value.ToString("F2");
    }
}