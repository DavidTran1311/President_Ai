using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory : MonoBehaviour
{
    string[] KCardSuits = new string[] { "Club", "Diamond", "Spades", "Heart" };
    string[] KCardRanks = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

    static public Memory instance;

    public Card[] cards;
    public Card select;
   

    
    // Start is called before the first frame update
    void Start()
    {
       
        instance = this;

        cards = transform.GetComponentInChildren<cards>();
        int n = 0;
       
       // Shuffle(Cards);
         
        for (int m=0;m<cards.Length/2;m++ )
        {
            string suit = GetRandomFromArray(KCardSuits);
            string rank = GetRandomFromArray(KCardRanks);

            cards[n++].SetSuitAndRank(suit, rank);
            cards[n++].SetSuitAndRank(suit, rank);

        }

    }

    private void Shuffle<T>(T[] array) {

        int n = array.Length;
        while (n > 1) {

            int k = (int)Mathf.Floor(Random.value * (n--));
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    
    
    }

    private T GetRandomFromArray<T>(T[] array) {
        return array[(int)Mathf.Floor(Random.value * array.Length)];
    
    }


   private void rankandsuit() { 
    //set rank and suit
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
