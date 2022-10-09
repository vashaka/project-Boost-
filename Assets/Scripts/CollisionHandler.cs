using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch(other.gameObject.tag)
        {
            case "Friendly": 
                Debug.Log("This thing is Friendly!");
                break;
            case "Finish": 
                Debug.Log("Congtrats, You Finished!");
                break;
            default: 
                Debug.Log("You blew up!");
                break;
        }
    }
}
