https://www.codechef.com/JUNE17/problems/GOODSET
/*
Teniendo en cuenta que impar + impar = par, escribí un conjunto de números distintos impares
*/
	/*
	 * To change this template, choose Tools | Templates
	 * and open the template in the editor.
	 */
	 
	 
	import java.io.*;
	 
	 
	/**
	 *
	 * @author Administrador
	 */
	public class Main{
	 
	    /**
	     * @param args the command line arguments
	     */
	    public static void main(String[] args) throws IOException {
	        // TODO code application logic here
	        
	       BufferedReader br = new BufferedReader(new InputStreamReader(System.in)); 
	        
	       int t = Integer.parseInt(br.readLine());
	       
	       while(t-- > 0) {
	           int n = Integer.parseInt(br.readLine());
	           
	           int cont =0;
	           for(int i =1; cont < n ; i+=2) {
	              System.out.print(i + " ");
	              cont++;
	           }
	           System.out.println();
	       }
	        
	    }
	}
