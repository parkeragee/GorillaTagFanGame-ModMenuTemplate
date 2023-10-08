using System;
using HarmonyLib;

[HarmonyPatch(typeof(kick))]
[HarmonyPatch("OnTriggerEnter")]
public static class KickPatch
{
	private static bool Prefix()
	{
		return false;
	}
}
