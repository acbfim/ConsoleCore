using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas Chutando";
        }

        public string Corre()
        {
            return "Maradona estas Correndo";
        }

        public string Passe()
        {
            return "Maradona estas Passendo";
        }
    }
}