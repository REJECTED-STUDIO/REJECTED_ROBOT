using UnrealBuildTool;

public class REJECTED_ROBOTTarget : TargetRules
{
	public REJECTED_ROBOTTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("REJECTED_ROBOT");
	}
}
