using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreManager
{
    [HideInInspector]
    public static int score;

    public static void AddScore(int amount)
    {
        score += amount;
    }

    public static void RemoveScore(int amount)
    {
        score -= amount;
    }
}
