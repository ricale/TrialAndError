using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    public static TurnSystem Instance { get; private set; }

    public event EventHandler OnTurnChanged;

    private List<Unit> unitList;
    private int currentUnitNumber = -1;
    private int turnNumber = 1;
    private bool isPlayerTurn = true;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("There's more than one TurnSystem!" + transform + " - " + Instance);
            Destroy(gameObject);
        }
        Instance = this;
        
        unitList = new List<Unit>();
    }

    public void AddUnit(Unit unit)
    {
        unitList.Add(unit);
    }

    public void RemoveUnit(Unit unit)
    {
        unitList.Remove(unit);
    }

    public void NextTurn()
    {
        Debug.Log(">>> NextTurn");
        currentUnitNumber += 1;
        if(currentUnitNumber >= unitList.Count)
        {
            currentUnitNumber = 0;
            turnNumber += 1;
        }
        // turnNumber++;
        // isPlayerTurn = !isPlayerTurn;
        OnTurnChanged?.Invoke(this, EventArgs.Empty);
    }

    public Unit GetPreviousTurnUnit()
    {
        return unitList[
            currentUnitNumber - 1 < 0
                ? unitList.Count - 1
                : currentUnitNumber - 1
            ];
    }

    public Unit GetCurrentTurnUnit()
    {
        return unitList[currentUnitNumber];
    }

    public int GetTurnNumber()
    {
        return turnNumber;
    }

    public bool IsPlayerTurn()
    {
        return isPlayerTurn;
    }
}
