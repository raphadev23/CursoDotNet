internal class Program
{
    private static void Main(string[] args)
    {
        //         int numerodois = 1;
        //         string nome = "raphaella Neves";
        //         string outronome = "RENATO";

        //     Console.WriteLine(nome.Substring(10));

        //     var partes = nome.Split(" ");
        //     foreach(var parte in partes){
        //         Console.WriteLine(parte);
        //     }

        //     if (nome.Equals(outronome))
        //         Console.WriteLine("os dois nomes sao iguais");
        //     else
        //          Console.WriteLine("os dois nomes nao sao iguais");

        //     foreach(var caractere in nome){
        //         Console.WriteLine(caractere);
        //     }

        // var quintaLetra = nome[4];
        // Console.WriteLine($"A quinta letra do meu nome é {quintaLetra}");


        //         double numerodecimal;


        //         // switch para verificar entre diversos valores
        //         switch(numerodois){
        //             case 1:
        //                 Console.WriteLine($"a variavel numerodois é igual a um. \n o seu valor é {numerodois}");
        //                 break;
        //             case 2:
        //                 Console.WriteLine($"a variavel numerodois é igual a dois. \n o seu valor é {numerodois}");
        //                 break;
        //             case 3:
        //                 Console.WriteLine($"a variavel numerodois é igual a tres. \n o seu valor é {numerodois}");
        //                 break;
        //         }

        // // for (int i = 0; i < 100; i++) {
        // //     Console.WriteLine(i);
        // // }


        // // array de numeros inteiros
        // int[] numeros = new int[]{43,16,19,30,11,490};

        // // foreach serve para varrer uma coleçao 
        // foreach(var numero in numeros){
        //     Console.WriteLine(numero);
        // } 
        // // operador ternario        
        // var ePar = (numerodois%2) == 0 ? true : false;

        // if(ePar)
        //     Console.WriteLine("A variavel numerodois é um numero par");
        // else
        //    Console.WriteLine("A variavel numerodois é um numero impar");



        // if (numerodois > 2)
        //             Console.WriteLine($"a variavel numerodois é maior que dois. \n o seu valor é {numerodois}");
        //         else
        //             Console.WriteLine($"a variavel numerodois  não é maior que dois. \n o seu valor é {numerodois}");


        //         Console.WriteLine(nome);
        //         Console.WriteLine(numerodois);



        // Console.WriteLine(DateTime.Now.ToShortDateString());

        // Console.WriteLine(DateTime.Now.ToLongDateString());

        // Console.WriteLine(DateTime.Now.ToString());

        // Console.WriteLine(DateTime.Now.AddDays(-5).ToShortDateString());


        // if((DateTime.Now.DayOfWeek == DayOfWeek.Thursday) && (DateTime.Now.DayOfWeek != DayOfWeek.Tuesday))
        //     Console.WriteLine("hoje é quinta feira ");

        Console.WriteLine("Qual é a sua data de nascimento?");
        var nascimento = Console.ReadLine();
        var dataNascimento = DateTime.Parse(nascimento);


        switch (dataNascimento.DayOfWeek)
        {
            case DayOfWeek.Sunday:
                Console.WriteLine("VocÊ nasceu no(a) Domingo!");
                break;
            case DayOfWeek.Monday:
                Console.WriteLine("VocÊ nasceu no(a)Segunda!");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("VocÊ nasceu no(a) Terça!");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("VocÊ nasceu no(a) quarta!");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("VocÊ nasceu no(a) Quinta!");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("VocÊ nasceu no(a)Sexta!");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("VocÊ nasceu no(a) Sabado!");
                break;
        }

    }
}

