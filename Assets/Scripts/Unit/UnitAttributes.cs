using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAttributes : MonoBehaviour
{
    [SerializeField] private int strength;
    [SerializeField] private int mana;
    [SerializeField] private int skill;
    [SerializeField] private int agility;
    [SerializeField] private int defense;
    [SerializeField] private int maginDefense;
    [SerializeField] private int movementSpeed;

    public void SetStrength(int strength)
    {
        this.strength = strength;
    }

    public int GetStrength()
    {
        return strength;
    }

    public void SetMana(int mana)
    {
        this.mana = mana;
    }

    public int GetMana()
    {
        return mana;
    }

    public void SetSkill(int skill)
    {
        this.skill = skill;
    }

    public int GetSkill()
    {
        return skill;
    }

    public void SetAgility(int agility)
    {
        this.agility = agility;
    }

    public int GetAgility()
    {
        return agility;
    }

    public void SetDefense(int defense)
    {
        this.defense = defense;
    }

    public int GetDefense()
    {
        return defense;
    }

    public void SetMagicDefense(int maginDefense)
    {
        this.maginDefense = maginDefense;
    }

    public int GetMagicDefense()
    {
        return maginDefense;
    }

    public void SetMovementSpeed(int movementSpeed)
    {
        this.movementSpeed = movementSpeed;
    }

    public int GetMovementSpeed()
    {
        return movementSpeed;
    }
}
