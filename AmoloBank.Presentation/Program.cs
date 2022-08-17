class Program
{

	//Application exec starts here
	static void Main() {
		//Display bank title
		System.Console.WriteLine("**************** Amolo Bank ****************");
		System.Console.WriteLine(":: Login Page ::");

		//declare variable s to store username and password
		string username = null;
		string password = null;

		//Read username from the keyboard
		System.Console.Write("Enter username: ");
		username = System.Console.ReadLine();

		if (username != "")
		{

			//read password
			System.Console.Write("Enter password: ");
			password = System.Console.ReadLine();
		}

		//check for username and password
		if (username == "jade" && password == "grace")
		{
			System.Console.WriteLine("TODO : Main menu goes here");
			System.Console.WriteLine("\n:::Main Menu:::");

			int mainMenuOption = -1;

			do
			{
				
			System.Console.WriteLine("1. Customers");
			System.Console.WriteLine("2. Accounts");
			System.Console.WriteLine("3. Funds Transfer");
			System.Console.WriteLine("4. Funds Transfer Statement");
			System.Console.WriteLine("5. Account Statement");
			System.Console.WriteLine("0. Exit");

			System.Console.Write("Please, Enter your choice: ");

			mainMenuOption = int.Parse(System.Console.ReadLine());


				//Check for chosen menu and process request
				switch (mainMenuOption)
				{
					case 1: //Display customers menu
						CustomersMenu();
						break;
					case 2: //Display accounts menu
						AccountsMenu();
						break;
					case 3: //Display funds transfer menu
						break;
					case 4: //Display funds transfer statement menu
						break;
					case 5: //Display account statement menu
						break;
					case 0: //Exit the bank app
						break;
				}
			} while (mainMenuOption != 0);

		}
		else {

			System.Console.WriteLine("Invalid credentials !");
		
		}



		//About to exit
		System.Console.WriteLine("Thank you for visiting Amolo Bank");
		System.Console.ReadKey();


	}

	static void CustomersMenu() {

		//Customers menu choices
		int customerMenuOptions = -1;

		
		do {

			System.Console.WriteLine("\n:::Customers Menu:::");

			System.Console.WriteLine("1. Add Customer");
			System.Console.WriteLine("2. Delete Customer");
			System.Console.WriteLine("3. Update Customer");
			System.Console.WriteLine("4. View Customers");
			System.Console.WriteLine("0. Back to Main Menu");

			System.Console.Write("Please, Enter your choice: ");

			customerMenuOptions = System.Convert.ToInt32(System.Console.ReadLine());

		} while (customerMenuOptions != 0);
	}

	static void AccountsMenu()
	{

		//Customers menu choices
		int accountsMenuOptions = -1;

		
		do
		{

			System.Console.WriteLine("\n:::Accounts Menu:::");

			System.Console.WriteLine("1. Add Account");
			System.Console.WriteLine("2. Delete Account");
			System.Console.WriteLine("3. Update Account");
			System.Console.WriteLine("4. View Accounts");
			System.Console.WriteLine("0. Back to Main Menu");

			System.Console.Write("Please, Enter your choice: ");

			accountsMenuOptions = System.Convert.ToInt32(System.Console.ReadLine());

		} while (accountsMenuOptions != 0);
	}
}
