using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Element", menuName = "ScriptableObjects/Element", order = 1)]
public class Element : ScriptableObject
{
    public Element Parent;
    public int Health = 0;
    public GameObject ItemToDrop = null;
    public int NumberOfItemsToDrop = 0;


    private void OnEnable()
    {
        if (Parent == null) return;
        if (Health == 0) Health = Parent.Health;
        if (ItemToDrop == null) ItemToDrop = Parent.ItemToDrop;
        if (NumberOfItemsToDrop == 0) NumberOfItemsToDrop = Parent.NumberOfItemsToDrop;
    }
}


