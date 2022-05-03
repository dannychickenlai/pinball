using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(MeshCollider))]
public class BumperBounce : MonoBehaviour
{
    [SerializeField] float power = 1f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        foreach(ContactPoint contact in col.contacts) 
        {
            contact.otherCollider.attachedRigidbody.AddForce(-1 * contact.normal * power, ForceMode.Impulse);
        }

        if(anim != null)
        {
            anim.SetTrigger("activate");
        }
    }
}
