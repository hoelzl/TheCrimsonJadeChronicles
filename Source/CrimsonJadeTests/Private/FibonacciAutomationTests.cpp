// Copyright Dr. Matthias Hölzl

#include "Misc/AutomationTest.h"
#include "Fibonacci.h"

IMPLEMENT_SIMPLE_AUTOMATION_TEST(
    FCrimsonJadeCoreAutomationTest, "CrimsonJade.FibonacciAutomation",
    EAutomationTestFlags::EditorContext | EAutomationTestFlags::SmokeFilter);

bool FCrimsonJadeCoreAutomationTest::RunTest(const FString& Parameters)
{
    TestEqual(TEXT("Fibonacci of 0 should be 1"), FFibonacci::Calculate(0), 1);
    TestEqual(TEXT("Fibonacci of 1 should be 1"), FFibonacci::Calculate(1), 1);

    return true;
}
