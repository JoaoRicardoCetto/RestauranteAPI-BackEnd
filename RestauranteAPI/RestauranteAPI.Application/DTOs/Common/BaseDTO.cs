namespace RestauranteAPI.Application.DTOs.Common
{
    //Data Transfer Object (DTO), em sua base possuirá apenas um Guid
    public class BaseDTO
    {
        public Guid Id { get; set; }
    }
}
