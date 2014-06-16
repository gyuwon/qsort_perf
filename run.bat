@echo off

rem C++ x86

echo|set /p=[C++ x86] 
.\Release\CPPSort.exe
echo|set /p=[C++ Built-in x86] 
.\Release\CPPSort.exe builtin


rem C++ x64

echo|set /p=[C++ x64] 
.\x64\Release\CPPSort.exe
echo|set /p=[C++ Built-in x64] 
.\x64\Release\CPPSort.exe builtin



rem C# x86

echo|set /p=[C# x86] 
.\CSSort\bin\x86\Release\CSSort.exe
echo|set /p=[C# Built-in x86] 
.\CSSort\bin\x86\Release\CSSort.exe builtin


rem C# x64

echo|set /p=[C# x64] 
.\CSSort\bin\x64\Release\CSSort.exe
echo|set /p=[C# Built-in x64] 
.\CSSort\bin\x64\Release\CSSort.exe builtin


rem Node.js

echo|set /p=[Node.js] 
node .\JSSort\program.js
echo|set /p=[Node.js Built-in] 
node .\JSSort\program.js builtin


rem Java

echo|set /p=[Java] 
java -cp .\JSort\bin Program
echo|set /p=[Java Built-in] 
java -cp .\JSort\bin Program builtin
