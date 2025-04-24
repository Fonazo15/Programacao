using UnityEngine;

public class PickupTrigger : MonoBehaviour
{
    public Transform holdPoint;
    public KeyCode pickupKey = KeyCode.E;

    private GameObject nearbyObject = null;
    private GameObject heldObject = null;

    void Update()
    {
        if (Input.GetKeyDown(pickupKey))
        {
            if (heldObject == null && nearbyObject != null)
            {
                PickupObject(nearbyObject);
            }
            else if (heldObject != null)
            {
                DropObject();
            }
        }
    }

    void PickupObject(GameObject obj)
    {
        heldObject = obj;
        Rigidbody rb = heldObject.GetComponent<Rigidbody>();
        rb.isKinematic = true;
        heldObject.transform.SetParent(holdPoint);
        heldObject.transform.localPosition = Vector3.zero;
    }

    void DropObject()
    {
        Rigidbody rb = heldObject.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        heldObject.transform.SetParent(null);
        heldObject = null;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup") && heldObject == null)
        {
            nearbyObject = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == nearbyObject)
        {
            nearbyObject = null;
        }
    }
}
