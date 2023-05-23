using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NETOOGenerics
{
    public static class Exo
    {
        //Ecrivez une classe générique appelée Swap qui possède une méthode statique
        //SwapValues qui échange les valeurs de deux variables du même type.
        //Utilisez les génériques pour permettre l'échange de différents types de
        //variables (int, string, etc.).

        public static void SwapValues<TSource>(ref TSource a, ref TSource b)
        {
            (a, b) = (b, a); 
        }

        
        public static double Add<T1, T2>(T1 a, T2 b) 
            where T1 : struct,
          IComparable,
          IComparable<T1>,
          IConvertible,
          IEquatable<T1>,
          IFormattable
            where T2 : struct,
          IComparable,
          IComparable<T2>,
          IConvertible,
          IEquatable<T2>,
          IFormattable
        {
            try
            {
                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);

                return a2 + b2;
            }
            catch (Exception)
            {
                return 0;
            }

        }




    }
}
