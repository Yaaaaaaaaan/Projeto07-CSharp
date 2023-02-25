namespace Projeto07
{
    internal class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double NF()
        {
            return N1 + N2 + N3;
        }
        public bool Aprovado()
        {
            if (NF() >= 18.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public double NR()
            {
                if(Aprovado())
                {
                    return 0.0;
                }
                else
                {
                    return 18.0 - NF();
                }
            }
    }
}
