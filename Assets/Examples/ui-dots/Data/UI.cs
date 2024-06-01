using System;
using Unity.Entities;
using Unity.UI;
using UnityEngine;
using UnityEngine.UIElements;

class UI : IComponentData, IEquatable<UI>
{
    public GameObject Prefab;
    public GameObject GO;
    public UIDocument Document;

    public override int GetHashCode() => GO.GetHashCode();

    public bool Equals(UI other)
        => GetHashCode() == other?.GetHashCode()
        && Equals(GO, other.GO);
}