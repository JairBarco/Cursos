package proyectocaja;

public class Caja {

    int ancho, alto, profundo, vol;
    
    public Caja(int w, int h, int d){
        this.ancho = w;
        this.alto = h;
        this.profundo = d; 
    }
    
    public int volumen()
    {
        this.vol = this.ancho * this.alto * this.profundo;
        return vol;
    }
    
}
