using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClontroller : MonoBehaviour
{
    [SerializeReference] Animator door;
private void OnTriggerEnter(Collider other)
{
        if(other.CompareTag("Player")){
            print("Open door!");
            door.SetBool("IsOpen", true);
        }
}

/// <summary>
/// OnTriggerExit is called when the Collider other has stopped touching the trigger.
/// </summary>
/// <param name="other">The other Collider involved in this collision.</param>
private void OnTriggerExit(Collider other)
{
        if(other.CompareTag("Player")){
         print("Close door!");
         door.SetBool("IsOpen", false);
        }

}


}
