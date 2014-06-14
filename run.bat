@echo off

rem C++

echo|set /p=[C++ x86] 
.\Release\CPPSort.exe
echo|set /p=[C++ x64] 
.\x64\Release\CPPSort.exe


rem C#

echo|set /p=[C# x86] 
.\CSSort\bin\x86\Release\CSSort.exe
echo|set /p=[C# x64] 
.\CSSort\bin\x64\Release\CSSort.exe


rem C# Built-in

echo|set /p=[C# Built-in x86] 
.\CSSortBuiltin\bin\x86\Release\CSSortBuiltin.exe
echo|set /p=[C# Built-in x64] 
.\CSSortBuiltin\bin\x64\Release\CSSortBuiltin.exe