namespace PercolationRecursivo {
    public partial class Percolation : Form {
        private int[,] matriz;
        private int tam;
        private bool enable_percolation = true;

        public Percolation() {
            InitializeComponent();

            //Inicializaci?n del tama?o y de la matriz
            tam = ((int)NUDTam.Value);
            matriz = new int[tam, tam];

            //Bot?n BPercolar desactivado
            BPercolar.Enabled = false;
        }


        //Boton Generar Matriz
        private void BGMatriz_Click(object sender, EventArgs e) {
            Random rnd = new Random();

            float probabilidad = TBProbabilidad.Value/10.0f;
            tam = ((int)NUDTam.Value);
            matriz = new int[tam, tam];

            STLPercolacion.Text = "";

            //Genera una matriz de percolaci?n con probabilidad de que haya percolaci?n
            for (int i=0; i<tam; i++) {
                for(int j=0; j<tam; j++) {
                    //Genera un numero aleatorio entre 0 y 10 que dividido 10 nos da un valor entre 0 y 1
                    if(rnd.Next(0, 11)/10.0f <= probabilidad)
                        matriz[i, j] = 0;
                    else matriz[i, j] = 1;
                }
            }

            //Refresca el gr?fico y activa el bot?n BPercolar
            picPercolation.Refresh();
            BPercolar.Enabled = true;
            initPercolation_btn();
        }

        private void percolationProc() {
            bool flagPercolacion = false;

            //Recorre la primera fila de la matriz en busca de espacios vac?os y llama a la funci?n percolaci?n
            for (int i = 0; i < tam; i++)
                if (matriz[0, i] == 0)
                    percolar(0, i);

            //Revisa la ?ltima fila de la matriz y corrobora si hubo o no percolaci?n
            for (int i = 0; i < tam; i++)
                if (matriz[tam - 1, i] == 2)
                {
                    flagPercolacion = true;
                    break;
                }

            this.BeginInvoke((Action)delegate {
                if (flagPercolacion)
                    STLPercolacion.Text = "Hay Percolación";
                else STLPercolacion.Text = "No hay precolación";

                //Refresca el gr?fico y desctiva el boton BPercolar
                //pictureBox1.Refresh();
                BPercolar.Enabled = !BPercolar.Enabled;
                initPercolation_btn();
            });
        }

        private void initPercolation_btn() {
            enable_percolation = !enable_percolation ? !enable_percolation : true;
        }

        //Funci?n del boton percolar
        private void BPercolar_Click(object sender, EventArgs e) {
            Thread tPercolation = new Thread(new ThreadStart(percolationProc));

            if (enable_percolation) {
                tPercolation.Start();
                enable_percolation = !enable_percolation;
            } else {
                enable_percolation = !enable_percolation;
                tPercolation.Interrupt();
            }
            
        }

        //Funci?n percolaci?n recursiva
        private void percolar(int posx, int posy) {
            //Condiciones de salida (Que los valores de "x" e "y" excedan el tama?o de la matriz o que la matriz en la posici?n dada sea != 0)
            if (posx < 0 || posy < 0 || posx >= tam || posy >= tam || matriz[posx, posy] != 0 || enable_percolation)
                return;
            
            //Asignamos un valor 2 en la posici?n "x" e "y" de la matriz que sera representado como agua
            matriz[posx, posy] = 2;

            //Redibujamos la matriz
            this.BeginInvoke((Action)delegate {
                picPercolation.Refresh();
            });
            Thread.Sleep(10);

            //Pasamos a las posiciones adyacentes
            percolar(posx, posy + 1);
            percolar(posx + 1, posy);
            percolar(posx - 1, posy);
            percolar(posx, posy - 1);
        }


        // Funci?n que grafica la matriz
        private void picPercolation_Paint(object sender, PaintEventArgs e) {
            Graphics gr = e.Graphics;
            
            // Variable que nos sirve para escalar los cuadrados de la matriz
            int tamSize=0;

            if (picPercolation.Width > picPercolation.Height) tamSize = picPercolation.Height / matriz.GetLength(0);
            else tamSize = picPercolation.Width / matriz.GetLength(0);
            
            for (int i = 0; i < matriz.GetLength(1); i++) {
                for (int j = 0; j < matriz.GetLength(0); j++) {
                    gr.DrawRectangle(new Pen(Brushes.Red), i * tamSize, j * tamSize, tamSize, tamSize);
                    if (matriz[j, i] == 0)
                        gr.FillRectangle(Brushes.White, i * tamSize + 1, j * tamSize + 1, tamSize - 1, tamSize - 1);
                    else if (matriz[j, i] == 1)
                        gr.FillRectangle(Brushes.Black, i * tamSize + 1, j * tamSize + 1, tamSize - 1, tamSize - 1);
                    else if (matriz[j, i] == 2)
                        gr.FillRectangle(Brushes.Aqua, i * tamSize + 1, j * tamSize + 1, tamSize - 1, tamSize - 1);
                    
                }
            }
        }
    }
}