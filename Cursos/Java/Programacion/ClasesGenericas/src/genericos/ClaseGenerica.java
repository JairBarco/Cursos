package genericos;

public class ClaseGenerica<T>{
    T objeto;
    
    public ClaseGenerica(T objeto){
        this.objeto = objeto;
    }
    
    public void obtenerTipo(){
        System.out.println("Tipo T es: " + objeto.getClass().getSimpleName());
    }
}