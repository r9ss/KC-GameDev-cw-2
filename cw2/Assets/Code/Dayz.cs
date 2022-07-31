using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dayz : MonoBehaviour
{
    //Hero info
    string heroName = "Saud";
    int heroHeight = 3;
    string HeroSuperPower = "super speed";
    int heroAge = 21;
    //Vilian age
    string villianName = "Faisal";
    int villianHeight = 4;
    int villianAge = 25;
    string villianSuperPower = "super strength";

    void Start()
    { 
        int ageDiffrence = villianAge - heroAge;

print("Our hero's name is " + heroName + " and he used to be " + heroHeight + " feet tall but now he's " + (heroHeight = 3 + 5) + " Feet tall." );

print("They say his super power is " + HeroSuperPower + " and he's " + heroAge + " Years old");

print("And the villian " + villianName + " is " + villianHeight + 
" Feet tall and his super power is " + villianSuperPower );

 villianSuperPower = "None";

print(villianName + " lost his super powers fighting " + heroName + " so now his super powers are: " + villianSuperPower);

print("The age diffrence between them is " + ageDiffrence + " years.");
        
    }


}
   
