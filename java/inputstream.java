import java.io.*;    
public class inputstream{  
  public static void main(String[] args) throws IOException {  
    InputStream input = new FileInputStream("D:\\ash.txt");  
    var in = new DataInputStream(input);
    int count = input.available();  
    byte[] ary = new byte[count];  
    in.read(ary);  
    for (byte bt : ary) {  
      char k = (char) bt;  
      System.out.print(k+"-");  
    }  
  }  
}  