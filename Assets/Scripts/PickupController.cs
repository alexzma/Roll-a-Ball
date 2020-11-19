using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        PickupsDisplayController pickupsDisplayController = FindObjectOfType<PickupsDisplayController>();
        if (other.CompareTag("Player")){
            pickupsDisplayController.current = pickupsDisplayController.current + 1;
            Destroy(this.gameObject);
        }
    }

}
