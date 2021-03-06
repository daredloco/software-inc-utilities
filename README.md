# Software Inc Utilities
Those Utilities are a collection of scripts you can use to create Code Mods for [Software Inc](https://store.steampowered.com/app/362620/Software_Inc/) faster.

## Usage
To use the utilities, simply load the C# classes inside your project.

## Content
* [SincUtilities.UI](#ui)
* [SincUtilities.Utils](#utils)
* [SincUtilities.Serializer](#serializer)
* [SincUtilities.Debug](#debug)
* [SincUtilities.Gameplay](#gameplay)

### UI
The SincUtilities.UI class has a Window and Element namespace in it. The Window controls can be used with Windows and the Element controls can be used with Elements.

- UILabel: Creates a label
```cs
UILabel(string text, Rect pos, GUIWindow parent, string name = "", bool isBold = false, uint fontsize = 0);
```
- UIButton: Creates a button
```cs
UIButton(string text, Rect pos, UnityAction action, GUIWindow parent, string name = "", string tooltiptitle = "", string tooltipdesc = "");
```
- UISlider: Creates a slider
```cs
UISlider(int min, int max, int value, Rect pos, GUIWindow parent, UnityAction<float> action = null, string name = "", string tooltiptitle = "", string tooltipdesc = "");
```
- UICombobox: Creates a combobox
```cs
UICombobox(string[] items, Rect pos, GUIWindow parent, UnityAction action = null, int selected = 0);
```
- UICheckbox: Creates a checkbox
```cs
UICheckbox(string label, Rect pos, GUIWindow parent, UnityAction<bool> action = null, bool state = false, string tooltiptitle = "", string tooltipdesc = "");
```
- UITextbox: Creates a textbox
```cs
UITextbox(Rect pos, GUIWindow parent, string placeholder = "", string name = "", UnityAction<string> endeditaction = null, int fontsize = 15);
```
- UITooltip: Creates a tooltip
```cs
UITooltip(string title, string description, GameObject go);
```

### Utils
The SincUtilities.Utils class contains a variety of functions that won't fit in any other class.

- RemoveDateTime: Removes x months from a SDateTime
```cs
RemoveDateTime(SDateTime old, int months);
```
- ShuffleList: Shuffles content from a list of objects
```cs
ShuffleList<T>(this IList<T> list);
```
- UpperFirstLetters: Sets every first letter of every word to uppercase
```cs
UpperFirstLetters(string str);
```
- GetPercentage: Adds/Subtracts a percentage from a value
```cs
GetPercentage(float value, float percentage, bool subtract = true);
```
- ReplaceValues: Replaces values from a string
```cs
ReplaceValues(string str, string[] values, string[] replacements);
ReplaceValues(string str, string values, string replacements);
ReplaceValues(string str, params KeyValuePair<string,string>[] pairs);
```

### Serializer
The SincUtilities.Serializer class contains a Serialize() and Deserialize<T>() function to handle serialization.
 
 - Serialize: Serializes classes/objects that are marked as [Serializable]
 ```cs
 [Serializable]
 public class SClass
 {
   public int Id;
   public string Name;
 }
 
 byte[] serialized = Serialize(new SClass(){Id = 1, Name = "Test"});
 ```
 - Deserialize: Deserializes a bytearray to a class/object marked as [Serializable]
 ```cs
 SClass deserialized = Deserialize<SClass>(serialized);
 ```

### Debug
The SincUtilities.Debug class contains debugging/logging functions to easily log anything inside your mod

- ModName: Change the modname to save it inside the software inc datafolder
- Info: Logs a informational message
- Warn: Logs a warning
- Error: Logs an error
- Exception: Logs an exception

### Gameplay
The SincUtilities.Gameplay class contains functions to easily handle gameplay elements

- Money.* : Adds/Removes money to the category (Money.Bills would add/remove money from the Bills category)
- Sales.Offline: Adds/Removes offline sales from a SoftwareProduct
- Sales.Online: Adds/Remmoves online sales from a SoftwareProduct
- Sales.Refunds: Adds/Removes refunds from a SoftwareProduct
- Fans.Product: Adds/Removes fans from the category of a SoftwareProduct
- Fans.Category: Adds/Removes fans from a SoftwareCategory
- Fans.* : Adds/Removes fans from the category (Fans.ComputerOS would add/remove fans from the Computer OS category)
- Popularity.Product: Adds/Removes popularity to the category of a SoftwareProduct
- Popularity.Category: Adds/Removes popularity to a SoftwareCategory
- Popularity.* : Adds/Removes popularity from the category (Popularity.ComputerOS would add/remove popularity form the Computer OS category)
- Experience.* : Adds/Removes experience in a category to an actor/employee (Experience.Leadership would add/remove leadership experience to an actor/employee)
- BusinessRep.Change: Adds/Removes Business Reputation to the players company
- StockMarkets.Change: Changes all Stocks inside the StockMarket
- StockMarkets.SingleChange: Changes a single Stock
- EmployeeDetails.Stress: Changes the stress of an actor/employee
- EmployeeDetails.Satisfaction: Changes the satisfaction of an actor/employee
- EmployeeDetails.SendHome: Sends an actor/employee home
- SoftwareDetails.Bugs: Adds/Removes bugs from a SoftwareProduct
