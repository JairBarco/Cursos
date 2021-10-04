package test;

import domain.Persona;

public class PersonaPrueba {
    
    public int contador;
    
    public static void main(String[] args) {
        Persona persona1 = new Persona("Juan");
        Persona persona2 = new Persona("Pablo");
        
        imprimir(persona1);
        imprimir(persona2);
    }
    
    public static void imprimir(Persona persona){
        System.out.println(persona);   
    }
    
    public int getContador()
    {
        imprimir(new Persona("Carlos"));
        return this.contador;
    }
}