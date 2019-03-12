using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Corredor
    {
        private int _numero;
        private int _posicion;
        private Random gen = new Random();

        public Corredor(int numero)
        {
            _numero = numero;
            _posicion = 0;

        }

        public int Numero
        {
            get { return _numero; }
        }

        public int Posicion
        {
            get { return _posicion; }
        }
        public override string ToString()
        {
            return _numero + "Esta en: " + _posicion;
        }
        public void correr()
        {
            int x = gen.Next(1, 6);
            if (x < 3)
                _posicion++;
            else if (x < 5)
                _posicion += 2;
            else
                _posicion += 3;
        }
        public void correr2()
        {
            int x = gen.Next(1, 6);
            if (x < 3)
                _posicion++;
            else if (x < 5)
                _posicion += 2;
            else
                _posicion += 3;
        }
    }
}
