using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> fruitList; // create list of fruit

    // Start is called before the first frame update
    void Start()
    {
        fruitList = new List<Fruit>(); // defining list of fruit
        
        Fruit apple = new Fruit( "apple", "green", 1.2f);
        fruitList.Add(apple); // adds apple to list 

        CreateFruitList();
        DisplayFruitList();
    }

    private void DisplayFruitList()
    {
        for(int i = 0; i < fruitList.Count; i++)
        {
            print(fruitList[i].color + " " + fruitList[i].name + "weights" + fruitList[i].weight + "units");
        }
    }

    private void CreateFruitList()
    {
        fruitList.Add(new Fruit());

        fruitList.Add(new Fruit("strawberry"));

        fruitList.Add(new Fruit(7.8f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
