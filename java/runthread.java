
class runthread extends Thread{  
    public void run(){  
      System.out.println("running...");  
    }  
    public static void main(String args[]){  
        runthread t1=new runthread();  
     t1.run();//fine, but does not start a separate call stack  
    }  
   }  