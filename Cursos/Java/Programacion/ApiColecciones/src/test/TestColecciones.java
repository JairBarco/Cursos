package test;

import java.util.*;

public class TestColecciones {

    public static void main(String[] args) {
        List miLista = new ArrayList();
        miLista.add("Hola");
        miLista.add("Adiós");
        miLista.add("Wenas Tardes");
        
        Set miSet = new HashSet();
        miSet.add("Hola");
        miSet.add("Adios");
        miSet.add("Wenas Tardes");
        
        imprimir(miSet);
        System.out.println("-------------------------------");
        imprimir(miLista);
        System.out.println("-------------------------------");        
        
        Map miMapa = new HashMap();
        miMapa.put("1", " Jair");
        miMapa.put("2", " Alejandro");
        miMapa.put("3", " Martinez");
        miMapa.put("4", " Barco");
        
        String elemento = miMapa.toString();
        System.out.println(miMapa);
        
        String elemento1 = (String) miMapa.get("1");
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