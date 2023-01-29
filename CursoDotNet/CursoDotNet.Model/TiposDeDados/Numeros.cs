namespace CursoDotNet.Model.TiposDeDados
{
    public static  class Numeros 
    {
        
        public static double Calcular(Operacao operacao,double numero1, double numero2)
        {
            double resultado = 0;
            
            switch (operacao)
            {
                case Operacao.soma:
                    resultado = numero1 + numero2;
                    break;
                case Operacao.subtracao:
                    resultado = numero1 - numero2;   
                    break;
                case Operacao.multiplicacao:
                    resultado = numero1 * numero2;
                    break;
                case Operacao.divisao:
                     resultado = numero1 / numero2;
                    break;
                case Operacao.modulo:
                    resultado = numero1 % numero2;
                    break;
            }
            return resultado;
        }

  
        
    }

    public enum Operacao
    {
        soma = 1,
        subtracao = 2,
        multiplicacao = 3,
        divisao = 4,
        modulo = 5            
    }
}
