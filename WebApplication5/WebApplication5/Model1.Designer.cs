﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace WebApplication5
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ProCatEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ProCatEntities1 object using the connection string found in the 'ProCatEntities1' section of the application configuration file.
        /// </summary>
        public ProCatEntities1() : base("name=ProCatEntities1", "ProCatEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProCatEntities1 object.
        /// </summary>
        public ProCatEntities1(string connectionString) : base(connectionString, "ProCatEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProCatEntities1 object.
        /// </summary>
        public ProCatEntities1(EntityConnection connection) : base(connection, "ProCatEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Category> Categories
        {
            get
            {
                if ((_Categories == null))
                {
                    _Categories = base.CreateObjectSet<Category>("Categories");
                }
                return _Categories;
            }
        }
        private ObjectSet<Category> _Categories;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Mapping> Mappings
        {
            get
            {
                if ((_Mappings == null))
                {
                    _Mappings = base.CreateObjectSet<Mapping>("Mappings");
                }
                return _Mappings;
            }
        }
        private ObjectSet<Mapping> _Mappings;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<sysdiagram> sysdiagrams
        {
            get
            {
                if ((_sysdiagrams == null))
                {
                    _sysdiagrams = base.CreateObjectSet<sysdiagram>("sysdiagrams");
                }
                return _sysdiagrams;
            }
        }
        private ObjectSet<sysdiagram> _sysdiagrams;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Categories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCategories(Category category)
        {
            base.AddObject("Categories", category);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Mappings EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMappings(Mapping mapping)
        {
            base.AddObject("Mappings", mapping);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the sysdiagrams EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosysdiagrams(sysdiagram sysdiagram)
        {
            base.AddObject("sysdiagrams", sysdiagram);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ProCatModel", Name="Category")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Category : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Category object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="categoryName">Initial value of the CategoryName property.</param>
        public static Category CreateCategory(global::System.Int32 id, global::System.String categoryName)
        {
            Category category = new Category();
            category.Id = id;
            category.CategoryName = categoryName;
            return category;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CategoryName
        {
            get
            {
                return _CategoryName;
            }
            set
            {
                OnCategoryNameChanging(value);
                ReportPropertyChanging("CategoryName");
                _CategoryName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CategoryName");
                OnCategoryNameChanged();
            }
        }
        private global::System.String _CategoryName;
        partial void OnCategoryNameChanging(global::System.String value);
        partial void OnCategoryNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CategoryType
        {
            get
            {
                return _CategoryType;
            }
            set
            {
                OnCategoryTypeChanging(value);
                ReportPropertyChanging("CategoryType");
                _CategoryType = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CategoryType");
                OnCategoryTypeChanged();
            }
        }
        private global::System.String _CategoryType;
        partial void OnCategoryTypeChanging(global::System.String value);
        partial void OnCategoryTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ParentCategoryId
        {
            get
            {
                return _ParentCategoryId;
            }
            set
            {
                OnParentCategoryIdChanging(value);
                ReportPropertyChanging("ParentCategoryId");
                _ParentCategoryId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ParentCategoryId");
                OnParentCategoryIdChanged();
            }
        }
        private Nullable<global::System.Int32> _ParentCategoryId;
        partial void OnParentCategoryIdChanging(Nullable<global::System.Int32> value);
        partial void OnParentCategoryIdChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ProCatModel", Name="Mapping")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Mapping : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Mapping object.
        /// </summary>
        /// <param name="map_id">Initial value of the Map_id property.</param>
        /// <param name="prodID">Initial value of the ProdID property.</param>
        /// <param name="id">Initial value of the Id property.</param>
        public static Mapping CreateMapping(global::System.Int32 map_id, global::System.Int32 prodID, global::System.Int32 id)
        {
            Mapping mapping = new Mapping();
            mapping.Map_id = map_id;
            mapping.ProdID = prodID;
            mapping.Id = id;
            return mapping;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Map_id
        {
            get
            {
                return _Map_id;
            }
            set
            {
                if (_Map_id != value)
                {
                    OnMap_idChanging(value);
                    ReportPropertyChanging("Map_id");
                    _Map_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Map_id");
                    OnMap_idChanged();
                }
            }
        }
        private global::System.Int32 _Map_id;
        partial void OnMap_idChanging(global::System.Int32 value);
        partial void OnMap_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProdID
        {
            get
            {
                return _ProdID;
            }
            set
            {
                OnProdIDChanging(value);
                ReportPropertyChanging("ProdID");
                _ProdID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProdID");
                OnProdIDChanged();
            }
        }
        private global::System.Int32 _ProdID;
        partial void OnProdIDChanging(global::System.Int32 value);
        partial void OnProdIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                OnIdChanging(value);
                ReportPropertyChanging("Id");
                _Id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Id");
                OnIdChanged();
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ProCatModel", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="prodID">Initial value of the ProdID property.</param>
        /// <param name="prodName">Initial value of the ProdName property.</param>
        /// <param name="parentId">Initial value of the ParentId property.</param>
        /// <param name="chidId">Initial value of the ChidId property.</param>
        public static Product CreateProduct(global::System.Int32 prodID, global::System.String prodName, global::System.Int32 parentId, global::System.Int32 chidId)
        {
            Product product = new Product();
            product.ProdID = prodID;
            product.ProdName = prodName;
            product.ParentId = parentId;
            product.ChidId = chidId;
            return product;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProdID
        {
            get
            {
                return _ProdID;
            }
            set
            {
                if (_ProdID != value)
                {
                    OnProdIDChanging(value);
                    ReportPropertyChanging("ProdID");
                    _ProdID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProdID");
                    OnProdIDChanged();
                }
            }
        }
        private global::System.Int32 _ProdID;
        partial void OnProdIDChanging(global::System.Int32 value);
        partial void OnProdIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ProdName
        {
            get
            {
                return _ProdName;
            }
            set
            {
                OnProdNameChanging(value);
                ReportPropertyChanging("ProdName");
                _ProdName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ProdName");
                OnProdNameChanged();
            }
        }
        private global::System.String _ProdName;
        partial void OnProdNameChanging(global::System.String value);
        partial void OnProdNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _Price;
        partial void OnPriceChanging(Nullable<global::System.Decimal> value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ParentId
        {
            get
            {
                return _ParentId;
            }
            set
            {
                OnParentIdChanging(value);
                ReportPropertyChanging("ParentId");
                _ParentId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ParentId");
                OnParentIdChanged();
            }
        }
        private global::System.Int32 _ParentId;
        partial void OnParentIdChanging(global::System.Int32 value);
        partial void OnParentIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ChidId
        {
            get
            {
                return _ChidId;
            }
            set
            {
                OnChidIdChanging(value);
                ReportPropertyChanging("ChidId");
                _ChidId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ChidId");
                OnChidIdChanged();
            }
        }
        private global::System.Int32 _ChidId;
        partial void OnChidIdChanging(global::System.Int32 value);
        partial void OnChidIdChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ProCatModel", Name="sysdiagram")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sysdiagram : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new sysdiagram object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="principal_id">Initial value of the principal_id property.</param>
        /// <param name="diagram_id">Initial value of the diagram_id property.</param>
        public static sysdiagram Createsysdiagram(global::System.String name, global::System.Int32 principal_id, global::System.Int32 diagram_id)
        {
            sysdiagram sysdiagram = new sysdiagram();
            sysdiagram.name = name;
            sysdiagram.principal_id = principal_id;
            sysdiagram.diagram_id = diagram_id;
            return sysdiagram;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 principal_id
        {
            get
            {
                return _principal_id;
            }
            set
            {
                Onprincipal_idChanging(value);
                ReportPropertyChanging("principal_id");
                _principal_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("principal_id");
                Onprincipal_idChanged();
            }
        }
        private global::System.Int32 _principal_id;
        partial void Onprincipal_idChanging(global::System.Int32 value);
        partial void Onprincipal_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 diagram_id
        {
            get
            {
                return _diagram_id;
            }
            set
            {
                if (_diagram_id != value)
                {
                    Ondiagram_idChanging(value);
                    ReportPropertyChanging("diagram_id");
                    _diagram_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("diagram_id");
                    Ondiagram_idChanged();
                }
            }
        }
        private global::System.Int32 _diagram_id;
        partial void Ondiagram_idChanging(global::System.Int32 value);
        partial void Ondiagram_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] definition
        {
            get
            {
                return StructuralObject.GetValidValue(_definition);
            }
            set
            {
                OndefinitionChanging(value);
                ReportPropertyChanging("definition");
                _definition = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("definition");
                OndefinitionChanged();
            }
        }
        private global::System.Byte[] _definition;
        partial void OndefinitionChanging(global::System.Byte[] value);
        partial void OndefinitionChanged();

        #endregion

    
    }

    #endregion

    
}