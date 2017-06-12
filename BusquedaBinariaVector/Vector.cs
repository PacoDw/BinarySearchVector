using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinariaVector
{
    class Vector
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS ATTRIBUTES
        public int[] _vector;
        private int _li;
        private int _ls;
        private static Random ran;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS PROPERTIES
        private int _cout;
        public int Cout { get { return _cout; } }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS CONSTRUCTOR
        public Vector()
        {
            _vector = new int[500];
            _li = _vector[0];
            _ls = _vector.Length - 1;
            ran = new Random(8);
            _cout = 0;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD CREAR VECTOR
        public void CrearVector()
        {
            for (int i = 0; i < _vector.Length; i++)
                _vector[i] = ran.Next(0, 10000);

            Array.Sort(_vector);
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD BUSCAR
        public int Buscar(int valor)
        {
            return Buscar(valor, _ls, _li, _ls);
        }
        private int Buscar(int valor, int media, int li, int ls)
        {
            int indice = 0;

            if (li != ls && li < ls && ls - li != 1)
            {
                if (_vector[media] > valor)
                {
                    _cout++;
                    ls = media;
                    media -= (ls - li) / 2;
                }
                if (_vector[media] < valor)
                {
                    li = media;
                    media += (ls - li) / 2;
                    _cout++;
                }
                if (_vector[media] == valor)
                    indice = media;

                indice = Buscar(valor, media, li, ls);
            }
            return indice;
        }
    }
}
