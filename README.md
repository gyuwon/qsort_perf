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
[C++ x86] 56.3 ms elapsed.
[C++ x86 3-way] 65.8 ms elapsed.
[C++ x86 Built-in] 57.8 ms elapsed.

[C++ x64] 56.5 ms elapsed.
[C++ x64 3-way Built-in] 56.5 ms elapsed.
[C++ x64 Built-in] 56.3 ms elapsed.

[C# x86] 89.86186 ms elapsed.
[C# x86 3-way] 89.29654 ms elapsed.
[C# x86 Built-in] 85.36955 ms elapsed.

[C# x64] 81.70353 ms elapsed.
[C# x64 3-way] 81.56661 ms elapsed.
[C# x64 Built-in] 67.76517 ms elapsed.

[Java] 84.5 ms elapsed.
[Java 3-way] 51.5 ms elapsed.
[Java Built-in] 56.3 ms elapsed.

[Node.js] 112.4 ms elapsed.
[Node.js 3-way] 126.7 ms elapsed.
[Node.js Built-in] 195.4 ms elapsed.
```
