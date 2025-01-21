namespace RestauranteAPI.Domain.Validation
{
    /*A exceção de domínio que será lançada caso ocorra algum erro no Domínio,
    cada camada terá sua validação*/
    public class DomainValidationException : Exception
    {
        public List<string> Errors { get; }

        public DomainValidationException(List<string> validationsErrors)
        {
            Errors = validationsErrors;
        }

        //Facilita a visualização da exceção
        public override string ToString()
        {
            return string.Join(Environment.NewLine, Errors);
        }
    }
}
