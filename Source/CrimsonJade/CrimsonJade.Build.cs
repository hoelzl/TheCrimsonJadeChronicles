// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CrimsonJade : ModuleRules
{
	public CrimsonJade(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
			{"Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "CrimsonJadeCore"});

		PrivateDependencyModuleNames.AddRange(new string[] { });
	}
}
