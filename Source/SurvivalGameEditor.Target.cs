// 

using UnrealBuildTool;
using System.Collections.Generic;

public class SurvivalGameEditorTarget : TargetRules
{
	public SurvivalGameEditorTarget(TargetInfo Target) : base(Target)
    {
        DefaultBuildSettings = BuildSettingsVersion.V2;
        Type = TargetType.Editor;
        ExtraModuleNames.AddRange(new string[] { "SurvivalGame" });
    }
}
