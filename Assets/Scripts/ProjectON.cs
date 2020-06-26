using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectON : MonoBehaviour
{
    public GameObject particles;
    public Transform playerpos;

    // Start is called before the first frame update
    public void Interact()
    {
        if (IsRange())
        {
            ParticlesON();
        }
        
    }

    bool IsRange()
    {
        float dist = Vector3.Distance(playerpos.position, transform.position);
        if (dist <= 2f)
        {
            return (true);
        }
        return (false);
    }

  public void ParticlesON()
    {
        if (particles.activeInHierarchy == false)
        {
            particles.SetActive(true);
        }
    }
}
