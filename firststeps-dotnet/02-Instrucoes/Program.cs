using System;

namespace Instrucoes {
    class Program {
        static void Declaracoes(){
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }
        static void InstrucaoIf(string[] str){
            if(str.Length == 0) {
                Console.WriteLine("Nenhum arg");
            } else if(str.Length == 1) {
                Console.WriteLine("Um arg");
            } else {
                Console.WriteLine($"{str.Length} args");
            }
        }
        static void InstrucaoSwitch(string[] str){
            int nStr = str.Length;

            switch (nStr){
                case 0:
                    Console.WriteLine("Nenhum arg");
                    break;
                case 1:
                    Console.WriteLine("Um arg");
                    break;
                default:
                    Console.WriteLine($"{str.Length} args");
                    break;
            }
        }

        static void InstrucaoWhile(string[] str){
            int i = 0;
            while(i < str.Length){
                Console.WriteLine(str[i]);
                i++;
            }
        }

        static void InstrucaoDo(string[] str){
            string txt;

            do {
                txt = Console.ReadLine();
                Console.WriteLine(txt);
            } while (!string.IsNullOrEmpty(txt));
        }

        static void InstrucaoFor(string[] str){
            for (int i = 0; i < str.Length; i++) {
                Console.WriteLine(str[i]);
            }
        }

        static void InstrucaoForeach (string[] str) {
            foreach (string s in str){
                Console.WriteLine(s);
            }
        }

        static void InstrucaoBreak(string[] str){
            while(true) {
                string s = Console.ReadLine();

                if(string.IsNullOrEmpty(s))
                    break;

                Console.WriteLine(s);
            }
        }
        static void InstrucaoContinue(string[] str){
            for(int i = 0; i < str.Length; i++) {
                if(str[i].StartsWith("&"))
                    continue;

                Console.WriteLine(str[i]);
            }
        }
        static void InstrucaoReturn(){
            int Somar(int a, int b){
                return a+b;
            }

            Console.WriteLine(Somar(1,2));
            Console.WriteLine(Somar(5,2));
            Console.WriteLine(Somar(7,6));

            return;
        }

        static void InstrucoesTryCatchFinallyThrow(string[] str){
            double Dividir(double x, double y){
                if(y == 0)
                    throw new DivideByZeroException();

                return x/y;
            }

            try {
                if(str.Length != 2)
                    throw new InvalidOperationException("Informe 2 num.");

                double x = double.Parse(str[0]);
                double y = double.Parse(str[1]);

                Console.WriteLine(Dividir(x,y));
            }
            catch (InvalidOperationException e){
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally {
                Console.WriteLine("Chegamos no fim!");
            }
        }

        static void IntrucaoUsing (string[] str) {
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt")){
                w.WriteLine("Linha 1");
                w.WriteLine("Linha 2");
                w.WriteLine("Linha 3");
            }
        }
    }
}