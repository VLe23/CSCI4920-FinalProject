// 

using UnrealBuildTool;
using System.Collections.Generic;

public class SurvivalGameTarget : TargetRules
{
	public SurvivalGameTarget(TargetInfo Target) : base(Target)
    {
        DefaultBuildSettings = BuildSettingsVersion.V2;
        Type = TargetType.Game;
        ExtraModuleNames.AddRange(new string[] { "SurvivalGame" });
    }
}
