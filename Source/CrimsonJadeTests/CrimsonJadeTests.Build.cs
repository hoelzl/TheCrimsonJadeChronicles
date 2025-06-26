using UnrealBuildTool;

public class CrimsonJadeTests : ModuleRules
{
	public CrimsonJadeTests(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			[
				"Core"
			]
		);

		PrivateDependencyModuleNames.AddRange(
			[
				"CoreUObject",
				"Engine",
				"CrimsonJadeCore",
				"CrimsonJade"
			]
		);
	}
}
