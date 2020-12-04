using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    // stats
    public float baseEnergy = 10;
    public CharacterStat energy;

    // public vars purely for visual debuging
    public float currentEnergy;

    private Vector3 lastPosition;
    private NavMeshAgentScript nav;
    private Transform closestItemGroup;

    void Start()
    {
        nav = GetComponent<NavMeshAgentScript>();
        energy = new CharacterStat(baseEnergy);
    }

    void Update()
    {
        CalculateEnergy();
        currentEnergy = energy.CurrentValue;
    }

    void CalculateEnergy()
    {
        energy.ModifyCurrentValue(energy.CurrentValue - Vector3.Distance(transform.position, lastPosition));
        lastPosition = transform.position;

        if (energy.CurrentValue <= 0)
        {
            nav.SetNewDestination(GetClosestItem("Pickups_Energy"));
        }
    }

    Vector3 GetClosestItem(string itemName)
    {
        closestItemGroup = GameObject.Find(itemName).transform;

        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (Transform potentialTarget in closestItemGroup)
        {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
            }
        }

        return bestTarget.position;
    }
}