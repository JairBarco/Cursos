package mx.com.gm.mundopc;

public class raton extends DispositivoEntrada {
    private final int idRaton;
    private static int contadorRatones;
    
    public raton(String tipoEntrada, String marca){
        super(tipoEntrada, marca);
        this.idRaton = ++raton.contadorRatones;
    }

    @Override
    public String toString() {
        return "raton{" + "idRaton=" + idRaton+ "," + super.toString() + '}';
    }
}
