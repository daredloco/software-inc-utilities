# Software Inc Utilities
 
## Usage
To use the utilities, simply load the C# classes inside your project.

## Content
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
