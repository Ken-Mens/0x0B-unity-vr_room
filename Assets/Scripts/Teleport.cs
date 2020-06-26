using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
  //  public GameObject player;
  //
   // public void PointerClick()
    //{
    //    player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
   // }
    public Transform player;
    public Animator anim;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    public void TeleportMove()
    {
        Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform != null)
            {
               anim.SetTrigger("Blink1");
                player.position = hit.point;
               anim.SetTrigger("Blink2");
            }
        }
    }
}
