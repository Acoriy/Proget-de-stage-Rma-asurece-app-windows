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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class prospectEnty : DbContext
    {
        public prospectEnty()
            : base("name=prospectEnty")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Prospect> Prospects { get; set; }
        public DbSet<Logine> Logines { get; set; }
        public DbSet<LActionProspection> LActionProspections { get; set; }
    
        public virtual ObjectResult<ListeAction_Result> ListeAction()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListeAction_Result>("ListeAction");
        }
    }
}
