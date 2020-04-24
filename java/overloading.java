class overloading{  
    static int add(int a,int b){return a+b;}  
    static int add(int a,int b,int c){return a+b+c;}  
    }  
    class TestOverloading1{  
    public static void main(String[] args){  
    System.out.println(overloading.add(1,2));  
    System.out.println(overloading.add(12,13,14));  
    }}  