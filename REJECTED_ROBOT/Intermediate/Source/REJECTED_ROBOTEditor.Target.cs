using UnrealBuildTool;

public class REJECTED_ROBOTEditorTarget : TargetRules
{
	public REJECTED_ROBOTEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("REJECTED_ROBOT");
	}
}
