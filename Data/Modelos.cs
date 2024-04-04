
using System.ComponentModel.DataAnnotations;
using System;


public class Persona{

    public string Cedula {get; set;} = String.Empty; 
     public string Nombre {get; set;} = String.Empty;
     public string Apellido {get; set;} = String.Empty;
     
      public string Sexo { get; set; }= String.Empty;
      public string fechaNacimiento { get; set; }= String.Empty;
      
}


public class Aplicacion{

    public string Id  {get; set;} = String.Empty;
     public Persona Persona {get; set;} = new Persona();
    public string Correo {get; set;} = String.Empty;
      public string Direccion {get; set;} = String.Empty; 
       public string Telefono {get; set;} = String.Empty; 
       public string EstadoCivil {get; set;} = String.Empty;
       public string Profesion {get; set;} = String.Empty;
    [Required(ErrorMessage ="Por favor llenar campo")]
      public string Motivo {get; set;} = String.Empty;

      public DateTime fecha {get; set;} = DateTime.Now;
      public List<Persona> Amigos  {get; set;} = new List<Persona>();

}

   public class PersonaJce
    {
        public string Cedula { get; set; }= String.Empty; 
        public string Nombres { get; set; }= String.Empty; 
        public string Apellido1 { get; set; }= String.Empty; 
        public string Apellido2 { get; set; }= String.Empty; 
        public string FechaNacimiento { get; set; }= String.Empty; 
        public string LugarNacimiento { get; set; }= String.Empty; 
        public string IdSexo { get; set; }= String.Empty; 
        public string IdEstadoCivil { get; set; }= String.Empty; 
        public string IDEstatus { get; set; }= String.Empty; 
        public object EstatusCedulaAzul { get; set; }= String.Empty; 
        public string CedulaAnterior { get; set; }= String.Empty; 
        public bool ok { get; set; }= false; 
        public string foto { get; set; }= String.Empty; 
    }
