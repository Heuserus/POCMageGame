using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Spells/Pebblegun")]
public class Pebblegun : Spell
{
    public GameObject projectile;
    public float speed;
    public Vector3 distance;
    public int firerate;
    public override void Cast(GameObject player, GameObject crosshair)
    {
        Transform transform = player.transform.GetChild(2).gameObject.transform;
        Transform crosshairTransform = crosshair.transform;
        Vector3 aimVector = new Vector3(crosshairTransform.position.x - transform.position.x, crosshairTransform.position.y - transform.transform.position.y- 0).normalized;
        Debug.Log("Pebblegun");
      
        GameObject fireBall = Instantiate(projectile, transform.position + Vector3.Scale(aimVector, distance), Quaternion.Euler(0, 0, Mathf.Atan2(aimVector.y, aimVector.x) * Mathf.Rad2Deg));
        fireBall.GetComponent<Rigidbody2D>().velocity = aimVector * speed;
        Destroy(fireBall, 3.0f);
    }

}
