using System.Reflection;

namespace RestauranteAPI.Domain.Common
{
    public class BaseEntity
    {
        //Guid é um tipo de Id único, que mesmo que um elemento seja excluído, por exemplo, esse Id nunca será repetido
        public Guid Id { get; set; }
        //Data de criação da entidade
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
        //Data de atualização da entidade, a entidade pode ter sido ou não atualizada, por isso o "?"
        public DateTimeOffset? DateUpdated { get; set; }
        //Data de Delete da entidade
        public DateTimeOffset? DateDeleted { get; set; }

        public void Create()
        {
            Id = Guid.NewGuid();
        }

        public void Update(BaseEntity entity)
        {
            //foreach genérico que pega uma entidade genérica, que herde de baseEntity, e atualiza todos seus atributos 
            foreach (PropertyInfo property in entity.GetType().GetProperties())
            {
                /*Verificação de se existe valor nulo, se ela pode ser sobrescrida e se o nome não é seu Id, para o Id não ser
                sobrescrito pelo mesmo motivo, verifica se o name não é a data de criação*/
                if (property.CanWrite && property.Name != nameof(Id) && property.Name != nameof(DateCreated))
                {
                    property.SetValue(this, property.GetValue(entity));
                }
            }

            this.DateUpdated = DateTime.Now;
        }

        public void Delete()
        {
            this.DateDeleted = DateTime.Now;
        }
    }
}
