// Copyright 2016-2017 gameDNA Ltd. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LifeLoginEditorTarget : TargetRules
{
	public LifeLoginEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "LifeLogin" } );
	}
}
