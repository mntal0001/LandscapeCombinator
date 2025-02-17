// Copyright 2023 LandscapeCombinator. All Rights Reserved.

using UnrealBuildTool;

public class HeightmapModifier : ModuleRules
{
	public HeightmapModifier(ReadOnlyTargetRules Target) : base(Target)
	{
		CppStandard = CppStandardVersion.Cpp20;
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

        // Unreal Dependencies
        PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
			}
		);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				// Unreal Dependencies
				"Projects",
				"InputCore",
				"CoreUObject",
				"Foliage",
				"Engine",
				"Landscape",
				
				// Other Dependencies
				"GDALInterface",
				"LandscapeUtils",
				"ConsoleHelpers"
			}
		);

        if (Target.bBuildEditor)
        {
            PrivateDependencyModuleNames.Add("UnrealEd");
        }
	}
}
