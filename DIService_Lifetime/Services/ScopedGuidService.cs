namespace DIService_Lifetime.Services
{
    public class ScopedGuidService : IScopedGuidService
    {
        private readonly Guid Id;
        public ScopedGuidService()
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