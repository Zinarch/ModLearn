using UnityModManagerNet;

namespace FirstMod
{
    public class Settings : UnityModManager.ModSettings
    {
        public float MyFloatOption = 2f;
        public bool MyBoolOption = true;
        public string MyTextOption = "Hello";

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            Save(this, modEntry);
        }
    }
}