using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public bool _gameover = false;
    private int _enemyKillCount = 0;

    public void IncrementKillCount()
    {
        _enemyKillCount++;
        Debug.Log($"Enemy Kill Count: {_enemyKillCount}");
    }
}
