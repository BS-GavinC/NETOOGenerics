using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETOOGenerics
{
    public class Stouck<T>
    {
        //Écrivez une classe générique appelée Stack qui implémente une structure
        //de pile(Last In, First Out - LIFO). La classe doit avoir des méthodes Push
        //pour ajouter un élément à la pile, Pop pour retirer le dernier élément ajouté
        //et le retourner, et Peek pour obtenir le dernier élément ajouté sans le retirer.

        List<T> pile = new List<T>();

        public void push(T item)
        {
            pile.Add(item);
        }

        public T? Pop()
        {
            T item;

            if (pile.Count != 0)
            {
                item = pile.Last();
                pile.RemoveAt(pile.Count - 1);
                return item;
            }

            return default(T);
        }

        public T? Peek()
        {
            if (pile.Count != 0)
            {
                return pile.Last();
            }
            return default(T);
        }

    }
}
