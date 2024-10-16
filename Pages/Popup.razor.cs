using Microsoft.AspNetCore.Components;

namespace workshop_i1_grp14.Pages
{
    public partial class Popup : ComponentBase
    {
        // Etat par défaut pour "Sanity"
        private bool isSanity = true;

        private int? filteredValue = null; // Par défaut null, indiquant qu'il n'y a rien

        // Méthode pour basculer entre "Sanity" et "InSanity"
        private void ToggleSanity(ChangeEventArgs e)
        {
            isSanity = !isSanity;
        }

        public void UpdateFilteredValue(int? newValue)
        {
            filteredValue = newValue;
        }
    }
}
