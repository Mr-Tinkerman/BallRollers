using UnityEngine;

public class CoinItem : MonoBehaviour
{
    public int coinValue = 1;
    private SaveManager sm;

    void Awake() 
    {
        sm = GameObject.FindObjectOfType<SaveManager>();
    }

    void OnTriggerEnter()
    {
        sm.AddCoins(coinValue);
        sm.Save();

        Destroy(this.gameObject);
    }
}