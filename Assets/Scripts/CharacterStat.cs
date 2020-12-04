public class CharacterStat
{
    public float BaseValue { get; private set; }
    public float CurrentValue { get; private set; }
    public float MinValue { get; private set; }
    public float MaxValue { get; private set; }

    public CharacterStat (float baseValue, float currentValue, float minValue, float maxValue)
    {
        BaseValue = baseValue;
        CurrentValue = currentValue;
        MinValue = minValue;
        MaxValue = maxValue;
    }

    public CharacterStat(float baseValue)
    {
        BaseValue = baseValue;
        CurrentValue = baseValue;
        MinValue = 0;
        MaxValue = baseValue;
    }

    public void ModifyCurrentValue(float newVal)
    {
        CurrentValue = newVal;
    }
}   