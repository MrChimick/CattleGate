using RimWorld;
using Verse;

namespace CattleGate
{
    public class Building_CattleGate : Building_Door
    {
        public override bool PawnCanOpen(Pawn p)
        {
            return !p.AnimalOrWildMan();
        }
    }
}