using System;
using System.Diagnostics;
using Figgle;

class Program
{
    private static bool isTMP = false;
    private static bool isVarTMP = false;

    static void Clean()
    {
        var process = new Process()
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "/bin/bash",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            }
        };

        if (isTMP && isVarTMP)
        {
            process.StartInfo.Arguments = "-c \"sudo rm -rf /tmp/* && sudo rm -rf /var/tmp/*\"";
        }
        else if (isTMP)
        {
            process.StartInfo.Arguments = "-c \"sudo rm -rf /tmp/*\"";
        }
        else if (isVarTMP)
        {
            process.StartInfo.Arguments = "-c \"sudo rm -rf /var/tmp/*\"";
        }

        try
        {
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            Console.WriteLine("Done!");
            Console.WriteLine(output);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Environment.Exit(1);
        }
    }

    static void Main(string[] args)
    {
        if (args.Length == 0 || args[0] == "--help")
        {
            Console.WriteLine(FiggleFonts.Graffiti.Render("TMPKiller"));
            Console.WriteLine("Help: To clear /tmp/* or /var/tmp/* enter the arguments:");
            Console.WriteLine("--tmp for /tmp");
            Console.WriteLine("--var for /var/tmp");
            Console.WriteLine("Example: tmpkiller --tmp --var");
            return;
        }

        Console.WriteLine(FiggleFonts.Graffiti.Render("TMPKiller"));

        isTMP = Array.Exists(args, arg => arg == "--tmp");
        isVarTMP = Array.Exists(args, arg => arg == "--var");

        if (!isTMP && !isVarTMP)
        {
            Console.WriteLine("You have not selected anything.. Exit code: 1");
            Environment.Exit(1);
        }

        if (isTMP)
        {
            Console.WriteLine("Cleaning /tmp/* ...");
        }
        if (isVarTMP)
        {
            Console.WriteLine("Cleaning /var/tmp/* ...");
        }

        Clean();
    }
}