using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehavior : MonoBehaviour {

    Collider col;

    [HideInInspector]public Animator anim;
    private void Start(){
   
        anim = GetComponent<Animator>();
        col = GetComponent<Collider>();

        col.enabled = false;
    }

    public void DestroyObj() {
        Destroy(gameObject);
    }

    public void GotHit()
    {
        // Points go here
        Destroy(gameObject);
    }

    public void SwitchCollider(int num) {
        col.enabled = (num == 0) ? false : true;
    }
}
