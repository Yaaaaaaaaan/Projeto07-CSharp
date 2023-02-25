using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
            if (NF() >= 60.0)
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
                    return 60.0 - NF();
                }
            }
    }
}
