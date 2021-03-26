

using System;

namespace FCSchoolLibrary
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class Book
    {

        [Column(Order = 0)]
        public int Id { get; set; }

        public int InventoryNumber { get; set; }
        
        [Column(Order = 1)]
        public string Author { get; set; }

        
        [Column(Order = 2)]
        public string Name { get; set; }

        
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }

        
        [Column(Order = 4)]
        public string PublishPlace { get; set; }

        
        [Column(Order = 5)]
        public string PublishName { get; set; }

        public string Serial { get; set; }

        
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Count { get; set; }

 
        [Column(Order = 7, TypeName = "money")]
        public decimal Price { get; set; }

        
        [Column(Order = 8)]
        [StringLength(50)]
        public string Department { get; set; }

        
        [Column(Order = 9)]
        [StringLength(20)]
        public string Cipher { get; set; }

        
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pages { get; set; }

        public string Subject { get; set; }

        [StringLength(50)]
        public string Genre { get; set; }

        public string ISBN { get; set; }

        public int? Age { get; set; }

        
    }
}
