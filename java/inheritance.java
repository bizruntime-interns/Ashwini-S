
class inheritance{  
    void dance(){System.out.println("dancing...");}  
    }  
    class ash extends inheritance{  
    void sing(){System.out.println("singing...");}  
    }  
    class TestInheritance{  
    public static void main(String args[]){  
    ash d=new ash();  
    d.sing();  
    d.dance();  
    }}  