using UnityEngine;
using UnityEngine.UI;

public class Disappear : MonoBehaviour
{

    public int coint;
    public int coinValue;
    public Text cointText;
    //private CountText countCoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
            coint += coinValue;
            cointText.text = "Coins: " + coint;
            Debug.Log("coin: "+coinValue);
            Destroy(gameObject);
            
        }
    }
    
}
