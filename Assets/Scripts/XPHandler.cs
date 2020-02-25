using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for converting a battle result into xp to be awarded to the player.
/// 
/// TODO:
///     Respond to battle outcome with xp calculation based on;
///         player win 
///         how strong the win was
///         stats/levels of the dancers involved
///     Award the calculated XP to the player stats
///     Raise the player level up event if needed
/// </summary>
public class XPHandler : MonoBehaviour
{
    
    private void OnEnable()
    {
        GameEvents.OnBattleConclude += GainXP;
    }

    private void OnDisable()
    {
        GameEvents.OnBattleConclude -= GainXP;
    }

    public void GainXP(BattleResultEventData data)
    {
        int XPgained  = 0;

        if (data.outcome > 0) //win
        {
            XPgained = Random.Range(2, 5);
            GameEvents.PlayerXPGain(XPgained);
        }
        
        else if (data.outcome == 0) //tie
        {
            XPgained = Random.Range(0, 2);
            GameEvents.PlayerXPGain(XPgained);
        }

        data.player.xp += XPgained;
        //GameEvents.PlayerLevelUp(1) for levelup animation
    }

    public void LevelManager(BattleResultEventData data)
    {
        if (data.player.xp > 10)
        {
            GameEvents.PlayerLevelUp(1);
            data.player.xp = 0;
            data.player.level += 1;
        }
    }
}