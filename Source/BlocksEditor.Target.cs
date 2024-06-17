using UnrealBuildTool;
using System.Collections.Generic;

public class BlocksEditorTarget : TargetRules
{
        public BlocksEditorTarget(TargetInfo Target) : base(Target)
    {
        DefaultBuildSettings = BuildSettingsVersion.V2;
        Type = TargetType.Editor;
        ExtraModuleNames.AddRange(new string[] { "Blocks" });
    }
}
