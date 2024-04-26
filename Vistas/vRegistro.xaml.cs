namespace dquimbitaExamen.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro(string usuario)
	{
		InitializeComponent();
        lblUsuarioConectado.Text = "Usuario conectado" + usuario;

    }

    private void btnMensual_Clicked(object sender, EventArgs e)
    {
        double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
        if (txtMontoInicial.Text=="")
        {
            DisplayAlert("Alerta", "Monto incial no se encuentra registrado", "cerrar");
        }
        else
        {
            double pagoMensual = ((1500 - montoInicial) / 4) + (1500 * 0.04);
            txtMontoMensual.Text = pagoMensual.ToString("F2");
        }
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string ciudad= pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
        string pais = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
        string fecha = dpFecha.Date.ToString();
        double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
        double pagoMensual = ((1500 - montoInicial) / 4) + (1500 * 0.04);
        string nombre=txtNombre.Text;   
        string apellido=txtApellido.Text;    
        string edad=  txtEdad.Text;
        double pagoTotal = pagoMensual + montoInicial;
        Navigation.PushAsync(new vResumen(nombre,apellido,edad,fecha,ciudad,pais,montoInicial,pagoMensual,pagoTotal));
        txtMontoInicial.Text = "";
        txtMontoMensual.Text = "";
        txtNombre.Text = "";
        txtApellido.Text = "";
        txtEdad.Text = "";
    }
}