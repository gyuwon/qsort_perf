#include <iostream>
#include <random>
#include <ctime>
#include <algorithm>

using namespace std;

void quicksort(int *a, size_t n);
void quicksort_threeway(int *a, size_t start, size_t end);
bool is_sorted(int *a, size_t n);
clock_t run(int *a, size_t n, int seed, bool threeway, bool builtin);

int main(size_t argc, char *argv [])
{
  const size_t n = 1000000;
  auto threeway = false;
  auto builtin = false;
  for (size_t i = 0; i < argc; i++)
  {
    if (strcmp(argv[i], "threeway") == 0)
    {
      threeway = true;
      break;
    }
    else if (strcmp(argv[i], "builtin") == 0)
    {
      builtin = true;
      break;
    }
  }
  auto a = new int[n];
  __try
  {
    const int iter = 12, trim = 1;
    clock_t elapsed[iter];
    for (size_t i = 0; i < iter; i++)
    {
      elapsed[i] = run(a, n, (int) time(NULL), threeway, builtin);
    }
    sort(elapsed, elapsed + iter);
    clock_t sum = 0;
    for (size_t i = trim; i <= iter - trim * 2; i++)
    {
      sum += elapsed[i];
    }
    auto mean = double(sum) / (iter - trim * 2) / CLOCKS_PER_SEC * 1000;
    cout << mean << " ms elapsed." << endl;
    return 0;
  }
  __finally
  {
    delete [] a;
  }
}

clock_t run(int *a, size_t n, int seed, bool threeway, bool builtin)
{
  srand(seed);
  for (size_t i = 0; i < n; i++)
  {
    a[i] = rand();
  }
  clock_t begin;
  if (threeway)
  {
    begin = clock();
    quicksort_threeway(a, 0, n);
  }
  else if (builtin)
  {
    begin = clock();
    sort(a, a + n);
  }
  else
  {
    begin = clock();
    quicksort(a, n);
  }
  auto elapsed = clock() - begin;
  if (is_sorted(a, n) == false)
  {
    throw "Not sorted!";
  }
  return elapsed;
}

void quicksort(int *a, size_t n)
{
  if (n < 2)
  {
    return;
  }
  int p = a[n / 2];
  int *l = a;
  int *r = a + n - 1;
  while (l <= r)
  {
    if (*l < p)
    {
      ++l;
      continue;
    }
    if (*r > p)
    {
      --r;
      continue;
    }
    int t = *l;
    *l++ = *r;
    *r-- = t;
  }
  quicksort(a, r - a + 1);
  quicksort(l, a + n - l);
}

void quicksort_threeway(int *a, size_t start, size_t end)
{
  if (end - start < 2)
  {
    return;
  }
  auto p = a[start];
  auto l = start;
  auto m = l + 1;
  auto i = m;
  while (i < end)
  {
    if (a[i] < p)
    {
      a[l++] = a[i];
      a[i] = a[m];
      a[m++] = p;
    }
    else if (a[i] == p)
    {
      a[i] = a[m];
      a[m++] = p;
    }
    ++i;
  }
  quicksort_threeway(a, start, l);
  quicksort_threeway(a, m, end);
}

bool is_sorted(int *a, size_t n)
{
  for (size_t i = 1; i < n; i++)
  {
    if (a[i - 1] > a[i])
    {
      return false;
    }
  }
  return true;
}