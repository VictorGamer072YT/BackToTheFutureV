using LemonUI.Menus;
using System;
using System.ComponentModel;

namespace BackToTheFutureV
{
    internal class DEBUGMenu : BTTFVMenu
    {
        private NativeCheckboxItem debugFuel;
        private NativeCheckboxItem debugRange;

        public override string GetItemTitle(string itemName)
        {
            return $"{itemName}";
        }

       /* public override string pidorrodip(string InternalName)
        {
            return "Debug Settings";
        }*/

        public DEBUGMenu() : base("DEBUG")
        {
            //debugFuel  = NewCheckboxItem("debugFuel", ModSettings.debugFuel);
            //debugRange = NewCheckboxItem("debugRange", ModSettings.debugRange);
            debugRange = NewCheckboxItem("Infinite RC Range", ModSettings.debugRange);
            debugFuel = NewCheckboxItem("Infinite Fuel", ModSettings.debugFuel);
        }

        public override void Menu_OnItemCheckboxChanged(NativeCheckboxItem sender, EventArgs e, bool Checked)
        {
            if (sender == debugFuel)
                ModSettings.debugFuel = Checked;

            if (sender == debugRange)
                ModSettings.debugRange = Checked;

            ModSettings.SaveSettings();
        }

        public override void Menu_OnItemActivated(NativeItem sender, EventArgs e)
        {

        }

        public override void Menu_Shown(object sender, EventArgs e)
        {

        }

        public override void Tick()
        {

        }

        public override void Menu_OnItemValueChanged(NativeSliderItem sender, EventArgs e)
        {

        }

        public override void Menu_OnItemSelected(NativeItem sender, SelectedEventArgs e)
        {

        }

        public override void Menu_Closing(object sender, CancelEventArgs e)
        {

        }
    }
}
