using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This class is mean to be added as a component on the player game object
public class PlayerCrafting : MonoBehaviour
{

    [SerializeField] private LayerMask interactLayerMask;
    [SerializeField] private Transform playerCameraTransform;
     
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.E) || Input.GetMouseButtonDown(0))
        {
            float interactDistance = 3f;
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, interactDistance))
            {
                if (raycastHit.transform.TryGetComponent(out CraftingTable craftingTable))
                {
                    // interacts with crafting table
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        // do some other functionality here that is not crafting...
                    }
                    if (Input.GetMouseButtonDown(0))
                    {
                        craftingTable.Craft();
                    }
                }
            }
        }
    }
}
