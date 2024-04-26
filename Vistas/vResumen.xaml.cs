using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dquimbitaExamen.Vistas;
public partial class vResumen : ContentPage
{
	public vResumen(string nombre, string apellido, string edad, string fecha,string ciudad,string pais,double montoInicial,double pagoMensual,double pagoTotal)
	{
		InitializeComponent();
		txtNombreR.Text = nombre;
		txtApellidoR.Text = apellido;
		txtEdadR.Text = edad;
		txtFechaR.Text = fecha;
		txtCiudadR.Text = ciudad;
		txtPaisR.Text = pais;
		txtMontoIniR.Text = Convert.ToString(montoInicial.ToString("F2"));
		txtMontoMenR.Text = Convert.ToString(pagoMensual.ToString("F2"));
		txtTotalR.Text= Convert.ToString(pagoTotal.ToString("F2"));	
	}
}