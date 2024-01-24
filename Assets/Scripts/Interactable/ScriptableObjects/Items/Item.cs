using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;


public enum ItemType
{
    Food,
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
public class Item : MonoBehaviour
{
    [Header("Only gameplay")]
    public ItemType type;
    public ElementType element;
    public CraftMaterialType material;
    public string attribute;
}
