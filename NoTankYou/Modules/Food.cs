﻿using KamiLib.Extensions;
using Lumina.Excel.Sheets;
using NoTankYou.Classes;
using NoTankYou.Localization;

namespace NoTankYou.Modules;

public class Food : ConsumableModule<FoodConfiguration> {
    public override ModuleName ModuleName => ModuleName.Food;
    protected override string DefaultWarningText => Strings.FoodWarning;
    protected override uint IconId => Service.DataManager.GetExcelSheet<Item>().GetRow(30482).Icon;
    protected override string IconLabel => ModuleName.Food.GetDescription();
    protected override uint StatusId => 48; // Well Fed
}

public class FoodConfiguration() : ConsumableConfiguration(ModuleName.Food);
