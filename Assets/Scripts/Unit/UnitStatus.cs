using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStatus : MonoBehaviour
{
    private UnitProgression unitProgression;
    private UnitAttributes unitAttributes;

    private void Awake()
    {
        TryGetComponent<UnitProgression>(out unitProgression);
        TryGetComponent<UnitAttributes>(out unitAttributes);
    }

    public int GetMovementPriority()
    {
        int fromAttributes = unitAttributes
            ? unitAttributes.GetAgility() * 10000 + unitAttributes.GetSkill() * 100
            : 0;
        int fromProgression = unitProgression ? unitProgression.GetLevel() : 0;
        return fromAttributes + fromProgression;
    }
}
