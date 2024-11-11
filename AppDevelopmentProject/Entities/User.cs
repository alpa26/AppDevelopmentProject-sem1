using AppDevelopmentProject.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace AppDevelopmentProject.Entities
{
    public class User : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
