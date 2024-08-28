using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


/*
	Instead of requiring the user to enter the total amount
	the program will instead ask the price of single apple instead.
	The calculations shall be all handled by the program.

	It is possible to make this modular for the product but to reduce
	the scope of the program we will specify it for the apple.
*/



namespace DataTypesApp {

	class DataTypesProgram {

		// Set Variables
		
		const String queryProduct = "apple";	//Objective: declare constant passed.
		const String queryBase = "Enter ";

		static LinkedList<String> queryList = new LinkedList<String>();
		static LinkedList<String> inputStore = new LinkedList<String>();
		static LinkedList<String> outputStore = new LinkedList<String>();

		static int amountProduct;
		static double amountTotal, amountProductPrice;

		// RegEx

		//String patternINTP = "^-?\d+$"; 
		//static String patternINTP = "^\\d*\\.?\\d+$";

		static DataTypesProgram() {

			queryList.AddLast("[Pieces of " + queryProduct + "]: ");
			queryList.AddLast("[Price of the single " + queryProduct + "]: ");
			
			
		}

		static double outputTotal (int amountProduct,double amountProductPrice) {


			amountTotal = amountProduct * amountProductPrice;
			return amountTotal;
		
		}
		static void getInput(String outputQuery,int idInput) {

			String input;

			Console.Write(outputQuery);
			switch (idInput) {
				case 0:
					input = Console.ReadLine();
					amountProduct = Convert.ToInt32(input);
					break;
				case 1:
					input = Console.ReadLine();
					amountProductPrice = Convert.ToDouble(input);
					break;
				default:
					Console.WriteLine("Invalid idInput");
					break;
				}
		
		}
		static void Main() {

			int idInput = 0;

			foreach(String query in queryList) {
				getInput(queryBase + query, idInput);
				idInput++;
			}

			amountTotal = outputTotal(amountProduct, amountProductPrice);
			outputStore.AddLast("Total: " + amountTotal);
			outputStore.AddLast("Total [Rounded & Converted to INT]: " + Math.Round(amountTotal));
			var outputStoreENUM = outputStore.GetEnumerator();

			while(outputStoreENUM.MoveNext()) {
				Console.WriteLine(outputStoreENUM.Current);
			}
		
		}

	}

}
