package test;

import domain.*;

public class TestClaseObject{
    public static void main(String[] args) {
        Empleado empleado1 = new Empleado("Juan",5000);
        Empleado empleado2 = new Empleado("Juan",5000);
    
        if(empleado1 == empleado2){
            System.out.println("Tienen la misma referencia en memoria");
        }else{
            System.out.println("Tienen distinta diferencia en memoria");
        }
        
        if(empleado1.equals(empleado2)){
            System.out.println("Objetos iguales en contenido");
        }else{
            System.out.println("Distintos en contenido");
        }
        
        if(empleado1.hashCode() == empleado2.hashCode()){
            System.out.println("Hashcode es igual");
        }else{
            System.out.println("Hashcode es distinto");
        }
    }
}