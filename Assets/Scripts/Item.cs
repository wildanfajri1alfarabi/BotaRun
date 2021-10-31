using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]                                       // RequireComponent - add component when the script is assigned to an object
public class Item : MonoBehaviour
{
    public enum InteractionType { NONE, PickUp, Examine }                       // List of interaction type
    public InteractionType type;

    public void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;                            // set "is Trigger" to true
        gameObject.layer = 6;                                                   // set game object layer to item layer
    }

    public void Interact()
    {
        switch (type)
        {
            case InteractionType.NONE:
                break;

            case InteractionType.PickUp:
                // Add the object to the PickedUpItems list
                FindObjectOfType<InteractionSystem>().PickUpItem(gameObject);   // Find object in a scene with a specific type
                // Disable the object
                gameObject.SetActive(false);                                    // Make game object inactive
                Debug.Log("PICK UP");
                break;

            case InteractionType.Examine:
                Debug.Log("EXAMINE");
                break;

            default:
                Debug.Log("NULL ITEM");
                break;
        }
    }
}