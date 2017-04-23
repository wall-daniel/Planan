using UnityEngine;

public class FakeGravity : MonoBehaviour
{
    
    public float maxGravity = -100f;
    public float maxGravDist = 10f;

    GameObject[] planets;

    void Start()
    {
        
        planets = GameObject.FindGameObjectsWithTag("Planet");
    }

    public void Attract(Transform body)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;
        Vector3 bodyUp = body.up;
        GetComponent<Rigidbody2D>().AddForce(gravityUp * maxGravity);

        Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;
        body.rotation = Quaternion.Slerp(body.rotation, targetRotation,50*Time.deltaTime);
        
       
    }


    void FixedUpdate()
    {
        foreach (GameObject planets in planets)
        {
            Transform transformnull = transform;
            float dist = Vector3.Distance(planets.transform.position, transformnull.position);
            if (dist <= maxGravDist)
            {
                Vector3 v = planets.transform.position - transform.position;
                GetComponent<Rigidbody2D>().AddForce(-v.normalized * (1.0f - dist / maxGravDist) * maxGravity);
            }
       }
        
    }
}
