using AppDevelopmentProject.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace AppDevelopmentProject.Entities
{
    public class Order : IEntity
    {
        [Key]
        public Guid Id { get; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Number { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Guid UserId { get; set; }
        public Guid WareHouseId { get; set; }


        [NotMapped]
        public User User { get; set; } = null;
        [NotMapped]
        public WareHouse WareHouse { get; set; } = null;


        public Order(string name, string number)
        {
            Id = Guid.NewGuid();
            Name = name;
            Number = number;
        }

        public string ToString()
        {
            return $"Заказ №{Number} от {CreateDate.Value.Date}!";
        }
    }
}
