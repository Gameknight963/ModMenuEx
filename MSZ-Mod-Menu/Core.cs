using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(MSZ_Mod_Menu.Core), "MSZ-Mod-Menu", "1.0.0", "gameknight963")]
[assembly: MelonAuthorColor(255, 86, 65, 157)]
[assembly: MelonAdditionalDependencies("IMGUIUnstrip")]

namespace MSZ_Mod_Menu
{
    public class Core : MelonMod
    {
        
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName != "Version 1.9 POST") return;
            GameObject a = new("MSZModMenu");
            a.AddComponent<ModMenuManager>();
        }
    }
}
