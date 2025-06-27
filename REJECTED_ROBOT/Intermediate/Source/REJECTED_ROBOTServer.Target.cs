using UnrealBuildTool;

public class REJECTED_ROBOTServerTarget : TargetRules
{
	public REJECTED_ROBOTServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("REJECTED_ROBOT");
	}
}
