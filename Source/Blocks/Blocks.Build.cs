using UnrealBuildTool;

public class Blocks : ModuleRules
{
        public Blocks(ReadOnlyTargetRules Target) : base(Target)
    {
        /* AIModule is not assigned by default, must be added when dealing with AI in your project */
        PublicDependencyModuleNames.AddRange(new string[] {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "AIModule",
            /* Temporarily added GameplayTasks to workaround 4.12 compilation bug. */
            "GameplayTasks",
            "NavigationSystem",
        });

        PrivateDependencyModuleNames.AddRange(new string[] {  });
        }
}
