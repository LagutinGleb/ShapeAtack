using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float BulletVelocity;
    public GameObject player;
    Transform PlayerTransform;
    AudioSource sound;

    private void Start()
    {
        PlayerTransform = player.GetComponent<Transform>();
        sound = GetComponent<AudioSource>();
    }

    void Update() //поворачиваем игрока в сторону тапа, делаем пулю из префаба, стреляем вперед
    {
        if (Input.GetMouseButtonDown(0))
        {
            LookOnCursor();
            GameObject newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletVelocity;
            sound.Play();
        }
    }

    void LookOnCursor() //поворот игрока в сторону тапа
    {
        Plane playerPlane = new Plane(Vector3.up, PlayerTransform.transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist;
        if (playerPlane.Raycast(ray, out hitdist))
        {
            Vector3 targetPoint = ray.GetPoint(hitdist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            PlayerTransform.transform.rotation = targetRotation;
        }
    }
}
