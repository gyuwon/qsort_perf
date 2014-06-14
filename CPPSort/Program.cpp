#include <iostream>
#include <random>
#include <ctime>

using namespace std;

void quicksort(int *a, size_t n);
bool is_sorted(int *a, size_t n);

int main()
{
	const size_t n = 1000000;
	auto a = new int[n];
	__try
	{
		srand(1);
		for (size_t i = 0; i < n; i++)
		{
			a[i] = rand();
		}
		auto begin = clock();
		quicksort(a, n);
		auto elapsed = double(clock() - begin) / CLOCKS_PER_SEC;
		if (is_sorted(a, n) == false)
		{
			throw "Not sorted!";
		}
		cout << elapsed << " sec elapsed." << endl;
		return 0;
	}
	__finally
	{
		delete[] a;
	}
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
