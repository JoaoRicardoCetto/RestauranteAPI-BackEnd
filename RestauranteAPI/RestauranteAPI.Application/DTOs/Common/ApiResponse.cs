using System.Text.Json.Serialization;

namespace RestauranteAPI.Application.DTOs.Common
{
    //Padroniza o tipo de resposta para o front-end
    public class ApiResponse : ResponseBase
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] //Quando a Uri for nula, ela não aparecerá no Json
        //Quando um objeto é criado, a Uri guarda sua rota, permitindo acesso ao objeto por essa rota
        public string? Uri { get; set; } 
        //Mensagem de sucesso, erro, etc
        public string Message { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] //Quando o Body for nulo, ele não aparecerá no Json
        //Corpo da resposta, contendo os dados retornados pela API
        public object? Body { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] //Quando a Lista de erros for nula, ela não aparecerá no Json
        // Lista de erros ocorridos durante a requisição.
        public List<string>? Errors { get; set; } 


        //Como alguns dos atributos podem ser nulos, é criado um construtor para cada caso
        public ApiResponse(int Estado, string message) : base(Estado)
        {
            Message = message;
        }

        public ApiResponse(int Estado, string? uri, string message) : base(Estado)
        {
            Uri = uri;
            Message = message;
        }

        public ApiResponse(int Estado, string? uri, string message, object body) : base(Estado)
        {
            Uri = uri;
            Message = message;
            Body = body;
        }

        public ApiResponse(int Estado, string? uri, string message, List<string>? errors) : base(Estado)
        {
            Uri = uri;
            Message = message;
            Errors = errors;
        }
    }
}