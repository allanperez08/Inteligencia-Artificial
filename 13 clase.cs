using sistem;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

# Ejemplo de perceptron para implementar la puerta logica ANDA
namspace Perceptron
{// Clase para el bloque de codigo
    class Program
    {
        static void Main(string[] args)
        { //Conjunto de datos para entrenamiento
            int[,] datos = ({1, 1, 1}, {1, 0, 0}, {0, 1, 0}, {0, 0, 0});
            // Generacion de los valores de peso y umbral
            Random aleatorio = new Random();
            double[] pesos = {aleatorio.NextDouble(), aleatorio.NextDouble(), aleatorio.NextDouble()};
        }
    }
}