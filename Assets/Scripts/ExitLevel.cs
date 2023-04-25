using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitLevel : MonoBehaviour
{
    public float interactDistance = 5f;
    public KeyCode interactKey = KeyCode.E; 
    public GameObject exitObject; 
    public novietotScript script;

    private void Update()
    {
        if (Input.GetKeyDown(interactKey) && IsLookingAtObject() && script.score >= 10)
        {
            pamest();
        }
    }

    private bool IsLookingAtObject()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, interactDistance))
        {
            if (hit.collider.gameObject == exitObject)
            {
                return true;
            }
        }
        return false;
    }

    private void pamest()
    {
        
        SceneManager.LoadScene(1);
        
    }
}
