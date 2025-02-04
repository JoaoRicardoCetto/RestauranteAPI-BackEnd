namespace RestauranteAPI.Application.DTOs.Common
{
    //Classe base para padronizar as respostas da API
    public class ResponseBase
    {
        public int StatusCode { get; set; }  // Código de status da resposta, representando o resultado da requisição.

        public ResponseBase() { }
        
        // Construtor que inicializa a resposta com um código de status.
        public ResponseBase(int Estado)
        {
            StatusCode = Estado;
        }
    }
}