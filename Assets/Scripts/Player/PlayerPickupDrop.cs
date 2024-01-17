using UnityEngine;
public class PlayerPickupDrop : MonoBehaviour
{

    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickupLayerMask;
    [SerializeField] private Transform grabPoint;

    private GrabbableObject grabbableObject;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (grabbableObject == null) // this means it is not carrying an object.
            {
                float pickupDistance = 2f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickupDistance))
                {
                    Debug.Log("RAYCAST HIT");

                    // check to see if this is a grabbable object
                    if (raycastHit.transform.TryGetComponent(out grabbableObject))
                    {
                        grabbableObject.Grab(grabPoint.transform);
                        //Debug.Log(grabbableObject);
                    }
                }
            }
            else // drops the grabbable object if alreayd holding it.
            {
                Debug.Log("DROP OBJECT");
                grabbableObject.Drop();
                grabbableObject = null;
            }
        }
    }
}
