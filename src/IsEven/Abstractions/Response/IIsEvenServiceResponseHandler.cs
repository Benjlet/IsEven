namespace IsEven.Abstractions.Response
{
    internal interface IIsEvenAlgorithmResponseHandler
    {
        public IIsEvenAlgorithmResponse GetResponse(bool isEven);
    }
}