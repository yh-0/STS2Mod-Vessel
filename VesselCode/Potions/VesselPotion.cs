using BaseLib.Abstracts;
using BaseLib.Utils;
using Vessel.VesselCode.Character;

namespace Vessel.VesselCode.Potions;

[Pool(typeof(VesselPotionPool))]
public abstract class VesselPotion : CustomPotionModel;