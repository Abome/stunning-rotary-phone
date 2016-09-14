call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\VsDevCmd.bat"
cd "C:\Users\SKWIZ\Documents\visual studio 2015\Projects\EWT\EWT\Manifest"
wevtutil um Test.man
mc -r ..\Bin\Debug -cs EWT Test.man
rc ..\Bin\Debug\Test.rc
csc /target:library /unsafe /win32res:..\Bin\Debug\Test.res .\Test.cs
copy Test.dll c:\
wevtutil im Test.man
pause