
import java.io.FileInputStream;  
public class in {  
     public static void main(String args[]){    
          try{    
            FileInputStream fin=new FileInputStream("c:\\ash.txt");    
            int i=fin.read();  
            System.out.print((char)i);    
  
            fin.close();    
          }catch(Exception e){System.out.println(e);}    
         }    
        }  