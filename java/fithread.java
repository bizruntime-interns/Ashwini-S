public class fithread extends Thread{  
    public void run(){  
      System.out.println("running...");  
    }  
    public static void main(String args[]){  
     fithread t1=new fithread();  
     t1.start();  
     t1.start();  
    }  
   }  