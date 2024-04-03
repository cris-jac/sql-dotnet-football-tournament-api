namespace LaboratorioAws.Clases
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DocumentTipe { get; set; }
        public int DocumentNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
