//namespace LaboratorioAws.Entities         -> Antiguo namespace
namespace Model.Entities                 // -> Nuevo namespace
{
    public class Person
    {
        // public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DocumentType { get; set; }
        public int DocumentNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
