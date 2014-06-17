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
[C++ x86] 56.1 ms elapsed.
[C++ x86 3-way] 52.9 ms elapsed.
[C++ x86 Built-in] 59.4 ms elapsed.

[C++ x64] 58 ms elapsed.
[C++ x64 3-way Built-in] 51.5 ms elapsed.
[C++ x64 Built-in] 56.5 ms elapsed.

[C# x86] 89.11445 ms elapsed.
[C# x86 3-way] 69.61606 ms elapsed.
[C# x86 Built-in] 85.77279 ms elapsed.

[C# x64] 80.22449 ms elapsed.
[C# x64 3-way] 68.32525 ms elapsed.
[C# x64 Built-in] 66.98688 ms elapsed.

[Java] 84.4 ms elapsed.
[Java 3-way] 50.0 ms elapsed.
[Java Built-in] 53.0 ms elapsed.

[Node.js] 112.5 ms elapsed.
[Node.js 3-way] 125 ms elapsed.
[Node.js Built-in] 192.2 ms elapsed.
```
