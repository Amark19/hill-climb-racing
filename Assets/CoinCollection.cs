using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollection : MonoBehaviour
{
    public int coin_value=0;
    public Text coinCollectedText;
    
   private void OnTriggerEnter2D(Collider2D other) {
       
           CoinCount.TotalCoinCount+=coin_value;
       coinCollectedText.text="" + CoinCount.TotalCoinCount.ToString();
       this.gameObject.SetActive(false);
   }
        // Debug.Log(other.gameObject.name);
        // for(int i=0;i<3;i++){
        //     if(other.gameObject.name==Coinset.transform.GetChild(i).gameObject.name){
        //         Coinset.transform.GetChild(i).gameObject.SetActive(false);
        //     }
        // }
}
