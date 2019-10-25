using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockObject : MonoBehaviour
{
	const int PARAM_LENGTH = 5;
	public int reach;
	public int sharp;
	public int flame;
	public int wood;
	public int power;

	

	
	public lockObject(){
		reach = 0;
		sharp = 0;
		flame = 0;
		wood = 0;
		power = 0;
	
	
		
		
	}
	
	public bool validate(keyObject key){
		
		bool result = true;
		
		if(key.reach < reach)
			result = false;
		if(key.sharp < sharp)
			result = false;
		if(key.flame < flame)
			result = false;
		if(key.wood < wood)
			result = false;
		if(key.power < power)
			result = false;
		
		return result;
		
		
		
	}
	

}
