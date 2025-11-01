@echo off
cd /d "C:\Users\rinsh\OneDrive\Desktop\vscode\GitAutoLogger\newRepoServices\Implementations"

set LOGFILE=C:\Users\rinsh\OneDrive\Desktop\vscode\GitAutoLogger\newRepoServices\Implementations\TechnicianServices.txt

echo Auto commit at %date% %time% >> "%LOGFILE%"
git add .
git commit -m "Technician Service Updated on %date% %time%"
git push origin main
exit
