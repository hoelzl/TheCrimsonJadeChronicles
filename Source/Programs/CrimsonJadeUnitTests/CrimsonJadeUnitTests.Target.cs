// Copyright Dr. Matthias Hölzl

using UnrealBuildTool;

[SupportedPlatforms(UnrealPlatformClass.All)]
public class CrimsonJadeUnitTestsTarget : TestTargetRules
{
    public CrimsonJadeUnitTestsTarget(TargetInfo Target) : base(Target)
    {
        bCompileAgainstCoreUObject = true;
    }
}
