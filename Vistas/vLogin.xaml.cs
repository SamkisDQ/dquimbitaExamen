using System.Security.Principal;

namespace dquimbitaExamen.Vistas;

public partial class vLogin : ContentPage
{
    string[] user = { "estudiante2024", "uisrael2024"};
    string[] pass = { "examen1", "parcial1"};
    public vLogin()
	{
      
        InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string clave = txtClave.Text;
        bool verificar = false;
        for (int i = 0; i < user.Length; i++)
        {
            if (user[i] == usuario && pass[i] == clave)
            {
                verificar = true;
                break;
            }
        }
        if (verificar)
        {
            Navigation.PushAsync(new vRegistro(usuario));
            txtUsuario.Text = "";
            txtClave.Text = "";
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o clave incorrecta", "cerrar");
            txtUsuario.Text = "";
            txtClave.Text = "";
        }
    }
}