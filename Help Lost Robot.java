https://www.codechef.com/problems/ICPC16A

	import java.io.BufferedReader;
	import java.io.IOException;
	import java.io.InputStreamReader;
	import java.util.Scanner;
	 
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
	 
	        while (t-- > 0)
	        {
	            String[] input = br.readLine().trim().split(" ");
	            int x1 = Integer.parseInt(input[0]);
	            int y1 = Integer.parseInt(input[1]);
	            int x2 = Integer.parseInt(input[2]);
	            int y2 = Integer.parseInt(input[3]);
	 
	            if (x1 != x2 && y1 != y2)
	            {
	                System.out.println("sad");
	            }
	            else if (y1 == y2 && x1 != x2)
	            {
	                if (x2 > x1)
	                {
	                    System.out.println("right");
	                }
	                else if (x1 > x2)
	                {
	                   System.out.println("left");
	                }
	 
	            }
	            else if (x1 == x2 && y1 != y2)
	            {
	                if (y2 > y1)
	                {
	                    System.out.println("up");
	                }
	                else if (y1 > y2)
	                {
	                    System.out.println("down");
	                }
	            }
	        }
	 
	        
	    }
	}
