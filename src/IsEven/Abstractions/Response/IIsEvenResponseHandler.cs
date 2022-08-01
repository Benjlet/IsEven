namespace IsEven.Abstractions.Response
{
    public interface IIsEvenResponseHandler
    {
        public bool GetResult(IIsEvenAlgorithmResponse response);
    }
}