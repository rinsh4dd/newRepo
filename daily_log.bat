@echo off
cd /d "C:\Users\rinsh\OneDrive\Desktop\vscode\GitAutoLogger\newRepo"

:: Append current date & time
echo %date% %time% >> log.txt

:: Commit and push changes
git add log.txt
git commit -m "Auto log for %date%"
git push origin main
