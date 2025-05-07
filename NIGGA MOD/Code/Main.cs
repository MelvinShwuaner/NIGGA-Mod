using NCMS;
using UnityEngine;
using HarmonyLib;
using System;
namespace NIGGAS
{
    [ModEntry]
    class Main : MonoBehaviour
    {
        void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(NIGGAAAAA));
        }
    }
    public class NIGGAAAAA
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(MusicBox), nameof(MusicBox.playSound), new Type[] { typeof(string), typeof(float), typeof(float), typeof(bool), typeof(bool) })]
        [HarmonyPriority(Priority.High)]
        static void NIGGA(ref string pSoundPath)
        {
            pSoundPath = "NIGGA";
        }
    }
}
