// 

using UnrealBuildTool;
using System.Collections.Generic;

public class SurvivalGameServerTarget : TargetRules
{
	public SurvivalGameServerTarget(TargetInfo Target) : base(Target)
    {
        DefaultBuildSettings = BuildSettingsVersion.V2;
        Type = TargetType.Server;
        ExtraModuleNames.AddRange(new string[] { "SurvivalGame" });
    }
}
