namespace LaboratorioAws.DTO
{
    public class PlayerDto
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public int DocumentNumber { get; set; }
        public string DateOfBirthYyyyMmDd { get; set; } = "YYYY-MM-DD";
        public int ClubId { get; set; }
        public int Number { get; set; }
        public string Position { get; set; } = string.Empty;
        public bool Starter { get; set; }
    }
}