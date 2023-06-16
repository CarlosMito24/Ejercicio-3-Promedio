namespace Ejercicio_3_Promedio;

///<Summary>
///<Createddate> 2022/06/16 </Createddate>
///<company> INDEL</company>
///<lastmodificationdate> 2022/06/16 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnButtonClicked(object sender, EventArgs e)
	{
        if (!string.IsNullOrEmpty(Nota1.Text) && !string.IsNullOrEmpty(Nota2.Text) && !string.IsNullOrEmpty(Nota3.Text) && !string.IsNullOrEmpty(Nota4.Text) && !string.IsNullOrEmpty(Nota5.Text))
		{
			double calificacion1, calificacion2, calificacion3, calificacion4, calificacion5, promedio;
			calificacion1 = Convert.ToDouble(Nota1.Text);
            calificacion2 = Convert.ToDouble(Nota2.Text);
            calificacion3 = Convert.ToDouble(Nota3.Text);
            calificacion4 = Convert.ToDouble(Nota4.Text);
            calificacion5 = Convert.ToDouble(Nota5.Text);
            promedio = (calificacion1 + calificacion2 + calificacion3 + calificacion4 + calificacion5) / 5;
            PromedioFinal.Text = Convert.ToString(promedio);
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los números", "Ok");
        }
    }
}