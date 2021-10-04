package pasoporreferencia;

import clases.Persona;


public class PasoPorReferencia {
    public static void main(String[] args) {
        Persona persona1 = new Persona();
        
        persona1.nombre = "Jair";
        persona1.apellido = "Barco";
        
        System.out.println("persona1 = " + persona1.nombre);
        System.out.println("Apellido = " + persona1.apellido);
        
        persona1 = cambiarValor(persona1);
        
        System.out.println("persona1 = " + persona1.nombre);
    }
    
    public static Persona cambiarValor(Persona persona)
    {
        if(persona == null){
            System.out.println("Valor invalido : null");
            return persona;
        }
        persona.nombre = "Pedro";
        
        return persona;
    }
}