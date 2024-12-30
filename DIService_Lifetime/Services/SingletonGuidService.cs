namespace DIService_Lifetime.Services
{
    public class SingletonGuidService : ISingletonGuidService
    {
        private readonly Guid Id;
        public SingletonGuidService()
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
