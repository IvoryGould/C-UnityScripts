using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastIntact : MonoBehaviour
{

    RaycastHit hit;
    float range = 2;

    public Text interactText;

    // float nextFire;
    //float fireRate = 0.3f;

    void Start(){
        interactText.enabled = false;
    }


    void Update() {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 2;
        Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(transform.position, forward, out hit, range)){
            if (hit.collider.tag == "Chest"){
                print(hit.transform.name);
                interactText.enabled = true;
            }
        } else {
            interactText.enabled = false;
        }
    }
}
