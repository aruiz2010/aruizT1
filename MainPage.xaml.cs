

namespace aruizT1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

      
        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            String nombre =txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            double salario= Convert.ToDouble(txtSalario.Text);
            double aporte = (salario * 9.45) / 100;

            DisplayAlert("Bienvenido",nombre + apellido +"\nTienes "+edad+" años"+"\nTu aporte mensual es "+aporte,"Cerrar");
        }
    }

}
