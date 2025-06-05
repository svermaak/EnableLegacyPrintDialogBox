using Microsoft.Win32;
using System;

class Program
{
    static void Main()
    {
        try
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Print\UnifiedPrintDialog"))
            {
                if (key != null)
                {
                    key.SetValue("PreferLegacyPrintDialog", 1, RegistryValueKind.DWord);
                    Console.WriteLine("Registry value set successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create or open registry key.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}