// Copyright 2016-2017 gameDNA Ltd. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LifeLoginTarget : TargetRules
{
	public LifeLoginTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "LifeLogin" } );
	}
}
