## Installation by using my Package Manager
```bash
git clone https://github.com/FenchsApps/dotpkg.git
cd dotpkg
dotnet publish -c Release -r linux-x64 --self-contained
sudo ln -s $PWD/bin/Release/net6.0/linux-x64/publish/dotpkg /usr/local/bin/dotpkg

dotpkg install tmp-killer
```
## Installation from github
```bash
git clone https://github.com/FenchsApps/tmp-killer.git
cd tmp-killer
dotnet publish -c Release -r linux-x64 --self-contained
sudo ln -s $PWD/Release/net9.0/linux-x64/publish/TMPKiller /usr/local/bin/tmpkiller
```

# **TmpKiller - Documentation**  
*A lightweight cross-platform utility to clean temporary files in Linux `/tmp` and `/var/tmp` directories.*  

---

## **📌 Overview**  
**TmpKiller** is a command-line tool written in C# that helps users safely delete temporary files in Linux systems. It supports:  
- Clearing `/tmp/*`  
- Clearing `/var/tmp/*`  
- ASCII art banner (via Figgle)  
- Help menu  

---

## **⚙️ Installation**  

### **Prerequisites**  
- [.NET 9.0+ Runtime](https://dotnet.microsoft.com/download) (for running)  
- [.NET SDK](https://dotnet.microsoft.com/download) (for building from source)
## **🚀 Usage**  

### **Basic Commands**  
| Command                  | Description                          |
|--------------------------|--------------------------------------|
| `tmpkiller --tmp`        | Cleans `/tmp/*`                      |
| `tmpkiller --var`        | Cleans `/var/tmp/*`                  |
| `tmpkiller --tmp --var`  | Cleans both directories              |
| `tmpkiller --help`       | Shows help menu                      |


## **🔧 Technical Details**  

### **How It Works**  
1. Uses `sudo rm -rf` to delete files (requires admin privileges).  
2. Checks user input via command-line arguments (`--tmp`, `--var`).  
3. Displays ASCII art using [Figgle](https://github.com/drewnoakes/figgle).  

### **Exit Codes**  
| Code | Meaning                     |
|------|-----------------------------|
| `0`  | Success                     |
| `1`  | No directories selected     |
| `2`  | Permission denied (no sudo) |

---

## **⚠️ Warning**  
- **This tool permanently deletes files.** Use with caution!  
- Requires `sudo` privileges (will prompt for password).  
- Test in a safe environment before running in production.  

---

## **📜 License**  
MIT License. See [LICENSE](LICENSE).  

---

## **📬 Support**    
- **Author:** [FenchsApps](https://github.com/FenchsApps)  

---

**🎉 Happy Cleaning!** 🧹
