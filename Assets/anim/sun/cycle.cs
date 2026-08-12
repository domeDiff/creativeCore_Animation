using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cycle : MonoBehaviour
{
    public Animator anim2;

    private void OnTriggerEnter(Collider other)
    {
        anim2.SetTrigger("cycle");
    }

    private void OnTriggerExit(Collider other)
    {
        anim2.SetTrigger("cycle");
    }
}
