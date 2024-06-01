using Arbolbalanceado.Services;

class Program
{
    static void Main(string[] args)
    {
        ArbolBalanceado arbol = new ArbolBalanceado();

        
        arbol.Insertar(10);
        arbol.Insertar(5);
        arbol.Insertar(15);
        arbol.Insertar(3);
        arbol.Insertar(7);

       
        Console.WriteLine("Árbol balanceado:");
        arbol.Mostrar();
        Console.WriteLine("\nlos nodos han sido insertados correctamente\n");
    }
}