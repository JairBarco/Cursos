package proyectocaja;

public class PruebaCaja {
    
    public static void main(String[] args) {
        
        Caja caja = new Caja(3,2,6);
        System.out.println("ancho: "+caja.ancho);
        System.out.println("alto = " + caja.alto);
        System.out.println("largo = " + caja.profundo);
        
        var volumen = caja.volumen();
        System.out.println("volumen = " + volumen);
    }
}