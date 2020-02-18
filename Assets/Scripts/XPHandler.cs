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
    }

    public void GainXP(BattleResultEventData data)
    {
        Int XPgained  = 0

        if (Formula > 0) //win
        {
            Int XPgained = Random.Range(2, 5);
            GameEvents.PlayerXPGain(Xpgained);
        }
        
        else (Formula = 0) //tie
        {
            Int XPgained = Random.Range(0, 2);
            GameEvents.PlayerXPGain(Xpgained);
        }
        
        else (Formula < 0) //lose
        {
        
        }

        XP += XPgained
        //GameEvents.PlayerLevelUp(1) for levelup animation
    };

    private void OnEnable()
    {
        Level = 1;
    }

    private void OnDisable()
    {
    }

    public void LevelManage(BattleResultEventData data)
    {

        
    }
}