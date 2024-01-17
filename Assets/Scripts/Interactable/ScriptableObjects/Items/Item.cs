using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;


public enum ItemType
{
    Consumable,
    CraftingMaterial,
    Tool
}

public enum CraftMaterialType
{
    Plant,
    Stone,
    Liquid,
    Metal,
    Animal
}

public enum ElementType
{
    Wind,
    Earth,
    Water,
    Fire
}

[CreateAssetMenu(menuName = "ScriptableObjects/Items")]
public class Item : ScriptableObject
{
    public ItemType type;
    public ElementType element;
    public CraftMaterialType material;
    public string attribute;
}
