using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class InputManager : MonoBehaviour {
    public SteamVR_Input_Sources handType;
    public GameObject laserPrefab; // 1
    private GameObject laser; // 2
    private Transform laserTransform; // 3
    private Vector3 hitPoint; // 4
    public SteamVR_Behaviour_Pose controllerPose;
    public SteamVR_Action_Boolean teleportAction;

    private void ShowLaser(RaycastHit hit)
    {
        // 1
        laser.SetActive(true);
        // 2
        laserTransform.position = Vector3.Lerp(controllerPose.transform.position, hitPoint, .5f);
        // 3
        laserTransform.LookAt(hitPoint);
        // 4
        laserTransform.localScale = new Vector3(laserTransform.localScale.x,
                                                laserTransform.localScale.y,
                                                hit.distance);
    }
    void Update () {

        if (teleportAction.GetState(handType))
        {
            Debug.DrawRay(controllerPose.transform.position, controllerPose.transform.forward);
            RaycastHit hit;
            // 2
            if (Physics.Raycast(controllerPose.transform.position, controllerPose.transform.forward, out hit, 100))
            {
                Debug.Log(hit.collider.name);
                hitPoint = hit.point;
                //ShowLaser(hit);
                if (hit.collider.tag == "Mole")
                {
                    MoleBehavior mole = hit.collider.gameObject.GetComponent<MoleBehavior>();
                    mole.SwitchCollider(0);
                    mole.anim.SetTrigger("hit");
                }
            }
        }
        else // 3
        {
            //laser.SetActive(false);
        }
    }


}
