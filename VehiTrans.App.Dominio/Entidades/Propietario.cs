namespace VehiTrans.App.Dominio
{
    public class Propietario
    {
        [Key]
        public int PropietarioId { get; set; }
        public string? Ciudad { get; set; }
        public string? Correo {get;set;}
        public int PersonaId {get;set;}
        public Persona Persona {get;set;}
    }
}