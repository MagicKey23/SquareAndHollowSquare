using System;
					
public class Program
{
	public static void Main()
	{
	
		bool repeat = false;
		do{
			repeat = false;
		
	Console.WriteLine("Pick 1 or 2:\n1.Normal Square\n2.Hollow Square");
	String userInput = Console.ReadLine();
	
		
		
		if (userInput.Equals("1")){
			Console.WriteLine("How many row?");
			String input = Console.ReadLine();
			int row;
			Int32.TryParse(input, out row);
			
			normalSquare(row);
		}
					
				
		if (userInput.Equals("2")){
			Console.WriteLine("How many row?");
			String input = Console.ReadLine();
			int row;
			Int32.TryParse(input, out row);
			
			hollowSquare(row);
			}
					Console.WriteLine("Do it again?");
		String repeatText = Console.ReadLine();
			if (repeatText.Equals("Yes")|| repeatText.Equals("y") || repeatText.Equals("Y")){
				repeat = true;
				
			}
			else {repeat = false;}
		}
		

		
		while(repeat);
			
	}		
		public static void normalSquare(int row){
			
			for (int i = 1; i <= row;i++){
				for(int j = 1; j <=row;j++){
					Console.Write("*");
					
				}
				Console.WriteLine();
				
			}
			
			
		}
	
	public static void hollowSquare(int row){
		
		for(int i = 1; i <= row ; i++){
			for (int j = 1; j <= row; j++){
				if(i == 1 || i == row+1-1){
					
				Console.Write("*");
					
				}
				
				else if(j == 1 || j == row+1-1){
				Console.Write("*");	
					
				}
				else{Console.Write(" ");}
				
				
			}
			Console.WriteLine();
		}
	
		
	}
		
		
	}
	
