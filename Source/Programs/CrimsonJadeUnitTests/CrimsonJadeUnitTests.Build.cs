// Copyright Dr. Matthias Hölzl

using UnrealBuildTool;

public class CrimsonJadeUnitTests : TestModuleRules
{
	static CrimsonJadeUnitTests()
	{
		TestMetadata = new Metadata{
			TestName = "The Crimson Jade Chronicles",
			TestShortName = "CrimsonJade",
		};
	}

	public CrimsonJadeUnitTests(ReadOnlyTargetRules target) : base(target)
	{
		// PrivateIncludePaths.AddRange(new string[] { });

		PrivateDependencyModuleNames.AddRange(
		[
			"Core",
			"CoreUObject",
			"CrimsonJadeCore"
		]);
	}
}
