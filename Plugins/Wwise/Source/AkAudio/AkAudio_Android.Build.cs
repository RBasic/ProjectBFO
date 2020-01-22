// Copyright 1998-2011 Epic Games, Inc. All Rights Reserved.
using UnrealBuildTool;
using System;
using System.IO;
using System.Collections.Generic;

public class AkUEPlatform_Android : AkUEPlatform
{
	public AkUEPlatform_Android(ReadOnlyTargetRules in_TargetRules, string in_ThirdPartyFolder) : base(in_TargetRules, in_ThirdPartyFolder) {}

	public override string SanitizeLibName(string in_libName)
	{
		return in_libName;
	}

	public override string GetPluginFullPath(string PluginName, string LibPath)
	{
		return Path.Combine(LibPath, "lib" + PluginName + ".a");
	}

	public override bool SupportsAkAutobahn { get { return false; } }
	
	public override bool SupportsCommunication { get { return true; } }

	public override List<string> GetPublicLibraryPaths()
	{
		return new List<string> 
		{
			Path.Combine(ThirdPartyFolder, "Android_armeabi-v7a", akConfigurationDir, "lib"),
			Path.Combine(ThirdPartyFolder, "Android_x86", akConfigurationDir, "lib"),
			Path.Combine(ThirdPartyFolder, "Android_arm64-v8a", akConfigurationDir, "lib"),
			Path.Combine(ThirdPartyFolder, "Android_x86_64", akConfigurationDir, "lib")
		};
	}
	
	public override List<string> GetPublicAdditionalLibraries()
	{
		return new List<string>();
	}
	
	public override List<string> GetPublicDefinitions()
	{
		return new List<string> {"__ANDROID__"};
	}

	public override List<string> GetPublicAdditionalFrameworks()
	{
		return new List<string>();
	}
}
