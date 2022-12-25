
using HKTool.Menu;
using Modding.Menu;
using Modding.Menu.Config;

namespace BackDashMod;

class SettingsMenu : CustomMenu
{
    public SettingsMenu(MenuScreen rs) : base(rs, "Back Dash")
    {

    }
    protected override void Build(ContentArea contentArea)
    {
        contentArea.AddKeybind("dashKeyKeybind", BackDash.Instance.globalSettings.keySettings.backDash,
            new()
            {
                Label = "Back Dash",
                CancelAction = Back,
                Style = KeybindStyle.VanillaStyle
            });
    }
}
