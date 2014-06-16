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
[C++ x86] 56.5 ms elapsed.
[C++ Built-in x86] 64.2 ms elapsed.
[C++ x64] 56.5 ms elapsed.
[C++ Built-in x64] 61 ms elapsed.
[C# x86] 84.02835 ms elapsed.
[C# Built-in x86] 86.42417 ms elapsed.
[C# x64] 81.10581 ms elapsed.
[C# Built-in x64] 67.99592 ms elapsed.
[Java] 98.5 ms elapsed.
[Java Built-in] 67.0 ms elapsed.
[Node.js] 110.9 ms elapsed.
[Node.js Built-in] 196.8 ms elapsed.
```
