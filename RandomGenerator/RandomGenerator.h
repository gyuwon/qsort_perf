// RandomGenerator.h

#include <random>
#include <time.h>

#pragma once

using namespace System;

namespace RandomGenerator {

	public ref class RandomNumber abstract sealed
	{
	public:
		static void Generate(array<Int32> ^ array, Int32 seed)
		{
			srand((unsigned)time(NULL));
			for (int i = 0; i < array->Length; i++)
			{
				array[i] = rand();
			}
		}
	};
}
