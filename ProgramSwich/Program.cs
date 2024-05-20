using System;

namespace ProgramNum
{
    class Program
    {
        public static void Main (string[]args)
        {
            /*Programa que le pida al usuario que inserte un numero del 1 al 12. Aplicar un switch para que muestre el mes correspondiente al número ingresado, siendo 1 = Enero y 12 =  Diciembre. Contemplar incluir un mensaje si el usuario ingresa un numero fuera de este rango. 

            Programa que le muestre al usuario un menu como este: [E]Español  [I]Inglés  [F]Francés. Según la letra ingresada por el usuario, muestre una frase en el lenguaje seleccionado.

            Programa que le pida al usuario un numero del 1 al 7 y que segun el numero, escriba en la pantalla el nombre del dia de la semana correspondiente

            Si el usuario inserta un 1, escriba "Domingo"
            Si el usuario inserta un 2, escriba "Lunes"
            y así sucesivamente*/

            System.Console.Write("Cual programa va a ejecutar: ");
            System.Console.WriteLine("");
            System.Console.WriteLine("1- Un numero del 1-12 para insertar un mes del año.");
            System.Console.WriteLine("");
            System.Console.WriteLine("2- Menu de Idiomas con una frace.");
            System.Console.WriteLine("");
            System.Console.WriteLine("3- Un numero del 1-7 e insertar un dia de la semana.");

            int programa = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (programa)
            {
                /*Programa que le pida al usuario que inserte un numero del 1 al 12.
                 Aplicar un switch para que muestre el mes correspondiente al número ingresado, 
                 siendo 1 = Enero y 12 =  Diciembre.
                  Contemplar incluir un mensaje si el usuario ingresa un numero fuera de este rango.*/

                case 1: 
                  System.Console.WriteLine("Usted ha elegido Un programa que le pida al usuario que inserte un numero del 1 al 12. Aplicar un switch para que muestre el mes correspondiente al número ingresado, siendo 1 = Enero y 12 =  Diciembre. Contemplar incluir un mensaje si el usuario ingresa un numero fuera de este rango.");
                  Console.ReadKey();
                  Console.Clear();

                  System.Console.Write("Elija un numero del 1-12 para elegir un mes del año: ");
                  int Año = Convert.ToInt32(Console.ReadLine());

                  System.Console.WriteLine("");

                  switch (Año)
                  {
                    case 1: System.Console.WriteLine("Usted ha eledgido el mes de Enero."); break;

                    case 2: System.Console.WriteLine("Usted ha eledgido el mes de Febrero."); break;

                    case 3: System.Console.WriteLine("Usted ha eledgido el mes de Marzo."); break;

                    case 4: System.Console.WriteLine("Usted ha eledgido el mes de Abril."); break;

                    case 5: System.Console.WriteLine("Usted ha eledgido el mes de Mayo."); break;

                    case 6: System.Console.WriteLine("Usted ha eledgido el mes de Junio."); break;
                       goto Hola;
                    case 7: System.Console.WriteLine("Usted ha eledgido el mes de Julio."); break;

                    case 8: System.Console.WriteLine("Usted ha eledgido el mes de Agosto."); break;

                    case 9: System.Console.WriteLine("Usted ha eledgido el mes de Septiembre."); break;

                    case 10: System.Console.WriteLine("Usted ha eledgido el mes de Octubre."); break;

                    case 11: System.Console.WriteLine("Usted ha eledgido el mes de Noviembre."); break;

                    case 12: System.Console.WriteLine("Usted ha eledgido el mes de Diciembre."); break;

                    default: System.Console.WriteLine("NO ES UN NUMERO VALIDO"); break;
                  }
                  break;

                  /* Programa que le muestre al usuario un menu como este: 
                  [E]Español  [I]Inglés  [F]Francés.
                   Según la letra ingresada por el usuario,
                    muestre una frase en el lenguaje seleccionado.*/

                case 2: 
                  System.Console.WriteLine("Usted ha elegido un Programa que le muestre al usuario un menu como este: [E]Español  [I]Inglés  [F]Francés. Según la letra ingresada por el usuario, muestre una frase en el lenguaje seleccionado.");
                  Console.ReadKey();
                  Console.Clear();

                  System.Console.WriteLine("SELECIONE UNO DE LOS IDIOMAS A CONTINUACIÓN: ");
                  System.Console.WriteLine("Selecione el idioma con la inicial encerrada entre parentesís");

                  System.Console.WriteLine("");

                  System.Console.WriteLine("[E] Español");
                  System.Console.WriteLine("[I] Ingles");
                  System.Console.WriteLine("[F] Frances");
                  System.Console.WriteLine("[C] Chino");
                  System.Console.WriteLine("[A] Arabe");
                  System.Console.WriteLine("[P] Portugues");
                  System.Console.WriteLine("[J] Japones");
                  System.Console.WriteLine("[N] Indonesia");
                  
                  String IDIOMAS =Console.ReadLine()!;
                  IDIOMAS=IDIOMAS.ToUpper();
                  
                  switch (IDIOMAS)
                  {
                    case "E": System.Console.WriteLine("Español: Hola, ¿Como esta? "); break;
                    case "I": System.Console.WriteLine("Ingles: Hi! ¿How are You?"); break;
                    case "F": System.Console.WriteLine("Francés: Salut ¿comment va ta journée? "); break;
                    case "C": System.Console.WriteLine("Chino: 你好，¿今天過得如何？ "); break;
                    case "A": System.Console.WriteLine("Arabe: مرحبا، كيف حال?"); break;
                    case "P": System.Console.WriteLine("Portugues: Olá, ¿como está o seu dia? "); break;
                    case "J": System.Console.WriteLine("Japones: ¿こんにちは、ご機嫌いかがですか？"); break;
                    case "N": System.Console.WriteLine("Indonesia: ¿Halo, bagaimana harimu? "); break;


                    default: System.Console.WriteLine("Esa letra no ha sido introducida en el diccionario de idiomas");
                    break;
                  }
                  break;

                case 3: System.Console.WriteLine("Programa que le pida al usuario un numero del 1 al 7 y que segun el numero, escriba en la pantalla el nombre del dia de la semana correspondiente");
                 Console.ReadKey();
                 Console.Clear();

                 System.Console.WriteLine("SELECCIONE UN NUMERO DEL 1-7 PARA IMPIRMIR UN DIA DE LA SEMANA");
                 int semana = Convert.ToInt32(Console.ReadLine());

                 switch (semana)
                 {
                  case 1: System.Console.WriteLine("Usted ha elegido el dia Lunes"); break;

                  case 2: System.Console.WriteLine("Usted ha eledido el dia Martes"); break;

                  case 3: System.Console.WriteLine("Usted ha elegido el dia Miercoles"); break;

                  case 4: System.Console.WriteLine("Usted ha elegido el dia Jueves"); break;

                  case 5: System.Console.WriteLine("Usted ha elegido el dia Viernes"); break;

                  case 6: System.Console.WriteLine("Usted ha elegido el dia Sabado"); break;

                  case 7: System.Console.WriteLine("Usted ha elegido el dia Domingo");break;




                  default: System.Console.WriteLine("Este numero no es valido en los dias de la semana"); break;
                 }


                break;


             default: System.Console.WriteLine("Inserte un numero valido del 1-3"); 
             break;
            } 
        }     
    }
}

