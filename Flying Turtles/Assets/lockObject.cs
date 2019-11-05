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
		
		
		if(key.reach < reach)
			return false;
		if(key.sharp < sharp)
			return false;
		if(key.flame < flame)
			return false;
		if(key.wood < wood)
			return false;
		if(key.power < power)
			return false;
		
		return true;
		
		
		
		
		
	}
	

}
