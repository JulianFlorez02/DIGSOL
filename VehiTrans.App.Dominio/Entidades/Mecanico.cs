namespace VehiTrans.App.Dominio
{
    public class Mecanico
    {
        [Key]
        public int MecanicoId { get; set; }
        public string? Direccion { get; set; }
        public string? NivelEstudio {get;set;}
        public int PersonaId {get;set;}
        public Persona Persona {get;set;}
    }
}