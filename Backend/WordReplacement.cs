using System.Collections.Generic;
using System.Linq;

namespace workshop_i1_grp14.Backend
{
    public class WordReplacement
    {
        public string Original { get; set; }
        public string Replacement { get; set; }


        // TODO: A remplacer avec une vrai methode pour fetch les éléments de la BDD.
        public List<WordReplacement> GetWordReplacements()
        {
            List<WordReplacement> list = new List<WordReplacement>();
            list.Append(new WordReplacement { Original = "Connard", Replacement = "Chouette Hulotte" });
            list.Append(new WordReplacement { Original = "Batard", Replacement = "Grue" });
            return list;
        }
    }
}
