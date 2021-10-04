package test;

import aritmetica.Aritmetica;
import excepciones.OperacionExcepcion;

public class TestExcepciones {

    public static void main(String[] args) {
        int resultado = 0;
        
        try {
            resultado = Aritmetica.division(10, 0);
        } catch (OperacionExcepcion e){
            System.out.println("Error OperacionException");
            System.out.println(e.getMessage());
        }catch (Exception e) {
            System.out.println("Error Exception");
            System.out.println(e.getMessage());
        } finally {
            System.out.println("Se revisó la división entre 0");
        }
        
        System.out.println("resultado = " + resultado);
    }
}