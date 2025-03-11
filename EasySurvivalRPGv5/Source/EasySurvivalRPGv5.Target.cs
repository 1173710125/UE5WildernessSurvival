// Easy Systems

using UnrealBuildTool;
using System.Collections.Generic;

public class EasySurvivalRPGv5Target : TargetRules
{
	public EasySurvivalRPGv5Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "EasySurvivalRPGv5" } );
	}
}
