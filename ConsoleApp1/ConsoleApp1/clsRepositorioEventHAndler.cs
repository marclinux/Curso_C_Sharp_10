using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Argumentos : EventArgs
    {
        public int valor;
    }
    public class clsRepositorioEventHandler
    {
        #region Propiedades
        #endregion

        #region Eventos
        public event EventHandler<Argumentos> LeeLinea;
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public void ObtenTodos() 
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(250);
                Argumentos e = new Argumentos();
                e.valor = i;
                LeeLinea(this, e);
            }
        }
        #endregion
    }
}
