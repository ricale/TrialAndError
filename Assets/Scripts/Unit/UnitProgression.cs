using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitProgression : MonoBehaviour
{
    [SerializeField] private int level;
    [SerializeField] private int exp;

    // public void SetLevel(int level)
    // {
    //     this.level = level;
    // }

    public int GetLevel()
    {
        return level;
    }

    // public void SetExp(int exp)
    // {
    //     this.exp = exp;
    // }

    public int GetExp()
    {
        return exp;
    }
}
