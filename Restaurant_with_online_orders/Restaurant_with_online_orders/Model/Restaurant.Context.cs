﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant_with_online_orders.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RestaurantEntities : DbContext
    {
        public RestaurantEntities()
            : base("name=RestaurantEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alergen> Alergens { get; set; }
        public virtual DbSet<Categorie_preparat> Categorie_preparat { get; set; }
        public virtual DbSet<Categorie_utilizator> Categorie_utilizator { get; set; }
        public virtual DbSet<Comanda> Comandas { get; set; }
        public virtual DbSet<Cont_utilizator> Cont_utilizator { get; set; }
        public virtual DbSet<Fotografie> Fotografies { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Meniu> Menius { get; set; }
        public virtual DbSet<Meniu_Preparat> Meniu_Preparat { get; set; }
        public virtual DbSet<Preparat> Preparats { get; set; }
        public virtual DbSet<Preparat_Alergen> Preparat_Alergen { get; set; }
        public virtual DbSet<Stare_Comanda> Stare_Comanda { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int AddCategoriePreparat(string tip)
        {
            var tipParameter = tip != null ?
                new ObjectParameter("tip", tip) :
                new ObjectParameter("tip", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddCategoriePreparat", tipParameter);
        }
    
        public virtual int AddClient(string nume, string prenume, string nr_tel, string adresa, string email, string parola, Nullable<int> id_categorie)
        {
            var numeParameter = nume != null ?
                new ObjectParameter("nume", nume) :
                new ObjectParameter("nume", typeof(string));
    
            var prenumeParameter = prenume != null ?
                new ObjectParameter("prenume", prenume) :
                new ObjectParameter("prenume", typeof(string));
    
            var nr_telParameter = nr_tel != null ?
                new ObjectParameter("nr_tel", nr_tel) :
                new ObjectParameter("nr_tel", typeof(string));
    
            var adresaParameter = adresa != null ?
                new ObjectParameter("adresa", adresa) :
                new ObjectParameter("adresa", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var parolaParameter = parola != null ?
                new ObjectParameter("parola", parola) :
                new ObjectParameter("parola", typeof(string));
    
            var id_categorieParameter = id_categorie.HasValue ?
                new ObjectParameter("id_categorie", id_categorie) :
                new ObjectParameter("id_categorie", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddClient", numeParameter, prenumeParameter, nr_telParameter, adresaParameter, emailParameter, parolaParameter, id_categorieParameter);
        }
    
        public virtual int AddComanda(Nullable<int> id_utilizator, Nullable<int> id_stare_comanda, Nullable<double> pret, Nullable<System.DateTime> data, string cod)
        {
            var id_utilizatorParameter = id_utilizator.HasValue ?
                new ObjectParameter("id_utilizator", id_utilizator) :
                new ObjectParameter("id_utilizator", typeof(int));
    
            var id_stare_comandaParameter = id_stare_comanda.HasValue ?
                new ObjectParameter("id_stare_comanda", id_stare_comanda) :
                new ObjectParameter("id_stare_comanda", typeof(int));
    
            var pretParameter = pret.HasValue ?
                new ObjectParameter("pret", pret) :
                new ObjectParameter("pret", typeof(double));
    
            var dataParameter = data.HasValue ?
                new ObjectParameter("data", data) :
                new ObjectParameter("data", typeof(System.DateTime));
    
            var codParameter = cod != null ?
                new ObjectParameter("cod", cod) :
                new ObjectParameter("cod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddComanda", id_utilizatorParameter, id_stare_comandaParameter, pretParameter, dataParameter, codParameter);
        }
    
        public virtual int AddFotografie(Nullable<int> id_preparat, string url)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddFotografie", id_preparatParameter, urlParameter);
        }
    
        public virtual int AddItemMeniu(Nullable<int> id_meniu)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddItemMeniu", id_meniuParameter);
        }
    
        public virtual int AddItemPreparat(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddItemPreparat", id_preparatParameter);
        }
    
        public virtual int AddMeniuForComands(Nullable<int> id_meniu, Nullable<int> id_comanda)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            var id_comandaParameter = id_comanda.HasValue ?
                new ObjectParameter("id_comanda", id_comanda) :
                new ObjectParameter("id_comanda", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddMeniuForComands", id_meniuParameter, id_comandaParameter);
        }
    
        public virtual int AddPreparat(string denumire, Nullable<int> id_categorie, Nullable<double> pret, Nullable<int> cantitateP, Nullable<int> cantitateT)
        {
            var denumireParameter = denumire != null ?
                new ObjectParameter("denumire", denumire) :
                new ObjectParameter("denumire", typeof(string));
    
            var id_categorieParameter = id_categorie.HasValue ?
                new ObjectParameter("id_categorie", id_categorie) :
                new ObjectParameter("id_categorie", typeof(int));
    
            var pretParameter = pret.HasValue ?
                new ObjectParameter("pret", pret) :
                new ObjectParameter("pret", typeof(double));
    
            var cantitatePParameter = cantitateP.HasValue ?
                new ObjectParameter("cantitateP", cantitateP) :
                new ObjectParameter("cantitateP", typeof(int));
    
            var cantitateTParameter = cantitateT.HasValue ?
                new ObjectParameter("cantitateT", cantitateT) :
                new ObjectParameter("cantitateT", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPreparat", denumireParameter, id_categorieParameter, pretParameter, cantitatePParameter, cantitateTParameter);
        }
    
        public virtual int AddPreparat_Alergen(Nullable<int> id_preparat, Nullable<int> id_alergen)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            var id_alergenParameter = id_alergen.HasValue ?
                new ObjectParameter("id_alergen", id_alergen) :
                new ObjectParameter("id_alergen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPreparat_Alergen", id_preparatParameter, id_alergenParameter);
        }
    
        public virtual int AddPreparatForComands(Nullable<int> id_preparat, Nullable<int> id_comanda)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            var id_comandaParameter = id_comanda.HasValue ?
                new ObjectParameter("id_comanda", id_comanda) :
                new ObjectParameter("id_comanda", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPreparatForComands", id_preparatParameter, id_comandaParameter);
        }
    
        public virtual ObjectResult<ComenzileDescrescator_Result> ComenzileDescrescator()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ComenzileDescrescator_Result>("ComenzileDescrescator");
        }
    
        public virtual int DeleteFotografie(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteFotografie", id_preparatParameter);
        }
    
        public virtual int DeleteMeniu(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMeniu", idParameter);
        }
    
        public virtual int DeleteMeniu_Preparat(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMeniu_Preparat", idParameter);
        }
    
        public virtual int DeletePreparat(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePreparat", idParameter);
        }
    
        public virtual int DeletePreparat_Alergen(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePreparat_Alergen", id_preparatParameter);
        }
    
        public virtual int DeletePreparatMeniu(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePreparatMeniu", id_preparatParameter);
        }
    
        public virtual ObjectResult<string> GetAdresa(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetAdresa", idParameter);
        }
    
        public virtual ObjectResult<string> GetAlergeniMeniu(Nullable<int> id_meniu)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetAlergeniMeniu", id_meniuParameter);
        }
    
        public virtual int GetCantitate(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetCantitate", id_preparatParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetCantitateFromPreparat(Nullable<int> id_meniu)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetCantitateFromPreparat", id_meniuParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetCantitateMeniu(Nullable<int> id_meniu)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetCantitateMeniu", id_meniuParameter);
        }
    
        public virtual ObjectResult<string> GetCategorie(Nullable<int> id_cat)
        {
            var id_catParameter = id_cat.HasValue ?
                new ObjectParameter("id_cat", id_cat) :
                new ObjectParameter("id_cat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetCategorie", id_catParameter);
        }
    
        public virtual ObjectResult<string> GetDenumireAlergen(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetDenumireAlergen", id_preparatParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetIdAlergen(string denumire)
        {
            var denumireParameter = denumire != null ?
                new ObjectParameter("denumire", denumire) :
                new ObjectParameter("denumire", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetIdAlergen", denumireParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetIdMeniu(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetIdMeniu", id_preparatParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetIDPreparat(Nullable<int> id_meniu)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetIDPreparat", id_meniuParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetIDPreparatFromAlergen(string denumire)
        {
            var denumireParameter = denumire != null ?
                new ObjectParameter("denumire", denumire) :
                new ObjectParameter("denumire", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetIDPreparatFromAlergen", denumireParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetIdPreparatFromPM(Nullable<int> id_meniu)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetIdPreparatFromPM", id_meniuParameter);
        }
    
        public virtual ObjectResult<string> GetMeniu(Nullable<int> id_meniu)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetMeniu", id_meniuParameter);
        }
    
        public virtual ObjectResult<string> GetNume(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetNume", idParameter);
        }
    
        public virtual ObjectResult<string> GetPrenume(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetPrenume", idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetPreparatCantitate(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetPreparatCantitate", id_preparatParameter);
        }
    
        public virtual ObjectResult<string> GetPreparatDenumire(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetPreparatDenumire", id_preparatParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> GetPreparatPret(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("GetPreparatPret", id_preparatParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> GetPret(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("GetPret", id_preparatParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> GetPretFromPreparat(Nullable<int> id_meniu)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("GetPretFromPreparat", id_meniuParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> GetPretMeniu(Nullable<int> id_meniu)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("GetPretMeniu", id_meniuParameter);
        }
    
        public virtual ObjectResult<string> GetStare(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetStare", idParameter);
        }
    
        public virtual ObjectResult<string> GetTelefon(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetTelefon", idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetUserId(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetUserId", emailParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetUserType(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetUserType", emailParameter);
        }
    
        public virtual int ModifyCantitateLaAnulare(Nullable<int> id_preparat)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyCantitateLaAnulare", id_preparatParameter);
        }
    
        public virtual int ModifyCantitatePreparat(Nullable<int> id_preparat, Nullable<int> cantitate)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            var cantitateParameter = cantitate.HasValue ?
                new ObjectParameter("cantitate", cantitate) :
                new ObjectParameter("cantitate", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyCantitatePreparat", id_preparatParameter, cantitateParameter);
        }
    
        public virtual int ModifyFotografie(Nullable<int> id_preparat, string denumire)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            var denumireParameter = denumire != null ?
                new ObjectParameter("denumire", denumire) :
                new ObjectParameter("denumire", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyFotografie", id_preparatParameter, denumireParameter);
        }
    
        public virtual int ModifyMeniu(Nullable<int> id_meniu, string denumire, string fotografie, Nullable<int> categorie)
        {
            var id_meniuParameter = id_meniu.HasValue ?
                new ObjectParameter("id_meniu", id_meniu) :
                new ObjectParameter("id_meniu", typeof(int));
    
            var denumireParameter = denumire != null ?
                new ObjectParameter("denumire", denumire) :
                new ObjectParameter("denumire", typeof(string));
    
            var fotografieParameter = fotografie != null ?
                new ObjectParameter("fotografie", fotografie) :
                new ObjectParameter("fotografie", typeof(string));
    
            var categorieParameter = categorie.HasValue ?
                new ObjectParameter("categorie", categorie) :
                new ObjectParameter("categorie", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyMeniu", id_meniuParameter, denumireParameter, fotografieParameter, categorieParameter);
        }
    
        public virtual int ModifyPreparat(Nullable<int> id_preparat, string denumire, Nullable<double> pret, Nullable<int> cantitateP, Nullable<int> cantitateT, Nullable<int> categorie)
        {
            var id_preparatParameter = id_preparat.HasValue ?
                new ObjectParameter("id_preparat", id_preparat) :
                new ObjectParameter("id_preparat", typeof(int));
    
            var denumireParameter = denumire != null ?
                new ObjectParameter("denumire", denumire) :
                new ObjectParameter("denumire", typeof(string));
    
            var pretParameter = pret.HasValue ?
                new ObjectParameter("pret", pret) :
                new ObjectParameter("pret", typeof(double));
    
            var cantitatePParameter = cantitateP.HasValue ?
                new ObjectParameter("cantitateP", cantitateP) :
                new ObjectParameter("cantitateP", typeof(int));
    
            var cantitateTParameter = cantitateT.HasValue ?
                new ObjectParameter("cantitateT", cantitateT) :
                new ObjectParameter("cantitateT", typeof(int));
    
            var categorieParameter = categorie.HasValue ?
                new ObjectParameter("categorie", categorie) :
                new ObjectParameter("categorie", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyPreparat", id_preparatParameter, denumireParameter, pretParameter, cantitatePParameter, cantitateTParameter, categorieParameter);
        }
    
        public virtual int ModifyStare(Nullable<int> id_stare, Nullable<int> id, Nullable<System.DateTime> ora)
        {
            var id_stareParameter = id_stare.HasValue ?
                new ObjectParameter("id_stare", id_stare) :
                new ObjectParameter("id_stare", typeof(int));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var oraParameter = ora.HasValue ?
                new ObjectParameter("ora", ora) :
                new ObjectParameter("ora", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyStare", id_stareParameter, idParameter, oraParameter);
        }
    
        public virtual int ModifyStareFaraOra(Nullable<int> id_stare, Nullable<int> id)
        {
            var id_stareParameter = id_stare.HasValue ?
                new ObjectParameter("id_stare", id_stare) :
                new ObjectParameter("id_stare", typeof(int));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyStareFaraOra", id_stareParameter, idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> ShowAlergeni(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ShowAlergeni", idParameter);
        }
    
        public virtual ObjectResult<string> ShowPictures(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ShowPictures", idParameter);
        }
    
        public virtual ObjectResult<string> Shows_name_allergen(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Shows_name_allergen", idParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
