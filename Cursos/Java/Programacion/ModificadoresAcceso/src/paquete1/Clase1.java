package paquete1;

class Clase1{
    String atributoDefault = "Valor atributo Default";
    private String atributoPrivate = "Valor atributo Private";
    public String atributoPublico = "Valor atributo publico";
    protected String atributoProtected = "Valor atributo protected";
    
    private Clase1(){
        System.out.println("Constructor Privado");
    }
    
    public Clase1(String argumento){
        this();
        System.out.println("Constructor publico");
    }
    
    private void metodoPrivado(){
        System.out.println("Metodo Privado");
    }
}