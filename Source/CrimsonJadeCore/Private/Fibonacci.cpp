// Copyright Dr. Matthias Hölzl


#include "Fibonacci.h"


int32 FFibonacci::Calculate(int32 Index)
{
    if (Index <= 1)
    {
        return 1;
    }
    return Calculate(Index - 1) + Calculate(Index - 2);
}
