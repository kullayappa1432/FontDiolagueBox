# Font Dialog Box - C# Windows Forms Application

## 📌 Overview
This project is a **Windows Forms Application** in C# that allows users to dynamically change the **font family**, **font size**, and **font style** of a text box using combo boxes.

The application fetches all installed fonts from the system and lists them for selection.  
Users can choose a font style (Regular, Bold, Italic, Bold Italic) and font size to see the effect in real-time.

---

## 🖥 Features
- List all installed fonts from the system.
- Choose font size from **6 to 99**.
- Apply different font styles:
  - Regular
  - Bold
  - Italic
  - Bold Italic
- Instant preview of the selected font in a text box.

---

## 📂 Project Structure
FontDialogBox/
│
├── Form1.cs # Main C# code for handling UI and events
├── Form1.Designer.cs # Auto-generated Windows Forms designer code
├── Program.cs # Entry point of the application
└── README.md # Project documentation

---

## 🔧 How It Works
1. **Load Fonts**  
   - Uses `InstalledFontCollection` to get all available system fonts.
   - Populates `comboBox1` with font names.

2. **Load Font Sizes**  
   - Populates `comboBox3` with sizes from **6** to **99**.

3. **Select Font Style**  
   - Uses `comboBox2` for styles like Regular, Bold, Italic, Bold Italic.

4. **Apply Selection**  
   - When a combo box value changes, updates the `diolagueText` font.

---

## 📜 Example Code Snippet
```csharp
InstalledFontCollection col = new InstalledFontCollection();
foreach (FontFamily f in col.Families)
{
    comboBox1.Items.Add(f.Name);
}

for (int i = 6; i < 100; i++)
{
    comboBox3.Items.Add(i);
}
🖥 Requirements

.NET Framework 4.5 or later

Visual Studio 2017+ (Windows Forms project template)

Windows OS

▶️ How to Run

Open the project in Visual Studio.

Restore any missing references if prompted.

Build the project (Ctrl+Shift+B).

Run the application (F5).<img width="856" height="420" alt="font" src="https://github.com/user-attachments/assets/5062350e-4dfe-4321-a6b7-2bfd4d09452b" />

