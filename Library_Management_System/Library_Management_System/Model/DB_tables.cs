using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    public class DB_tables : DbContext
    {
        public DB_tables() : base("name=connect")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<BOOKDETAIL> BOOKDETAILS { get; set; }
        public virtual DbSet<BOOK_CATALOG> BOOK_CATALOGS { get; set; }
        public virtual DbSet<MEMBER> MEMBERS { get; set; }
        public virtual DbSet<ISSUED_BOOK> ISSUED_BOOKS { get; set; }
        public virtual DbSet<ISSUED_DAYS_LIMIT> ISSUED_DAYS_LIMITS { get; set; }
        public virtual DbSet<RETURN_BOOK> RETURN_BOOKS { get; set; }
    }

    public class USER
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string SECURTITY_QUESTION { get; set; }
        public string SECURTITY_ANSWER { get; set; }
        public string ROLE { get; set; }
        public virtual ICollection<BOOKDETAIL> BOOKDETAILS { get; set; }
        public virtual ICollection<MEMBER> MEMBERS { get; set; }
        public virtual ICollection<ISSUED_BOOK> ISSUED_BOOKS { get; set; }
        public virtual ICollection<BOOK_CATALOG> BOOK_CATALOGS { get; set; }
        public virtual ICollection<ISSUED_DAYS_LIMIT> ISSUED_DAYS_LIMITS { get; set; }
        public virtual ICollection<RETURN_BOOK> RETURN_BOOKS { get; set; }
    }
    public class BOOKDETAIL
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public string LANGUAGE { get; set; }
        public string NO_OF_COPIES_ACTUAL { get; set; }
        public string NO_OF_COPIES_CURRENT { get; set; }
        public string PUBLICATION_YEAR { get; set; }
        public string AUTHOR_NAME { get; set; }
        [ForeignKey("USER")]
        public int USER_ID { get; set; } 
        public virtual USER USER { get; set; }
        [ForeignKey("BOOK_CATALOG")]
        public int Book_Catalog { get; set; }
        public virtual BOOK_CATALOG BOOK_CATALOG { get; set; }
        public virtual ICollection<ISSUED_BOOK> ISSUED_BOOKS { get; set; }
        public bool STATUS { get; set; }
    }
    public class MEMBER
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string GENDER { get; set; }
        public string DEPARTMENT { get; set; }
        public string CONTACT_NUMBER { get; set; }
        public string CNIC { get; set; }
        public string ADDRESS { get; set; }
        public string ROLE { get; set; }
        [ForeignKey("USER")]
        public int REGISTERED_BY { get; set; }
        public virtual USER USER { get; set; }
    }
    public class ISSUED_BOOK
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("BOOKDETAIL")]
        public int BOOKDETAIL_ID { get; set; }
        public virtual BOOKDETAIL BOOKDETAIL { get; set; }
        [ForeignKey("USER")]
        public int ISSUED_BY { get; set; }
        public virtual USER USER { get; set; }
        [ForeignKey("MEMBER")]
        public int ISSUED_TO { get; set; }
        public virtual MEMBER MEMBER { get; set; }
        public DateTime ISSUED_ON { get; set; }
        [ForeignKey("ISSUED_DAYS_LIMIT")]
        public int DAY_LIMIT { get; set; }
        public virtual ISSUED_DAYS_LIMIT ISSUED_DAYS_LIMIT { get; set; }
        [ForeignKey("BOOK_CATALOG")]
        public int IB_BOOKCAT { get; set; }
        public virtual BOOK_CATALOG BOOK_CATALOG { get; set; }
        public virtual ICollection<RETURN_BOOK> RETURN_BOOKS { get; set; }


    }
    public class BOOK_CATALOG
    {
        [Key]
        public int ID { get; set; }
        public string CATALOG_NAME { get; set; }
        [ForeignKey("USER")]
        public int ISSUED_BY { get; set; }
        public virtual USER USER { get; set; }
        public virtual ICollection<BOOKDETAIL> BOOKDETAILS { get; set; }
    }
  
    public class ISSUED_DAYS_LIMIT
    {
        [Key]
        public int ID { get; set; }
        public string DAYS { get; set; }
        [ForeignKey("USER")]
        public int USER_ID { get; set; }
        public virtual USER USER { get; set; }
        public virtual ICollection<ISSUED_BOOK> ISSUED_BOOKS { get; set; }

    }
    public class RETURN_BOOK
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ISSUED_BOOK")]
        public int BOOKDETAIL_ID { get; set; }
        public virtual ISSUED_BOOK ISSUED_BOOK { get; set; }
        public string FINE { get; set; }
        public DateTime RETURN_DATE { get; set; }
        [ForeignKey("USER")]
        public int USER_ID { get; set; }
        public virtual USER USER { get; set; }
    }
}

