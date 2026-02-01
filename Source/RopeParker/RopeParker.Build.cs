// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RopeParker : ModuleRules
{
	public RopeParker(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"RopeParker",
			"RopeParker/Variant_Platforming",
			"RopeParker/Variant_Platforming/Animation",
			"RopeParker/Variant_Combat",
			"RopeParker/Variant_Combat/AI",
			"RopeParker/Variant_Combat/Animation",
			"RopeParker/Variant_Combat/Gameplay",
			"RopeParker/Variant_Combat/Interfaces",
			"RopeParker/Variant_Combat/UI",
			"RopeParker/Variant_SideScrolling",
			"RopeParker/Variant_SideScrolling/AI",
			"RopeParker/Variant_SideScrolling/Gameplay",
			"RopeParker/Variant_SideScrolling/Interfaces",
			"RopeParker/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
