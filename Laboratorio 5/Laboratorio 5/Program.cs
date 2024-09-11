internal class Program
{
    private static void Main(string[] args)
    {
        // int valores [] declaracion erronea
        int[] valores;  //declaracion valida
        valores = new int[100];
        valores = new int[20];

        //Arreglos unidimensionales o de dimension simple
        //int[] valores1;
        //int[] valores2 = new int[50];

        //arreglos multimensionales
        int[,] valores1;
        int[,] valores2 = new int[3, 7];
        int[,,] valores3 = new int[3, 4, 2];

        //Arreglos de arreglos 
        int[][] matriz;
        //Los arreglos de arreglos se inicializan de forma diferente
        int[][] matriz2 = new int[3][];
        for(int i = 0; i < matriz2.Length; i++)
        {
            matriz2[i] = new int[4];
        }
    }    
}