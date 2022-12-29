
using System.ComponentModel.DataAnnotations;

public class Shop
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public List<CupCake> Cupcakes { get; set; }
        //included when we use an include method when it comes to services - will show up in Azure based on Foreign Key relationship.
        //Select from Cupcakes where Shop ID = x <<SQL query
    }
