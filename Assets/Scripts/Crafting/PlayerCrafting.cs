using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This class is mean to be added as a component on the player game object
public class PlayerCrafting : MonoBehaviour
{

    [SerializeField] private LayerMask interactLayerMask;
    [SerializeField] private Transform playerCameraTransform;
     
    // Update is called once per frame
  
    void OnCollisionEnter(Collision collision)
    {
        Debug.DrawRay(collision.contacts[0].point, collision.contacts[0].normal, Color.green, 2, false);
    }
    private void Update()
    {
        Debug.DrawRay(playerCameraTransform.position, playerCameraTransform.forward, Color.green);
        Debug.DrawLine(playerCameraTransform.position, playerCameraTransform.forward, Color.blue, 10f);
        if (Input.GetKeyUp(KeyCode.E) || Input.GetMouseButtonDown(0))
        {
            float interactDistance = 7f;
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, interactDistance))
            {
                Debug.Log(raycastHit);
                Debug.Log(raycastHit.collider.gameObject);
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
