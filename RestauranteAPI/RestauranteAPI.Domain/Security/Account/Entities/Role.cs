using RestauranteAPI.Domain.Security.Shared.Entities;

namespace RestauranteAPI.Domain.Security.Account.Entities
{
    public class Role : Entity
    {
        public string Name { get; set; } = string.Empty;
        public List<User> Users { get; set; } = new();

        public Role(string name)
        {
            Name = name;
        }
    }
}
