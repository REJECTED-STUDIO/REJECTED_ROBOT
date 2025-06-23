using UnrealBuildTool;

public class REJECTED_ROBOTClientTarget : TargetRules
{
	public REJECTED_ROBOTClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("REJECTED_ROBOT");
	}
}
