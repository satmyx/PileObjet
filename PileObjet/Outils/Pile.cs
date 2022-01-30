using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesOutils
{
    /// <summary>
    /// Pile contenant pouvant contenir des entiers.
    /// On ajoute après le dernier élément ajouté
    /// On retire toujours le dernier élément ajouté
    /// </summary>
    class Pile<T>
    {
        /// <summary>
        /// Liste contenant les élements de la Pile
        /// </summary>
        private List<T> elements;

        public Pile()
        {
            // Crée une liste vide a partir d'elements
            this.elements = new List<T>();
        }
        public bool PileVide()
        {
            return this.elements.Count == 0;
        }
        /// <summary>
        /// Place l'élément passé en paramètre au sommet de la pile
        /// </summary>
        /// <param name="valeur">Valeur à empiler</param>
        public void Empiler(T valeur)
        {
            this.elements.Add(valeur);
        }
        public int Count { get => this.elements.Count; }
        public T Depiler()
        {
            if (PileVide() == false)
            {
                T nbARetourner = this.elements[this.elements.Count - 1];
                this.elements.Remove(this.elements[this.elements.Count - 1]);
                return nbARetourner;
            }
            else
            {
                throw new Exception("Impossible de dépiler, pile vide");
            }
        }
    }
}
