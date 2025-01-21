namespace RestauranteAPI.Domain.Validation
{
    /*A exce��o de dom�nio que ser� lan�ada caso ocorra algum erro no Dom�nio,
    cada camada ter� sua valida��o*/
    public class DomainValidationException : Exception
    {
        public List<string> Errors { get; }

        public DomainValidationException(List<string> validationsErrors)
        {
            Errors = validationsErrors;
        }

        //Facilita a visualiza��o da exce��o
        public override string ToString()
        {
            return string.Join(Environment.NewLine, Errors);
        }
    }
}
