using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Planets
{
    a,
    b,
    c
}

[CreateAssetMenu(fileName = "NewPlanetData", menuName = "Custom/Planet Data")]
public class PlanetData : ScriptableObject
{
    [SerializeField] public PlanetId[] PlanetIds;
}

[Serializable]
public class PlanetId
{
    public Planets Planets;
    [SerializeField] public List<ThirdList> PlanetInfo = new List<ThirdList>();  
//    public Dictionary<string, string> PlanetInfo  = new Dictionary<string, string>();

} 

[System.Serializable]
public class ThirdList
{
    public List<string> thirdList;
}
