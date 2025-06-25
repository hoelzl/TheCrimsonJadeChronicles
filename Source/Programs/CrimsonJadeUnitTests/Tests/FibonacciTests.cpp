#include "CoreTypes.h"
#include "TestHarness.h"

#include "Fibonacci.h"

TEST_CASE("Game.CrimsonJade.Core.Fibonacci", "[CrimsonJade][CrimsonJade.Core]")
{
    SECTION("Fib(0) should be 1")
    {
        CHECK(FFibonacci::Calculate(0) == 1);
    }

    SECTION("Fib(1) should be 1")
    {
        CHECK(FFibonacci::Calculate(1) == 1);
    }

    SECTION("Fib(2) should be 2")
    {
        CHECK(FFibonacci::Calculate(2) == 2);
    }

    SECTION("Fib(3) should be 3")
    {
        CHECK(FFibonacci::Calculate(3) == 3);
    }

    SECTION("Fib(4) should be 5")
    {
        CHECK(FFibonacci::Calculate(4) == 5);
    }

    SECTION("Fib(5) should be 10")
    {
        CHECK(FFibonacci::Calculate(5) == 8);
    }

}
