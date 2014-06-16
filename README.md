# C++와 C#, Java, 그리고 Node.js 정렬 성능 비교

## 준비

### C++, C#
구성 관리자를 사용해 솔루션 구성을 Release로 선택하고 솔루션 플랫폼을 x86과 x64에 대해 각각 빌드합니다.

### Java
``` text
> cd .\JSort
> mkdir .\bin
> javac .\Program.java -d .\bin
> cd ..
```

### Node.js
```text
> cd .\JSSort
> npm install
> cd ..
```

## 실행
```text
> .\run.bat
```

## 결과

다음과 유사한 결과가 출력됩니다.

```text
[C++ x86] 60.1 ms elapsed.
[C++ x86 3-way] 66.6 ms elapsed.
[C++ x86 Built-in] 65.7 ms elapsed.

[C++ x64] 61.5 ms elapsed.
[C++ x64 3-way Built-in] 62.6 ms elapsed.
[C++ x64 Built-in] 61.8 ms elapsed.

[C# x86] 95.76737 ms elapsed.
[C# x86 3-way] 95.08319 ms elapsed.
[C# x86 Built-in] 92.53864 ms elapsed.

[C# x64] 85.56388 ms elapsed.
[C# x64 3-way] 84.82775 ms elapsed.
[C# x64 Built-in] 72.35709 ms elapsed.

[Java] 109.8 ms elapsed.
[Java 3-way] 78.0 ms elapsed.
[Java Built-in] 67.4 ms elapsed.

[Node.js] 118 ms elapsed.
[Node.js 3-way] 132.5 ms elapsed.
[Node.js Built-in] 208.8 ms elapsed.
```
