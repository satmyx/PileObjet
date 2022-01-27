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
    class Pile
    {
        /// <summary>
        /// Nombre maximum d'élements de la Pile
        /// </summary>
        private int nbMaxElt;
        /// <summary>
        /// Liste contenant les élements de la Pile
        /// </summary>
        private List<int> elements;

        public Pile(int nbMaxElt)
        {
            this.nbMaxElt = nbMaxElt;
            // Crée une liste vide a partir d'elements
            this.elements = new List<int>();
        }
        public bool PileVide()
        {
            return this.elements.Count == 0;
        }
        public bool PilePleine()
        {
            return this.elements.Count == this.nbMaxElt;
        }
        public void Empiler(int nb)
        {
            if (PilePleine() == false)
            {
                this.elements.Add(nb);
            }
            else
            {
                throw new Exception("Impossible d'empiler, pile pleine");
            }
        }
        public int Depiler()
        {
            if (PileVide() == false)
            {
                int nbARetourner = this.elements[this.elements.Count - 1];
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
