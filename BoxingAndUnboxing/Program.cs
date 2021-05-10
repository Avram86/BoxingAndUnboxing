using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
        }

        private static void NullConditional()
        {
            string[] array = null;
            string element = array?[2];

            //operatorul AS face conversie de tip

            //is returneaza un boolean
            if (element is null)
            {
                Console.WriteLine("element is null");
            }
            else
            {
                Console.WriteLine($"{element}");
            }


            string str = null;
            string str2 = str?.Replace("abc", "def");

            //testeaza egalitatea a doua adrese
            //if (object.ReferenceEquals(str2, null))
            if (str2 is null)
            {
                Console.WriteLine("str2 is null");

            }
            else
            {
                Console.WriteLine(str2);
            }
        }
        private static void IsandAS()
        {
            string str3 = null;
            object obj = str3;

            bool isString = obj is string;
            string unboxedClasic = (string)obj;
            //se prefera conversia AS pt ca e mai safe, returneaza null daca nu merge conversia
            string unboxed = obj as string;

            if (obj is int unboxedInt)
            {
                Console.WriteLine(unboxedInt);
            }
            else
            {
                Console.WriteLine("obj is not an int");
            }

            Console.WriteLine(isString);
            if (unboxed is null)
            {
                Console.WriteLine("unboxed is null");
            }
            else
            {
                Console.WriteLine(unboxed);
            }
        }

        private static void BoxingAndUnboxing() 
        {
            //int x = 200;
            //object z = x;
            //long y = (long)z;

            //Console.WriteLine(y);

            //Eroare:           InvalidCastException!!!!!!!!!!!!!!


            int i = 10;
            string s = "abc";

            //boxing, operatiune costisitoare ca si performanta
            //  a)alocare memorie noua pt continutul lui i in heap=mem de lucru
            //  b)copierea valorii lui i
            //  c)alocare memorie pt var o1
            //  d) in casuta de memorie a lui o1 se copiaza adresa de la a)
            object o1 = i;

            //Unboxing
            //a)Alocare memorie pt o1AsInt
            //b) folosind adresa lui "o1" trebuie accesat continutul
            //c)Copiem valoarea din heap in o1AsInt!! trebuie sa existe potrivire de tip exacta
            //
            int o1AsInt = (int)o1;

            //boxing, operatiune costisitoare ca si performanta
            //  a)alocare memorie noua pt continutul lui s in heap=mem de lucru
            //  b)copierea valorii lui s
            //  c)alocare memorie pt var o2
            //  d) in casuta de memorie a lui o1 se copiaza adresa de la a)
            object o2 = s;


            Console.WriteLine($"i={i}");
            Console.WriteLine($"o1AsInt={o1AsInt}");
            Console.WriteLine($"o1={o1}");

            Console.WriteLine($"s={s}");
            Console.WriteLine($"o2={o2}");

            i = 20;
            s = "abc 123";

            Console.WriteLine($"i={i}");
            Console.WriteLine($"o1={o1}");

            Console.WriteLine($"s={s}");
            Console.WriteLine($"o2={o2}");
        }
    }
}
