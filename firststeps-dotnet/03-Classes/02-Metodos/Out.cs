namespace Classes.Metodos
{
    public class Out
    {
        static void Dividir(int x, int y, out int result, out int resto){
            result = x / y;
            resto = x % y;
        }

        public static void Dividir() {
            Dividir(10, 5, out int result, out int resto);

            System.Console.WriteLine("{0}{1}", result, resto);
        }
    }
}