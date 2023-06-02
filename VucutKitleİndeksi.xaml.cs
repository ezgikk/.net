
using System.ComponentModel.Design;
using System.Diagnostics;

namespace MauiApp6;

public partial class VucutKitleİndeksi : ContentPage
{


    public VucutKitleİndeksi()
    {
        InitializeComponent();
    }


    public object MyLabel { get; private set; }

    private double _value;


    public double Value
    {
        get => _value;
        set
        {
            if (_value != value)
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }
    }
    

    public static VucutKitleİndeksi Page
    { get; private set; }

    public object TextBox { get; private set; }
    public float VKI { get; private set; }

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        var s = sender as Microsoft.Maui.Controls.Button;
        
         
        int kilo = int.Parse((string)TextBox);
        int boy = int.Parse((string)TextBox);

        VKI = kilo / (boy * boy);
        if (VKI <= 16)
        {
            Console.WriteLine("İleri Düzeyde zayıf");
        }

        
        elif(VKI>= 16 & VKI < 16,99);
        {
            Console.WriteLine("Orta Düzeyde zayıf");
        }
        elif(VKI <18,49 );
        {
            Console.WriteLine("Hafif Düzeyde zayıf");
        }
        elif(VKI < 24,99);
        {
            Console.WriteLine("Normal Kilolu");
        }
        elif(VKI < 29,99);
        {
            Console.WriteLine("Hafif Kilolu");
        }
        elif(VKI < 34, 99);
        {
            Console.WriteLine("1.dereceObez");
        }
        elif(VKI < 39, 99);
        {
            Console.WriteLine("2.derece Obez");
        }
        elif(VKI > 40,00);
        {
            Console.WriteLine("3.derece Obez");
        }
        


    }

    private void elif(bool v, int v1)
    {
        throw new NotImplementedException();
    }

    private void Stepper_ValueChanged_1(object sender, ValueChangedEventArgs e)
    {
        var stepper1 = sender as Stepper;
        kilo.Text = stepper1.Value.ToString("F2");

    }
    private void Stepper_ValueChanged_2(object sender, ValueChangedEventArgs e)
    {
        var stepper2 = sender as Stepper;
        boy.Text = stepper2.Value.ToString("F2");
    }
}