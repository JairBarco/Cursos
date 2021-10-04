package test;

import genericos.*;

public class TestGenerics {
    public static void main(String[] args) {
        ClaseGenerica<Integer> objetoInt = new ClaseGenerica(15);
        objetoInt.obtenerTipo();
        
        ClaseGenerica<Double> objetoDouble = new ClaseGenerica(20.50);
        objetoDouble.obtenerTipo();
    }
}