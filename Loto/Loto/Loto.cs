using System;

namespace LotoClassNS
{
    // Clase que almacena una combinación de la lotería
    //
    public class LotoDAS2223 
    {
        // definición de constantes
        public const int MAX_NUMEROS = 6;
        public const int NUMERO_MENOR = 1;
        public const int NUMERO_MAYOR = 49;
        
        private int[] numerosCombinacion = new int[MAX_NUMEROS];   // numeros de la combinación
        private bool ok = false;      // combinación válida (si es aleatoria, siempre es válida, si no, no tiene porqué)

        public int[] Nums { 
            get => numerosCombinacion; 
            set => numerosCombinacion = value; 
        }
        public bool Ok { get => ok; set => ok = value; }

        /// <summary>
        /// <para>Constructor vacío.</para>
        /// </summary>
        /// <remarks>
        /// Se genera una combinación aleatoria correcta.
        /// </remarks>
        public LotoDAS2223()
        {
            Random r = new Random();    // clase generadora de números aleatorios

            int i=0, j, num;

            do             // generamos la combinación
            {     //                  
                num = r.Next(NUMERO_MENOR, NUMERO_MAYOR + 1);     // generamos un número aleatorio del 1 al 49
                for (j=0; j<i; j++)    // comprobamos que el número no está
                    if (Nums[j]==num)
                        break;
                if (i==j)               // Si i==j, el número no se ha encontrado en la lista, lo añadimos
                {
                    Nums[i]=num;
                    i++;
                }
            } while (i<MAX_NUMEROS);

            Ok=true;
        }

        /// <summary>
        /// Constructor con Parámetro <paramref name="misnums"/>.
        /// </summary>
        /// <param name="misnums">Inserta el array de números.
        /// </param>
        /// <remarks>
        /// misnums es un array de enteros con la combinación que quiero crear (no tiene porqué ser válida)
        /// </remarks>
        public LotoDAS2223(int[] misnums)  // misnumeros: combinación con la que queremos inicializar la clase
        {
            for (int i=0; i<MAX_NUMEROS; i++) // TODO faltan llaves
                if (misnums[i]>=NUMERO_MENOR && misnums[i]<=NUMERO_MAYOR) {
                    int j;
                    for (j=0; j<i; j++) 
                        if (misnums[i]==Nums[j])
                            break;
                    if (i==j)
                        Nums[i]=misnums[i]; // validamos la combinación
                    else {
                        Ok=false;
                        return;
                    }
                }
                else
                {
                    Ok=false;     // La combinación no es válida, terminamos
                    return;
                }
	            Ok=true;
        }

        /// <summary>
        /// Método que comprueba el número de aciertos.
        /// </summary>
        /// <param name="premi">Parámetro array con la combinación de números ganadora.</param>
        /// <returns>Se devuelve el número de aciertos (tipo entero, int).</returns>
        public int comprobar(int[] premi)
        {
            int a=0;                    // número de aciertos
            for (int i=0; i<MAX_NUMEROS; i++)
                for (int j=0; j<MAX_NUMEROS; j++)
                    if (premi[i]==Nums[j]) a++;
            return a;
        }
    }

}
