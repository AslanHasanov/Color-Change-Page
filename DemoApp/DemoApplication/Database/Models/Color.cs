using DemoApplication.Database.Models.Common;

namespace DemoApplication.Database.Models
{
    public class Color : BaseEntity
    {
        public Color(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }
    }
}
