@echo off
cd /d "C:\Users\rinsh\OneDrive\Desktop\vscode\GitAutoLogger\newRepo"
echo Auto commit at %date% %time% >> logs.txt
git add .
git commit -m "Log Done on %date% %time%"
git push origin main
exit
