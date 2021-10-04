package aritmetica;

import excepciones.OperacionExcepcion;

public class Aritmetica {
    public static int division(Integer numerador, Integer denominador){
        if(denominador.equals(0)){
            throw new OperacionExcepcion("División entre 0");
        } else {
            return numerador / denominador;
        }
    }
}
