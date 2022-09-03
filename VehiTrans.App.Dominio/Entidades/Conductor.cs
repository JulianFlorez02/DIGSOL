namespace VehiTrans.App.Dominio
{
    public class Conductor
    {
        [Key]
        public int ConductorId { get; set; }
        public string? Licencia { get; set; }
        public string? Direccion { get; set; }
        public string? NivelEstudio {get;set;}
        public int PersonaId {get;set;}
        public Persona Persona {get;set;}
    }
}