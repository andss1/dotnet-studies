using aspnet_di.Models.Interfaces;

namespace aspnet_di.Models.Data
{
    public class InMemoryRepository : IPrescription
    {
        private static List<Prescription> prescriptions = new List<Prescription>()
        {
            new Prescription() {Id = 1, Amount = 600.00m, Frequency = 3, PatientName = "Nome1"},
            new Prescription() {Id = 2, Amount = 300.00m, Frequency = 1, PatientName = "Nome2"},
            new Prescription() {Id = 3, Amount = 500.00m, Frequency = 2, PatientName = "Nome3"}
        };
        public void Create(Prescription prescription)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Prescription Get(int id)
        {
            return prescriptions[id];
        }

        public IEnumerable<Prescription> GetAll()
        {
            return prescriptions;
        }

        public void Update(Prescription prescription)
        {
            throw new NotImplementedException();
        }
    }
}
