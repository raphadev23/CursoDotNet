namespace CursoDotNet.Model.TiposDeDados
{
    public static class Caracteres
    {
        static string cadeia1;
        static string cadeia2;
        static char caractere;

        public static string LetrasMaiusculas()
        {
            cadeia1 = "estudo";

            return cadeia1.ToUpper();
        }

        public static string LetrasMinusculas()
        {
            cadeia1 = "estudo";

            return cadeia1.ToLower();
        }

        public static string Eigual()
        {
            cadeia1 = "mãe";
            cadeia2 = "caçarola";

            var eigual = cadeia1.Equals(cadeia2);

            return eigual ? "as strings são iguais" : "as strings são diferentes";
        }

        public static string ExtrairPartes()
        {
            cadeia1 = "Marcelo Lessa Trindade";

            return cadeia1.Substring(8, 5);
        }

        public static char ExtrairCaractere(string nome, int posicao)
        {
            
            return nome[posicao];
            

        }





























    }
}
