
using InControl;
using Modding.Converters;
using Newtonsoft.Json;

namespace BackDashMod;

[Serializable]
class Settings 
{
    [JsonConverter(typeof(PlayerActionSetConverter))]
    public KeySettings keySettings = new();
}

class KeySettings : PlayerActionSet
{
    public KeySettings()
    {
        backDash = CreatePlayerAction("HKBackDash");
    }
    public PlayerAction backDash;
}
