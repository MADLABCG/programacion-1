namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscoger_Click(object sender, EventArgs e)
        {
            random_word();
        }

        //
        string[] prueba = {
            "uno", //0
            "dos", //1
            "tres", //2
           "cuatro" //3
            };
        //


        private void random_word()
        {
            //Generamos un indice de delimitadores para romper el texto en palabras individuales
            char[] delimitadores = { ' ', '\t', '\n' };
            //Capturar las palabras individuales del cuadro de texto usando los delimitadores y la funcion split.
            string[] temporal = cuadroTexto.Text.Split(delimitadores);
            //Tener el tamano del arreglo creado
            int size = temporal.Length;
            //Inicializar un Ramdon para generar un numero aleatorio menor al tamano del arreglo
            Random rnd = new Random();
            //Obtener numero aleatorio
            int seleccion = rnd.Next(size);
            //Mostrar en label de texto la palabra seleccionada
            lblEscogido.Text = temporal[seleccion];
        }

    }
}