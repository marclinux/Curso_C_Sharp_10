using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void AvisaLinea(int valor);
    public class clsRepositorioDelegado
    {
        #region Propiedades
        #endregion

        #region Eventos
        public event AvisaLinea LeeLinea;
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public void ObtenTodos()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(250);
                LeeLinea(i);
            }

        }
        #endregion
    }
}
