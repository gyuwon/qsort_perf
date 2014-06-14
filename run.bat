@echo off

rem C++

echo|set /p=[C++ x86] 
.\Release\CPPSort.exe
echo|set /p=[C++ x64] 
.\x64\Release\CPPSort.exe


rem C++ Built-in

echo|set /p=[C++ Built-in x86] 
.\Release\CPPSort.exe builtin
echo|set /p=[C++ Built-in x64] 
.\x64\Release\CPPSort.exe builtin



rem C#

echo|set /p=[C# x86] 
.\CSSort\bin\x86\Release\CSSort.exe
echo|set /p=[C# x64] 
.\CSSort\bin\x64\Release\CSSort.exe


rem C# Built-in

echo|set /p=[C# Built-in x86] 
.\CSSort\bin\x86\Release\CSSort.exe builtin
echo|set /p=[C# Built-in x64] 
.\CSSort\bin\x64\Release\CSSort.exe builtin


rem JavaScript

echo|set /p=[JavaScript] 
node .\JSSort\program.js


rem JavaScript Built-in

echo|set /p=[JavaScript Built-in] 
node .\JSSort\program.js builtin