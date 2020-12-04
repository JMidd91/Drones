using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStatValue : MonoBehaviour
{
    public enum StatType
    {
        Energy,
        HP
    }

    public StatType statType = StatType.Energy;
    public float statValue = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<CharacterStats>() != null)
        {
            CharacterStats stats = collider.gameObject.GetComponent<CharacterStats>();

            if(statType == StatType.Energy)
            {
                stats.energy.ModifyCurrentValue(statValue);
            }            
        }
    }
}
