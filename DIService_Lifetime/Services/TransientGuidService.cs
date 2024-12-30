namespace DIService_Lifetime.Services
{
    public class TransientGuidService : ITransientGuidService
    {
        private readonly Guid Id;
        public TransientGuidService()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            throw new NotImplementedException();
            return Id.ToString();
        }
    }
}