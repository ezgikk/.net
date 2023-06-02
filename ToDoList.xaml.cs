using Microsoft.Maui.ApplicationModel.Communication;
using Microsoft.Maui.Controls;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MauiApp6;

public partial class ToDoList : ContentPage
{
  
    public ToDoList()
    {
        InitializeComponent();
     

    }

  


    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Edit_Clicked(object sender, EventArgs e)
    {

    }

    private void Delete_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}
public partial class ToDoList
{
public string Yapilacak { get; set; }
}
