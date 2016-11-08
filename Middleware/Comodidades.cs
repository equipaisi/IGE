namespace Middleware
{

    public struct Comodidades
    {
        #region Construtores
        public Comodidades(bool televisao, bool internet, bool servicoDeLimpeza)
        {
            Televisao = televisao;
            Internet = internet;
            ServicoDeLimpeza = servicoDeLimpeza;
        }
        #endregion

        #region Propriedades
        public bool Televisao { get; set; }
        public bool Internet { get; set; }
        public bool ServicoDeLimpeza { get; set; }
        #endregion
    }
}