namespace VehiTrans.App.Dominio
{
    public class JefeOperaciones
    {
        [Key]
        public int JefeOpeId { get; set; }
        public string? Correo {get;set;}
        public int PersonaId {get;set;}
        public Persona Persona {get;set;}
    }
}