namespace PercolationRecursivo
{
    public partial class Form1 : Form
    {
        private int[,] matriz;
        private int tam;

        public Form1()
        {
            InitializeComponent();

            //Inicializaci�n del tama�o y de la matriz
            tam = ((int)NUDTam.Value);
            matriz = new int[tam, tam];

            //Bot�n BPercolar desactivado
            BPercolar.Enabled = false;
        }


        //Boton Generar Matriz
        private void BGMatriz_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            float probabilidad = TBProbabilidad.Value/10.0f;
            tam = ((int)NUDTam.Value);
            matriz = new int[tam, tam];

            STLPercolacion.Text = "";

            //Genera una matriz de percolaci�n con probabilidad de que haya percolaci�n
            for (int i=0; i<tam; i++)
            {
                for(int j=0; j<tam; j++)
                {
                    //Genera un numero aleatorio entre 0 y 10 que dividido 10 nos da un valor entre 0 y 1
                    if(rnd.Next(0, 11)/10.0f <= probabilidad)
                        matriz[i, j] = 0;
                    else matriz[i, j] = 1;
                }
            }

            //Refresca el gr�fico y activa el bot�n BPercolar
            pictureBox1.Refresh();
            BPercolar.Enabled = true;
        }


        //Funci�n del boton percolar
        private void BPercolar_Click(object sender, EventArgs e)
        {
            bool flagPercolacion = false;

            //Recorre la primera fila de la matriz en busca de espacios vac�os y llama a la funci�n percolaci�n
            for(int i=0; i<tam; i++)
            {
                if (matriz[0, i] == 0)
                {
                    percolar(0, i);
                }
            }

            //Revisa la �ltima fila de la matriz y corrobora si hubo o no percolaci�n
            for(int i=0; i<tam; i++)
            {
                if (matriz[tam-1, i]==2)
                {
                    flagPercolacion = true;
                    break;
                }
            }

            if (flagPercolacion)
            {
                STLPercolacion.Text = "Hay Percolaci�n";
            }
            else STLPercolacion.Text = "No hay precolaci�n";

            //Refresca el gr�fico y desctiva el boton BPercolar
            //pictureBox1.Refresh();
            BPercolar.Enabled = false;
        }


        //Funci�n percolaci�n recursiva
        private void percolar(int posx, int posy)
        {
            //Condiciones de salida (Que los valores de "x" e "y" excedan el tama�o de la matriz o que la matriz en la posici�n dada sea != 0)
            if (posx < 0 || posy < 0 || posx >= tam || posy >= tam || matriz[posx, posy] != 0)
                return;
            
            //Asignamos un valor 2 en la posici�n "x" e "y" de la matriz que sera representado como agua
            matriz[posx, posy] = 2;

            //Redibujamos la matriz
            pictureBox1.Refresh();
            Thread.Sleep(50);

            //Pasamos a las posiciones adyacentes
            percolar(posx, posy+1);
            percolar(posx+1, posy);
            percolar(posx-1, posy);
            percolar(posx, posy-1);
        }


        // Funci�n que grafica la matriz
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            
            // Variable que nos sirve para escalar los cuadrados de la matriz
            int tamSize=0;

            if (pictureBox1.Width > pictureBox1.Height) tamSize = pictureBox1.Height / matriz.GetLength(0);
            else tamSize = pictureBox1.Width / matriz.GetLength(0);
            
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    gr.DrawRectangle(new Pen(Brushes.Red), i * tamSize, j * tamSize, tamSize, tamSize);
                    if (matriz[j, i] == 0)
                    {
                        gr.FillRectangle(Brushes.White, i * tamSize + 1, j * tamSize + 1, tamSize - 1, tamSize - 1);
                    }
                    if (matriz[j, i] == 1)
                    {
                        gr.FillRectangle(Brushes.Black, i * tamSize + 1, j * tamSize + 1, tamSize - 1, tamSize - 1);
                    }
                    if (matriz[j, i] == 2)
                    {
                        gr.FillRectangle(Brushes.Aqua, i * tamSize + 1, j * tamSize + 1, tamSize - 1, tamSize - 1);
                    }
                }
            }
        }
    }
}