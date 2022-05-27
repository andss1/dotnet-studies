namespace aspnet_di.Models.Interfaces
{
    public interface IPrescription
    {
        IEnumerable<Prescription> GetAll();

        Prescription Get(int id);
        void Delete(int id);
        void Update(Prescription prescription);
        void Create(Prescription prescription);
    }
}
