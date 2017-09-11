using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyNumberGenerator : NumberGenerator {

	void start(){
		
		Random.InitState(System.DateTime.Now.DayOfYear);
	}

}
