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
        foreach (Collider collider in colliderArray)
        {
            Debug.Log(collider);
        }
    }

    private void CraftWithCollider(BoxCollider collider)
    {
        Debug.Log("Getting...");
        Bounds bounds = craftingDropPoint.bounds;
        //Collider[] colliders = Physics.OverlapBox(
        //    center: collider.transform.position + (collider.transform.rotation * collider.center),
        //    halfExtents: Vector3.Scale(collider.size * 0.5f, collider.transform.lossyScale),
        //    orientation: collider.transform.rotation,
        //    layerMask: mask
        //);

        Collider[] colliders = Physics.OverlapBox(bounds.center, bounds.size);
        foreach (Collider c in colliders)
        {
            Debug.Log(c);
        }
        print($"{colliders.Length} colliders detected");


        // ...
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
