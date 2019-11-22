using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockObject : MonoBehaviour
{
	const int PARAM_LENGTH = 5;
    public int reach;
    public int sharp;
    public int bright;
    public int flat;
    public int flame;
    public int blunt;
    public int buoyant;
    public int power;
    public int climb;
    public int heavy;
    public int dexterous;
    public string message = "default";
	public string useSuccsess = "default";
	public string useFail = "default";
	

	
	public lockObject(){
        reach = 0;
        sharp = 0;
        bright = 0;
        flat = 0;
        flame = 0;
        buoyant = 0;
        power = 0;
        climb = 0;
        heavy = 0;
        dexterous = 0;
    }
	

	
	
	public bool validate(keyObject key){
		
		
		if(key.reach < reach)
			return false;
		if(key.sharp < sharp)
			return false;
        if(key.bright < bright)
            return false;
        if (key.flat < flat)
            return false;
        if (key.flame < flame)
			return false;
		if(key.buoyant < buoyant)
			return false;
		if(key.power < power)
			return false;
        if(key.climb < climb)
            return false;
        if (key.heavy < heavy)
            return false;
        if (key.dexterous < dexterous)
            return false;

        return true;
		
		
		
		
		
	}
	

}
