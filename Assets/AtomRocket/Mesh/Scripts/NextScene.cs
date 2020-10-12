using UnityEngine;

public class NextScene : MonoBehaviour
{
    public GameObject completeLevelUI;

    private void Start()
    {
        completeLevelUI.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        CompleteLevel();
        Debug.Log("frue");
    }
    public void CompleteLevel()
    {
         completeLevelUI.SetActive(true);
        
    }
    
}
