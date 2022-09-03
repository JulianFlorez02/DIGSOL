namespace VehiTrans.App.Dominio
{
    public class Auxiliar
    {
        [Key]
        public int AuxiliarId { get; set; }
        public string? Direccion { get; set; }
        public int PersonaId {get;set;}
        public Persona Persona {get;set;}
    }
}