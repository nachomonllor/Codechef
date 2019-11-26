https://www.codechef.com/problems/KOL16J
	/*
	 * To change this template, choose Tools | Templates
	 * and open the template in the editor.
	 */
	 
	import java.io.BufferedReader;
	import java.io.IOException;
	import java.io.InputStreamReader;
	import java.util.Arrays;
	 
	/**
	 *
	 * @author Administrador
	 */
	public class Main {
	 
	    /**
	     * @param args the command line arguments
	     */
	    public static void main(String[] args) throws IOException {
	        // TODO code application logic here
	         BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
	         
	        int t = Integer.parseInt(br.readLine());
	 
	        while (t-- > 0)
	        {
	            int i;
	            int n = Integer.parseInt(br.readLine());
	            //int[] c = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
	            String[] input = br.readLine().trim().split(" ");
	            int[] c = new int[n];
	            
	            int max =0;
	            for(i=0; i<n; i++){
	                c[i] = Integer.parseInt(input[i]);
	                if(c[i] > max) {
	                    max = c[i];
	                }
	            }
	 
	            //-------------
	 
	            
	           // int n = c.length;
	            //int i;
	 
	            for (i = 0; i < n; i++)
	            {
	                if (c[i] != i + 1)
	                {
	                    break;
	                }
	            }
	            if (i < n)
	            {
	                //Console.WriteLine("no");
	                // int[] copia = c.ToArray();
	                int[] copia = c.clone();
	                Arrays.sort(copia);
	 
	                for (i = 0; i < n; i++)
	                {
	                    if (copia[i] != i + 1)
	                    {
	                        break;
	                    }
	                }
	                if (i < n)
	                {
	                    System.out.println("no");
	                }
	                else
	                {
	                    System.out.println("yes");
	                }
	 
	            }
	            else
	            {
	 
	                int[] cont = new int[max + 1];
	                for (i = 0; i < n; i++)
	                {
	                    cont[c[i]]++;
	                }
	 
	                for (i = 0; i < cont.length; i++)
	                {
	                    if (cont[i] != 1)
	                    {
	                        System.out.println("no");
	                        break;
	                    }
	                }
	 
	                if (i >= n)
	                {
	                    System.out.println("yes");
	                }
	 
	            }
	            
	            
	            
	        }
	        
	        
	    }
	}
