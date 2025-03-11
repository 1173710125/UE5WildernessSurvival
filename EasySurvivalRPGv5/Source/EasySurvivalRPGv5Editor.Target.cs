// Easy Systems

using UnrealBuildTool;
using System.Collections.Generic;

public class EasySurvivalRPGv5EditorTarget : TargetRules
{
	public EasySurvivalRPGv5EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "EasySurvivalRPGv5" } );
	}
}
