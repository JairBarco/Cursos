package excepciones;

public class OperacionExcepcion extends RuntimeException{
    public OperacionExcepcion(String mensaje){
        super(mensaje);
        mensaje = "Error desconocido JAMB";
    }
}
