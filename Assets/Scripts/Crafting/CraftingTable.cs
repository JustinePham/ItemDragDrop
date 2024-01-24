using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CraftingTable : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] BoxCollider craftingDropPoint;
    [SerializeField] LayerMask mask;

    public void Craft()
    {
        Debug.Log("craft");
        // grab colliders 
        Collider[] colliderArray = Physics.OverlapBox(
            craftingDropPoint.transform.position + craftingDropPoint.center,
            craftingDropPoint.size,
            craftingDropPoint.transform.rotation
        );
        //Debug.Log("transform.position: " + transform.position);
        //Debug.Log("craftingDropPoint.transform.position: " + craftingDropPoint.transform.position);
        // Debug.Log("craftingDropPoint.center: " + craftingDropPoint.center);
        // Debug.Log("craftingDropPoint.size " + craftingDropPoint.size);
        //Debug.Log("craftingDropPoint.transform.rotation " + craftingDropPoint.transform.rotation);

        //   CraftWithCollider(craftingDropPoint);
        //    Debug.Log("craftingdroppioint: " + craftingDropPoint.center);

        //Scene scene = SceneManager.GetActiveScene();
        //GameObject[] g = scene.GetRootGameObjects();
        // Debug.Log("scene: " + scene.name);
        // Debug.Log("gameobs: " + g);
        //foreach (GameObject obj in g)
        //{
        //    if(obj.name == "Food_06" )
        //    {
        //        Debug.Log(obj.name);
        //        Debug.Log("obj.transform.position" + obj.transform.position);
        //        Debug.Log("obj.transform.position - stuff" + (obj.transform.position - craftingDropPoint.transform.position - craftingDropPoint.center));
        //    }
        //}
        //List<Item> inputItems = new List<Item>(new FoodRecipeSO().ingredients);


        // Check for all food ingredients 
        // need more than one food item to perform recipe
        var ingredients = new List<GameObject>();
        foreach (Collider collider in colliderArray)
        {
           

            if (collider.TryGetComponent(out Item ingredient))
            {
                if (ingredient.type == ItemType.Consumable || ingredient.type == ItemType.Food)
                {
                    ingredients.Add(collider.gameObject);
                    Debug.Log(collider);
                }
            }
        }

        // get the food recipe object. 
        if (ingredients.Count > 1 )
        {
            Debug.Log("YES");
            // has more than one ingredient,
            // destroy the ingredients
            // instantiate food dish
        }
        else
        {
            Debug.Log("NO");
            // do not destroy items,
            // dont instantiate food dish
            // trigger error message? 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
