namespace RestauranteAPI.Application.DTOs.Common
{
    //Data Transfer Object (DTO), em sua base possuirá apenas um Guid
    public class BaseDTO
    {
        public Guid Id { get; set; }
    }
}


//Handlers servem 

//Controller envia para o mediator, sem se importar para qual repositório instanciar o atributo. O mediator lida com o atributo e manda para o lugar certo