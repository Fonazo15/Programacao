using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableTrigger : MonoBehaviour
{
    public Transform holdPoint;

    private GameObject _nearObject;
    private GameObject _heldObject;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_heldObject == null && _nearObject != null)
            {
                PickUp(_nearObject);
            }
            else if (_heldObject != null)
            {
                Drop();
            }
        }
    }

    void PickUp(GameObject obj)
    {
        _heldObject = obj;
        Rigidbody rigidbody = obj.GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;
        _nearObject.transform.SetParent(holdPoint);
        _heldObject.transform.localPosition = Vector3.zero;
    }

    void Drop()
    {
        Rigidbody rigidbody = _heldObject.GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;
        _nearObject.transform.SetParent(null);
        _heldObject = null;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp") && _heldObject == null)
        {
            _nearObject = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            _nearObject = null;
        }
    }
}
