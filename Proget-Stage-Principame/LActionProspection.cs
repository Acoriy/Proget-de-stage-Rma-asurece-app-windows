//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proget_Stage_Principame
{
    using System;
    using System.Collections.Generic;
    
    public partial class LActionProspection
    {
        public int codeac { get; set; }
        public Nullable<System.DateTime> dateProspection { get; set; }
        public Nullable<int> code { get; set; }
        public string sontelephone { get; set; }
        public string objectDeProspection { get; set; }
        public string moiyenDeContactPreferé { get; set; }
        public string resultat { get; set; }
        public Nullable<System.DateTime> dateEchance { get; set; }
        public string Persson_inflient { get; set; }
        public string observation { get; set; }
        public string Nom { get; set; }
    
        public virtual Prospect Prospect { get; set; }
    }
}
