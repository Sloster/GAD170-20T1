using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  A <see langword="static"/> class with methods (functions) for initialising or randomising the stats class.
///  
/// TODO:
///     Initialise a stats instance with generated starting stats
///     Handle the assignment of extra points or xp into an existing stats of a character
///         - this is expected to be used by NPCs leveling up to match the player.
/// </summary>
public static class StatsGenerator
{
    public static void InitialStats(Stats Stats)
    {
        int TotalPoints = 10;

        Stats.style = Random.Range(1, TotalPoints);
        TotalPoints -= Stats.style;

        Stats.luck = Random.Range(1, TotalPoints);
        TotalPoints -= Stats.luck;

        Stats.rhythm = TotalPoints;
    }

    public static void AssignUnusedPoints(Stats Stats, int points)
    {
        Stats.luck = Random.Range(1, 10);
        Stats.rhythm = Random.Range(1, 10);
    }
}
