﻿// Decompiled with JetBrains decompiler
// Type: TownOfUs.SheriffMod.HUDClose
// Assembly: TownOfUs, Version=1.0.3.0, Culture=neutral, PublicKeyToken=null
// MVID: 167B09F5-14AA-4A43-BCE6-062AB9919D13
// Assembly location: C:\temp\TownOfUs-2020.12.9s.dll

using HarmonyLib;
using System;

namespace TownOfUs.SheriffMod
{
  [HarmonyPatch(typeof (OOCJALPKPEP))]
  public static class HUDClose
  {
    [HarmonyPatch("Close")]
    public static void Postfix(PIEFJFEOGOL __instance)
    {
      Methods.LastKilled = DateTime.UtcNow;
      Methods.LastKilled = Methods.LastKilled.AddSeconds(8.0);
    }
  }
}
