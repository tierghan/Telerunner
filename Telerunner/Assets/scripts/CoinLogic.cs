using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    public int collectCoin()
    {
        Debug.Log("Coin collected");
        Destroy(this.gameObject);
        return 1;
    }
}
