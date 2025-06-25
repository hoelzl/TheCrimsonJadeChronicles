// Copyright Dr. Matthias Hölzl

using UnrealBuildTool;

public class CrimsonJadeCore : ModuleRules
{
	public CrimsonJadeCore(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {"Core", "CoreUObject"});

		PrivateDependencyModuleNames.AddRange(new string[] { });
	}
}
