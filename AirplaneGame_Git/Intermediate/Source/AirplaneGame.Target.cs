using UnrealBuildTool;

public class AirplaneGameTarget : TargetRules
{
	public AirplaneGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("AirplaneGame");
	}
}
