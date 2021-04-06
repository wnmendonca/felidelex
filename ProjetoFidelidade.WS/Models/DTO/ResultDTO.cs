namespace ProjetoFidelidade.WS.Models.DTO
{
    public class ResultDTO<T>
    {
        public T Result;
        public int StatusCode;
        public string Message;
    }
}