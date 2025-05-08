using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrigger : MonoBehaviour
{
    public GameObject holdPoint;
    private GameObject _nearbyObject;
    private GameObject _heldObject;

    // Update is called once per frame
    private void Awake()
    {
        //holdPoint = GetComponentInChildren<GameObject>(); Não Funcionou (?)
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_heldObject == null && _nearbyObject != null)
            {
                Pickup(_nearbyObject);
            }
            else if (_heldObject != null)
            {
                Drop();
            }
        }
    }

    void Pickup(GameObject obj)
    {
        _heldObject = obj;
        Rigidbody rigidbody = obj.GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;
        _nearbyObject.transform.SetParent(holdPoint.transform);
        _heldObject.transform.localPosition = Vector3.zero;
    }

    void Drop()
    {
        Rigidbody rigidbody = _heldObject.GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;
        _heldObject?.transform.SetParent(null);
        _heldObject = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup") && _heldObject == null)
        {
            _nearbyObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == _nearbyObject)
        {
            _nearbyObject = null;
        }
    }
}
