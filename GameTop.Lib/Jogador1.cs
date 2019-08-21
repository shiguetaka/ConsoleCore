using GameTop.Interface;

namespace GameTop.Lib
{
   public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} esta Chutando \n";
        }

        public string Corre()
        {
            return $"{_Nome} esta Correndo \n";
        }

        public string Passe()
        {
            return $"{_Nome} esta Passando \n";
        }
    }
}