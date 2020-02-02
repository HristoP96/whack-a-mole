using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour {

    Collider col;

    private void Start(){
        col = GetComponent<Collider>();

        col.enabled = false;
    }

    public void DestroyObj() {
        Destroy(gameObject);
    }

    public void SwitchCollider(int num) {
        col.enabled = (num == 0) ? false : true;
    }
}
