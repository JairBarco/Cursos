package test;

import java.util.*;

public class TestColeccionesGenericas {

    public static void main(String[] args) {
        List<String> miLista = new ArrayList<>();
        miLista.add("Hola");
        miLista.add("Adiós");
        miLista.add("Wenas Tardes");
        String elementoG = miLista.get(0);
        System.out.println("elemento = " + elementoG);
        
        Set<String> miSet = new HashSet();
        miSet.add("Hola");
        miSet.add("Adios");
        miSet.add("Wenas Tardes");
        
        imprimir(miSet);
        System.out.println("-------------------------------");
        imprimir(miLista);
        System.out.println("-------------------------------");        
        
        Map<String, String> miMapa = new HashMap();
        miMapa.put("1", " Jair");
        miMapa.put("2", " Alejandro");
        miMapa.put("3", " Martinez");
        miMapa.put("4", " Barco");
        
        String elemento = miMapa.toString();
        System.out.println(miMapa);
        
        String elemento1 = miMapa.get("1");
        System.out.println("Valor: " + elemento1);
        miMapa.keySet();
        imprimir(miMapa.keySet());
        imprimir(miMapa.values());
    }
    
    public static void imprimir(Collection coleccion){
        coleccion.forEach(elemento ->{
            System.out.println("elemento: " + elemento);
        });
    }
}