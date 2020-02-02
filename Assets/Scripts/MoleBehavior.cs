using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehavior : MonoBehaviour {

    Collider col;

    public int hitPoints = 1;
    [HideInInspector]public GameObject myParent;
    [HideInInspector]public Animator anim;
    private void Start(){
   
        anim = GetComponent<Animator>();
        col = GetComponent<Collider>();

        col.enabled = false;
    }

    public void DestroyObj() {

        myParent.GetComponent<HoleBehavior>().hasMole = false;
        Destroy(gameObject);
    }

    public void GotHit()
    {
        // Points go here

        this.hitPoints--;

        if (this.hitPoints > 0)
        {
            col.enabled = true;
        } else
        {
            myParent.GetComponent<HoleBehavior>().hasMole = false;
            Destroy(gameObject);
        }
    }

    public void SwitchCollider(int num) {
        col.enabled = (num == 0) ? false : true;
    }
}
