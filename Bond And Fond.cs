https://www.codechef.com/LOCMAY17/problems/BONDFOND

	/*
	 * To change this template, choose Tools | Templates
	 * and open the template in the editor.
	 */
	//package javaapplication216;
	 
	/**
	 *
	 * @author Administrador
	 */
	import java.io.*;
	import java.math.BigInteger;
	import java.util.ArrayList;
	 
	public class Main{
	 
	    /**
	     * @param args the command line arguments
	     */
	    public static void main(String[] args) throws IOException {
	        // TODO code application logic here
	        
	        BufferedReader br = new java.io.BufferedReader (new java.io.InputStreamReader (System.in));
	        
	       
	        
	        /*
	         BigInteger a = BigInteger.valueOf( 1);
	         BigInteger b = BigInteger.valueOf(5);
	         */
	         //System.out.println(a.compareTo(b ) < 0); //true
	        
	          int t = Integer.parseInt(br.readLine());
	        //System.out.println(t);
	         
	        while(t-- > 0) {
	            
	                BigInteger n = new BigInteger(br.readLine());
	 
	                BigInteger l = new BigInteger("10000000000000000000");
	 
	                ArrayList<BigInteger> powers = new ArrayList<BigInteger>();
	                BigInteger power = BigInteger.valueOf(1);
	                powers.add(power);
	                
	                
	                
	                for (int i = 0; power.compareTo( l) < 0; i++)
	                {
	                    power = power.multiply(BigInteger.valueOf( 2));
	                    powers.add(power);
	                    // Console.WriteLine(power);
	                }
	                
	 
	                BigInteger ans = BigInteger.valueOf( 0);
	                for (int i = 0; i+1  < powers.size(); i++)
	                {
	                    if (n.compareTo(powers.get(i)) >= 0 && n.compareTo( powers.get(i+1)) <= 0)
	                    {
	                       //ans =  BigInteger.min(n - powers[i], powers[i+1] - n);
	                        ans = (n.subtract(powers.get(i))).min( powers.get(i+1).subtract(n));
	                        break;
	                    }
	                }
	                
	                
	                System.out.println(ans);
	                
	        }
	        
	 
	    }
	}
