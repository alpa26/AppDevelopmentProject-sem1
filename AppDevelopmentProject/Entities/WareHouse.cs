using AppDevelopmentProject.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace AppDevelopmentProject.Entities
{
    public class WareHouse : IEntity
    {
        [Key]
        public Guid Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
