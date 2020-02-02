using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "Mole")
                {
                    MoleBehavior mole = hit.collider.gameObject.GetComponent<MoleBehavior>();
                    mole.SwitchCollider(0);
                    mole.anim.SetTrigger("hit");
                }
            }
        }
	}
}
