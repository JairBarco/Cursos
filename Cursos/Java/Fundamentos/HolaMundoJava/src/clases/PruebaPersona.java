package clases;

public class PruebaPersona {
    public static void main(String[] args)
    {
        Persona persona1 = new Persona();
        persona1.nombre = "Jair";
        persona1.apellido = "Barco";
        persona1.desplegarInformacion();
        
        Persona persona2 = new Persona();
        persona2.nombre= "Juan";
        persona2.apellido="Perez";
        persona2.desplegarInformacion();
    }
}