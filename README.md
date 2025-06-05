
# EnableLegacyPrintDialogBox

A simple utility to enable the **legacy print dialog** in Windows by modifying a registry key.
This is useful on systems where the modern print UI is undesirable or causes compatibility issues.

---

## ✅ Prerequisites
- [.NET SDK 6.0 or later](https://dotnet.microsoft.com/en-us/download)  
  Check your version:
  ```
  dotnet --version
  ```

## 🛠️ Build & Run Instructions
1.  Clone the Repository
    ```
    git clone https://github.com/svermaak/EnableLegacyPrintDialogBox.git
    cd EnableLegacyPrintDialogBox
    ```
    
2.  Restore NuGet Packages
    ```
    dotnet restore
    ```
    
3.  Build the Project
    ```
    dotnet build --configuration Release
    ```
    
4.  Run the Executable  
    After building, find the executable at:
    ```
    bin\Release\net6.0\EnableLegacyPrintDialogBox.exe
    ```
    Run it via terminal:
    ```
    .\bin\Release\net6.0\EnableLegacyPrintDialogBox.exe
    ```    

----------

## 🧪 What It Does

This utility sets the following registry key:

```
[HKEY_CURRENT_USER\Software\Microsoft\Print\UnifiedPrintDialog]  
"PreferLegacyPrintDialog"=dword:00000001
```

This forces Windows to use the classic print dialog instead of the modern "Unified Print" experience.

----------

## 🔒 Admin Rights

No admin rights are required. The key is under `HKCU`, so each user can configure this independently.
However, endpoint protection software may block registry changes using `regedit`, `reg.exe`, or PowerShell.

----------

## 🗒️ Note for IT Admins
-  Use Windows APIs like `RegCreateKeyEx` and `RegSetValueEx`
-  This is only for testing
-  It is best to apply this via Group Policy Preferences for this registry path
    

----------

## 📜 License

This project is licensed under the MIT License.

