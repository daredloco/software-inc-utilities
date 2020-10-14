using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SincUtilities
{
	namespace Gameplay
	{
		#region Money
		public static class Money
		{
			/// <summary>
			/// Change money from the NA category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void NA(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.NA);
			}

			/// <summary>
			/// Change money from the Bills category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Bills(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Bills);
			}

			/// <summary>
			/// Change money from the Deals category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Deals(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Deals);
			}

			/// <summary>
			/// Change money from the Benefits category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Benefits(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Benefits);
			}

			/// <summary>
			/// Change money from the Construction category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Construction(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Construction);
			}

			/// <summary>
			/// Change money from the Contracts category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Contracts(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Contracts);
			}

			/// <summary>
			/// Change money from the Distribution category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Distribution(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Distribution);
			}

			/// <summary>
			/// Change money from the Dividends category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Dividends(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Dividends);
			}

			/// <summary>
			/// Change money from the Education category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Education(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Education);
			}

			/// <summary>
			/// Change money from the Hire category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Hire(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Hire);
			}

			/// <summary>
			/// Change money from the Intercompany category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Intercompany(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Intercompany);
			}

			/// <summary>
			/// Change money from the Interest category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Interest(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Interest);
			}

			/// <summary>
			/// Change money from the Legal category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Legal(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Legal);
			}

			/// <summary>
			/// Change money from the Licenses category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Licenses(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Licenses);
			}

			/// <summary>
			/// Change money from the Loan category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Loan(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Loan);
			}

			/// <summary>
			/// Change money from the Marketing category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Marketing(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Marketing);
			}

			/// <summary>
			/// Change money from the Repairs category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Repairs(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Repairs);
			}

			/// <summary>
			/// Change money from the Royalties category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Royalties(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Royalties);
			}

			/// <summary>
			/// Change money from the Salaries category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Salaries(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Salaries);
			}

			/// <summary>
			/// Change money from the Sales category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Sales(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Sales);
			}

			/// <summary>
			/// Change money from the Staff category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Staff(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Staff);
			}

			/// <summary>
			/// Change money from the Stocks category
			/// </summary>
			/// <param name="amount">The amount of money</param>
			public static void Stocks(float amount)
			{
				GameSettings.Instance.MyCompany.MakeTransaction(amount, Company.TransactionCategory.Stocks);
			}
		}



		#endregion

		#region Sales
		public static class Sales
		{

			/// <summary>
			/// Changes the offline sales
			/// </summary>
			/// <param name="product">The product which sales should be changed</param>
			/// <param name="amount">The amount of sales</param>
			public static void Offline(SoftwareProduct product, int amount)
			{
				float price = product.Price;
				product.AddToCashflow(0, amount, 0, amount * price, 0, TimeOfDay.Instance.GetDate());
			}

			/// <summary>
			/// Changes the online sales
			/// </summary>
			/// <param name="product">The product which sales should be changed</param>
			/// <param name="amount">The amount of sales</param>
			public static void Online(SoftwareProduct product, int amount)
			{
				float price = product.Price;
				product.AddToCashflow(amount, 0, 0, amount * price, 0, TimeOfDay.Instance.GetDate());
			}

			/// <summary>
			/// Changes the refunds
			/// </summary>
			/// <param name="product">The product which refunds should be changed</param>
			/// <param name="amount">The amount of sales</param>
			public static void Refunds(SoftwareProduct product, int amount)
			{
				int effectVal = amount;
				int totalsales = 0;
				for (int i = 0; i < product.GetUnitSales(false).Count; i++)
				{
					totalsales += product.GetUnitSales(false)[i];
				}
				if (totalsales < effectVal)
				{
					effectVal = totalsales;
				}
				float refundcost = product.Price * effectVal;
				product.AddToCashflow(0, 0, effectVal, -refundcost, 0, TimeOfDay.Instance.GetDate());
			}
		}
		#endregion

		#region Fans
		public static class Fans
		{
			static List<SoftwareType> SoftwareTypes = new List<SoftwareType>();

			static void SetTypes()
			{
				if (SoftwareTypes.Count > 0)
					return;

				foreach (KeyValuePair<string, SoftwareType> kvp in MarketSimulation.Active.SoftwareTypes)
					SoftwareTypes.Add(kvp.Value);
			}

			/// <summary>
			/// Changes the amount of fans from the category of a SoftwareProduct
			/// </summary>
			/// <param name="product">The softwareproduct</param>
			/// <param name="amount">The amount of fans</param>
			public static void Product(SoftwareProduct product, int amount)
			{
				GameSettings.Instance.MyCompany.AddFans(amount, product.Category);
			}

			/// <summary>
			/// Changes the amount of fans from the category
			/// </summary>
			/// <param name="category">The SoftwareCategory</param>
			/// <param name="amount">The amount of fans</param>
			public static void Category(SoftwareCategory category, int amount)
			{
				GameSettings.Instance.MyCompany.AddFans(amount, category);
			}

			/// <summary>
			/// Changes the amount of fans for the Computer OS category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void ComputerOS(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Operating System");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Computer"]);
			}

			/// <summary>
			/// Changes the amount of fans for the Console OS category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void ConsoleOS(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Operating System");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Console"]);
			}

			/// <summary>
			/// Changes the amount of fans for the Phone OS category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void PhoneOS(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Operating System");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Phone"]);
			}

			/// <summary>
			/// Changes the amount of fans for the Office Software category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void Office(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Office Software");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Default"]);
			}

			/// <summary>
			/// Changes the amount of fans for the 2D Editor category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void Editor2D(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "2D Editor");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Default"]);
			}

			/// <summary>
			/// Changes the amount of fans for the 3D Editor category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void Editor3D(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "3D Editor");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Default"]);
			}

			/// <summary>
			/// Changes the amount of fans for the Audio Tool category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void AudioTool(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Audio Tool");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Default"]);
			}

			/// <summary>
			/// Changes the amount of fans for the Antivirus category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void Antivirus(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Antivirus");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Default"]);
			}

			/// <summary>
			/// Changes the amount of fans for the RPG Game category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void GameRPG(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Game");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["RPG"]);
			}

			/// <summary>
			/// Changes the amount of fans for the Adventure Game category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void GameAdventure(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Game");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Adventure"]);

			}

			/// <summary>
			/// Changes the amount of fans for the Simulation Game category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void GameSimulation(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Game");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Simulation"]);
			}

			/// <summary>
			/// Changes the amount of fans for the Sports Game category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void GameSports(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Game");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["Sports"]);
			}

			/// <summary>
			/// Changes the amount of fans for the RTS Game category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void GameRTS(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Game");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["RTS"]);
			}

			/// <summary>
			/// Changes the amount of fans for the FPS Game category
			/// </summary>
			/// <param name="amount">The amount of fans</param>
			public static void GameFPS(int amount)
			{
				SetTypes();
				SoftwareType type = SoftwareTypes.Find(x => x.Name == "Game");
				GameSettings.Instance.MyCompany.AddFans(amount, type.Categories["FPS"]);
			}
		}
		#endregion

		#region Popularity
		public static class Popularity
		{
			/// <summary>
			/// Changes the popularity of a SoftwareProducts SoftwareCategory
			/// </summary>
			/// <param name="product">The SoftwareProduct</param>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void Product(SoftwareProduct product, int amount)
			{
				product.Category.Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of a SoftwareCategory
			/// </summary>
			/// <param name="category">The SoftwareCategory</param>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void Category(SoftwareCategory category, int amount)
			{
				category.Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of Computer OS
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void ComputerOS(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Operating System"].Categories["Computer"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of Console OS
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void ConsoleOS(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Operating System"].Categories["Computer"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of Phone OS
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void PhoneOS(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Operating System"].Categories["Computer"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of Office Software
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void Office(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Office Software"].Categories["Default"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of 2D Editor
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void Editor2D(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["2D Editor"].Categories["Default"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of 3D Editor
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void Editor3D(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["3D Editor"].Categories["Default"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of Audio Tool
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void AudioTool(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Audio Tool"].Categories["Default"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of Antivirus
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void Antivirus(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Antivirus"].Categories["Default"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of RPG Game
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void GameRPG(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Game"].Categories["RPG"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of Adventure Game
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void GameAdventure(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Game"].Categories["Adventure"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of Simulation Game
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void GameSimulation(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Game"].Categories["Simulation"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of Sports Game
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void GameSports(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Game"].Categories["Sports"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of RTS Game
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void GameRTS(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Game"].Categories["RTS"].Popularity += amount;
			}

			/// <summary>
			/// Changes the popularity of FPS Game
			/// </summary>
			/// <param name="amount">The amount of popularity that should be changed</param>
			public static void GameFPS(int amount)
			{
				MarketSimulation.Active.SoftwareTypes["Game"].Categories["FPS"].Popularity += amount;
			}
		}
		#endregion

		#region Employee Experience
		public static class Experience
		{
			/// <summary>
			/// Adds leadership experience to an Actor
			/// </summary>
			/// <param name="actor">The actor</param>
			/// <param name="experience">The experience amount</param>
			public static void Leadership(Actor actor, float experience)
			{
				actor.employee.SetSpecExperience(Employee.EmployeeRole.Lead, experience);
			}

			/// <summary>
			/// Adds leadership experience to an Employee
			/// </summary>
			/// <param name="employee">The employee</param>
			/// <param name="experience">The experience amount</param>
			public static void Leadership(Employee employee, float experience)
			{
				employee.SetSpecExperience(Employee.EmployeeRole.Lead, experience);
			}

			/// <summary>
			/// Adds design experience to an Actor
			/// </summary>
			/// <param name="actor">The actor</param>
			/// <param name="experience">The experience amount</param>
			public static void Design(Actor actor, float experience)
			{
				actor.employee.SetSpecExperience(Employee.EmployeeRole.Designer, experience);
			}

			/// <summary>
			/// Adds design experience to an Employee
			/// </summary>
			/// <param name="employee">The enployee</param>
			/// <param name="experience">The experience amount</param>
			public static void Design(Employee employee, float experience)
			{
				employee.SetSpecExperience(Employee.EmployeeRole.Designer, experience);
			}

			/// <summary>
			/// Adds programming experience to an Actor
			/// </summary>
			/// <param name="actor">The actor</param>
			/// <param name="experience">The experience amount</param>
			public static void Programming(Actor actor, float experience)
			{
				actor.employee.SetSpecExperience(Employee.EmployeeRole.Programmer, experience);
			}

			/// <summary>
			/// Adds programming experience to an Employee
			/// </summary>
			/// <param name="employee">The employee</param>
			/// <param name="experience">The experience amount</param>
			public static void Programming(Employee employee, float experience)
			{
				employee.SetSpecExperience(Employee.EmployeeRole.Programmer, experience);
			}

			/// <summary>
			/// Adds art experience to an Actor
			/// </summary>
			/// <param name="actor">The actor</param>
			/// <param name="experience">The experience amount</param>
			public static void Art(Actor actor, float experience)
			{
				actor.employee.SetSpecExperience(Employee.EmployeeRole.Artist, experience);
			}

			/// <summary>
			/// Adds art experience to an Employee
			/// </summary>
			/// <param name="employee">The employee</param>
			/// <param name="experience">The experience amount</param>
			public static void Art(Employee employee, float experience)
			{
				employee.SetSpecExperience(Employee.EmployeeRole.Artist, experience);
			}

			/// <summary>
			/// Adds service experience to an Actor
			/// </summary>
			/// <param name="actor">The actor</param>
			/// <param name="experience">The experience amount</param>
			public static void Service(Actor actor, float experience)
			{
				actor.employee.SetSpecExperience(Employee.EmployeeRole.Service, experience);
			}

			/// <summary>
			/// Adds service experience to an Employee
			/// </summary>
			/// <param name="employee">The employee</param>
			/// <param name="experience">The experience amount</param>
			public static void Service(Employee employee, float experience)
			{
				employee.SetSpecExperience(Employee.EmployeeRole.Service, experience);
			}
		}
		#endregion

		#region Business Reputation
		public static class BusinessRep
		{
			/// <summary>
			/// Changes the Business Reputation
			/// </summary>
			/// <param name="title">The title that should be shown in the UI</param>
			/// <param name="amount">The amount of percent stars as float</param>
			public static void Change(string title, float amount)
			{
				GameSettings.Instance.MyCompany.ChangeBusinessRep(amount, title);
			}
		}
		#endregion

		#region StockMarkets
		public static class StockMarkets
		{
			/// <summary>
			/// Changes every Stock inside the Stockmarket
			/// </summary>
			/// <param name="amount">The amount of change</param>
			public static void Change(float amount)
			{
				foreach (StockMarket market in GameSettings.Instance.StockMarkets)
				{
					market.Value += amount;
				}
			}

			/// <summary>
			/// Changes a single Stock inside the Stockmarket
			/// </summary>
			/// <param name="stockMarket">The StockMarket to change</param>
			/// <param name="amount">The amount of change</param>
			public static void SingleChange(StockMarket stockMarket, float amount)
			{
				stockMarket.Value += amount;
			}
		}
		#endregion

		#region Employee Details
		public static class EmployeeDetails
		{
			/// <summary>
			/// Changes the stress of an actor
			/// </summary>
			/// <param name="actor">The Actor</param>
			/// <param name="amount">The amount of change</param>
			public static void Stress(Actor actor, float amount)
			{
				actor.employee.Stress += amount;
			}

			/// <summary>
			/// Changes the stress of an employee
			/// </summary>
			/// <param name="employee">The Employee</param>
			/// <param name="amount">The amount of change</param>
			public static void Stress(Employee employee, float amount)
			{
				employee.Stress += amount;
			}

			/// <summary>
			/// Changes the satisfaction of an actor
			/// </summary>
			/// <param name="actor">The Actor</param>
			/// <param name="amount">The amount of change</param>
			public static void Satisfaction(Actor actor, float amount)
			{
				actor.employee.JobSatisfaction += amount;
			}

			/// <summary>
			/// Changes the satisfaction of an employee
			/// </summary>
			/// <param name="employee">The Employee</param>
			/// <param name="amount">The amount of change</param>
			public static void Satisfaction(Employee employee, float amount)
			{
				employee.JobSatisfaction += amount;
			}

			/// <summary>
			/// Sends an Actor home
			/// </summary>
			/// <param name="actor">The Actor</param>
			public static void SendHome(Actor actor)
			{
				actor.GoHomeNow = true;
			}

			/// <summary>
			/// Sends an Employee home
			/// </summary>
			/// <param name="employee">The Employee</param>
			public static void SendHome(Employee employee)
			{
				employee.MyActor.GoHomeNow = true;
			}
		}
		#endregion

		#region Software Details
		public static class SoftwareDetails
		{
			/// <summary>
			/// Changes the amount of bugs from a SoftwareProduct
			/// </summary>
			/// <param name="product">The SoftwareProduct</param>
			/// <param name="amount">The amount of change</param>
			public static void Bugs(SoftwareProduct product, int amount)
			{
				product.Bugs += amount;
			}
		}
		#endregion
	}


}
