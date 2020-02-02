using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehavior : MonoBehaviour {


    public GameObject[] moles;
    public bool hasMole;

    // Use this for initialization
    void Start () {
        if(!hasMole)
        {
            Invoke("Spawn", Random.Range(0f, 7f));

        }
    }

    void Spawn()
    {
        if (!hasMole)
        {
            int num = Random.Range(0, moles.Length);

            GameObject mole = Instantiate(moles[num], transform.position, Quaternion.identity) as GameObject;

            mole.GetComponent<MoleBehavior>().myParent = gameObject;
            hasMole = true;
        }

        Invoke("Spawn", Random.Range(0f, 7f));

    }
}
