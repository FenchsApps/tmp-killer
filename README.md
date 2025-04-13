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
