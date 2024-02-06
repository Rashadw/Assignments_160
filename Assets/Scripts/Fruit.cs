using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit // make this my own class remove 
{
    // start and update don't wor without mono

    public string name;
    public string color;
    public float weight;


    /// <summary>
    /// construtor for fruit class that takes 3 parmeter
    /// </summary>
    /// <param name="name">name of fruit</param>
    /// <param name="c"> color of fruit</param>
    /// <param name="w"> weight of fruit</param>
    public Fruit(string name, string c, float w) // constutor for class 
    {
        this.name = name;
        color = c;
        weight = w;

    }
    /// <summary>
    /// constrtor of fruit class no parameters 
    /// </summary>
    public Fruit() 
    {
        name = "banana";
        color = " blue";
        weight = 3.7f;
    }

    /// <summary>
    /// construtor for fruit class that takes 1 parmeter
    /// </summary>
    /// <param name="name">name of fruit</param>
    public Fruit(string name)
    {
        this.name = name;
        color = "red";
        weight = 1.0f;
    }

    /// <summary>
    /// construtor for fruit class that takes 1 parmeter
    /// </summary>
    /// <param name="weight">weight of fruit</</param>
    public Fruit(float weight)
    {
        name = "watermelon";
        color = "white";
        this.weight = weight;
        
    }

    ~Fruit()
    {
        //wrie to defult
        name = "";
        color = " blue";
        weight = 3.7f;
    }
}
