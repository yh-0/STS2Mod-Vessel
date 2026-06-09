using BaseLib.Abstracts;
using Vessel.VesselCode.Extensions;
using Godot;

namespace Vessel.VesselCode.Character;

public class VesselPotionPool : CustomPotionPoolModel
{
    public override Color LabOutlineColor => Vessel.Color;


    public override string BigEnergyIconPath => "charui/big_energy.png".ImagePath();
    public override string TextEnergyIconPath => "charui/text_energy.png".ImagePath();
}