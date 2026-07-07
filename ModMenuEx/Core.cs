using MelonLoader;
using UnityEngine;
using Object = UnityEngine.Object;

[assembly: MelonInfo(typeof(ModMenuEx.Core), "ModMenuEx", "1.0.0", "gameknight963")]
[assembly: MelonAuthorColor(255, 86, 65, 157)]
[assembly: MelonAdditionalDependencies("IMGUIUnstrip")]

namespace ModMenuEx
{
    public class Core : MelonMod
    {

        public override void OnLateInitializeMelon()
        {
            GameObject a = new("MSZModMenu");
            Object.DontDestroyOnLoad(a);
            a.AddComponent<ModMenuManager>();
        }
    }
}
