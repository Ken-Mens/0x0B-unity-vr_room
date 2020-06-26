using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    public Transform player;
    public Transform pocket;
    private Camera main;

    public void Interact()
    {
        if (InRange())
        {
            Debug.Log("In Range");
            if (pocket.childCount == 0)
                ObjectPickup();
            else
                ObjectSwap();
        }
        else
        {
            Debug.Log("Not In Range");
        }
    }

    bool InRange()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 3f)
        {
            return (true);
        }
        return (false);
    }

    void ObjectPickup()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        transform.position = pocket.position;
        transform.parent = GameObject.Find("Pocket").transform;
    }

    void ObjectSwap()
    {
        Transform dropping = pocket.GetChild(0);
        dropping.position = transform.position;
        dropping.parent = null;
        ObjectPickup();
        dropping.GetComponent<Rigidbody>().isKinematic = false;
    }
}