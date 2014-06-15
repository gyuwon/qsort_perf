# C++와 C#, 그리고 Node.js 정렬 성능 비교

## 준비

### C++, C#
구성 관리자를 사용해 솔루션 구성을 Release로 선택하고 솔루션 플랫폼을 x86과 x64에 대해 각각 빌드합니다.

### Node.js
```test
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
[C++ x86] 61.7 ms elapsed.
[C++ Built-in x86] 65.3 ms elapsed.
[C++ x64] 59.5 ms elapsed.
[C++ Built-in x64] 61.9 ms elapsed.
[C# x86] 89.40563 ms elapsed.
[C# Built-in x86] 92.5408 ms elapsed.
[C# x64] 84.78906 ms elapsed.
[C# Built-in x64] 72.0759 ms elapsed.
[JavaScript] 117.5 ms elapsed.
[JavaScript Built-in] 211.8 ms elapsed.
```
