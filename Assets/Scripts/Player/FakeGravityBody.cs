using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGravityBody : MonoBehaviour {

    
    public FakeGravity FakeMain;
    public FakeGravity FakeMetal;
    public FakeGravity FakeTech;
    public FakeGravity FakeFood;
    public FakeGravity FakeFuel;

    public int gravitychoice = 1;

    private Transform myTransform;

	void Start () {
        myTransform = transform;
	}
	
	void Update () {
        if (gravitychoice == 1)
        {
            FakeMain.Attract(myTransform);
        } else if (gravitychoice == 2)
        {
            FakeMetal.Attract(myTransform);
        } else if (gravitychoice == 3)
        {
            FakeFuel.Attract(myTransform);
        } else if (gravitychoice == 4)
        {
            FakeTech.Attract(myTransform);
        } else if (gravitychoice == 5)
        {
            FakeFood.Attract(myTransform);
        }

    }
}
