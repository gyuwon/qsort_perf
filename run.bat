@echo off

rem C++ x86

echo|set /p=[C++ x86] 
.\Release\CPPSort.exe
echo|set /p=[C++ x86 3-way] 
.\Release\CPPSort.exe threeway
echo|set /p=[C++ x86 Built-in] 
.\Release\CPPSort.exe builtin


echo.


rem C++ x64

echo|set /p=[C++ x64] 
.\x64\Release\CPPSort.exe
echo|set /p=[C++ x64 3-way Built-in] 
.\x64\Release\CPPSort.exe threeway
echo|set /p=[C++ x64 Built-in] 
.\x64\Release\CPPSort.exe builtin


echo.


rem C# x86

echo|set /p=[C# x86] 
.\CSSort\bin\x86\Release\CSSort.exe
echo|set /p=[C# x86 3-way] 
.\CSSort\bin\x86\Release\CSSort.exe threeway
echo|set /p=[C# x86 Built-in] 
.\CSSort\bin\x86\Release\CSSort.exe builtin


echo.


rem C# x64

echo|set /p=[C# x64] 
.\CSSort\bin\x64\Release\CSSort.exe
echo|set /p=[C# x64 3-way] 
.\CSSort\bin\x64\Release\CSSort.exe threeway
echo|set /p=[C# x64 Built-in] 
.\CSSort\bin\x64\Release\CSSort.exe builtin


echo.


rem Java

echo|set /p=[Java] 
java -cp .\JSort\bin Program
echo|set /p=[Java 3-way] 
java -cp .\JSort\bin Program threeway
echo|set /p=[Java Built-in] 
java -cp .\JSort\bin Program builtin


echo.


rem Node.js

echo|set /p=[Node.js] 
node .\JSSort\program.js
echo|set /p=[Node.js 3-way] 
node .\JSSort\program.js threeway
echo|set /p=[Node.js Built-in] 
node .\JSSort\program.js builtin
