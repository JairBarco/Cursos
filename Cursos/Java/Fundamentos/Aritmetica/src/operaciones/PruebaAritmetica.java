package operaciones;

public class PruebaAritmetica {
    public static void main(String[] args) {
        int a = 10;
        int b = 2;
        miMetodo();
        
        Aritmetica aritmetica1 = new Aritmetica();
        System.out.println("Aritmetica1 a:" + aritmetica1.a);
        System.out.println("Aritmetica1 b:" + aritmetica1.b);
        
        Aritmetica aritmetica2 = new Aritmetica(8,6);
        System.out.println("Aritmetica2 a:" + aritmetica2.a);
        System.out.println("Aritmetica2 b:" + aritmetica2.b);
    
        //System.gc();
    }
    
    public static void miMetodo()
    {
        //La variable está fuera del alcance
        //a = 10;
        System.out.println("Otro metodo");
    }
}
