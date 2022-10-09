using UnityEngine;
using UnityEngine.SceneManagement;

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
                ReloadLevel();
                break;
        }
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
