package palabrathis;

public class PalabraThis {
    public static void main(String[] args) {
        Persona persona = new Persona("Jair", "Barco");
        System.out.println("persona = " + persona);
        System.out.println("nombre: "+ persona.nombre);
        System.out.println("apellido: "+persona.apellido);
    }
}

class Persona
{
    String nombre;
    String apellido;
    
    Persona(String nombre, String apellido)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        System.out.println("nombre completo = " + this.nombre + " " + this.apellido);
        new Imprimir().imprimir(this);
    }
}

class Imprimir{
   public void imprimir(Persona persona ){
       System.out.println("Persona desde imprimir: " + persona);
       System.out.println("Persona del objeto actual: " + this);
   }
}