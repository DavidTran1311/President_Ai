using System;
using System.Collections.Generic;
using UnityEngine;

public class Memory : MonoBehaviour
{
    public static string[] Suits = new string[] { "Club", "Diamond", "Spades", "Heart" };
    public static string[] Ranks = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    public Sprite[] Cards;

    public List<string> deck;

    // Start is called before the first frame update
    void Start()
    {
        PlayCards();
       
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void PlayCards()
    {

        deck = GenenrateDeck();
        Shuffle(deck);

        foreach (string card in deck)
        {
            print(card);
        }
    }

    public static List<string> GenenrateDeck()
    {
        List<string> newDeck = new List<string>();
        foreach (string s in Suits)
        {

            foreach (string v in Ranks)
            {

                newDeck.Add(s + v);
            }


        }

  

        return newDeck;
  }

    void Shuffle<Temp>(List<Temp> list)
    {

        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {

            int k = random.Next(n);
            n--;
            Temp temp = list[k];
            list[k] = list[n];
            list[n] = temp;

        }

    }
}
