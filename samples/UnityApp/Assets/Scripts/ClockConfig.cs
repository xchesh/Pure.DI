using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ClockConfig", menuName = "Clock/Config")]
public class ClockConfig : ScriptableObject, IClockConfig
{
    [SerializeField] int offsetHours;

    public TimeSpan Offset => TimeSpan.FromHours(offsetHours);
}