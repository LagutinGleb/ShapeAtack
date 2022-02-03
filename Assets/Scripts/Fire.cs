using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float BulletVelocity;
    private float lookspeed = 10f;
    public GameObject player;
    Transform PlayerTransform;

    private void Start()
    {
        PlayerTransform = player.GetComponent<Transform>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LookOnCursor();
            GameObject newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletVelocity;
        }
    }


    void LookOnCursor()
    {
        Plane playerPlane = new Plane(Vector3.up, PlayerTransform.transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist = 0;
        if (playerPlane.Raycast(ray, out hitdist))
        {
            Vector3 targetPoint = ray.GetPoint(hitdist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            //PlayerTransform.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, lookspeed * Time.deltaTime);
              PlayerTransform.transform.rotation = targetRotation;
        }
    }
}
