using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Spells/TestProjectile")]
public class TestProjectile : Spell
{
    public GameObject projectile;
    public float speed;
    public Vector3 distance;
    public override void Cast(GameObject player, GameObject crosshair)
    {
        Transform transform = player.transform;
        Transform crosshairTransform = crosshair.transform;
        Vector3 aimVector = new Vector3(crosshairTransform.position.x - transform.position.x, crosshairTransform.position.y - transform.transform.position.y,0).normalized;
        Debug.Log("Pew Pew");
        Vector3 xDirection = new Vector3(1, 0, 0);
        float rotation = Vector3.Angle(aimVector, xDirection);
        if (aimVector.y < 0)
        {
            rotation = -rotation;
        }
        
        GameObject fireBall = Instantiate(projectile, transform.position + Vector3.Scale(aimVector, distance), Quaternion.Euler(0, 0, rotation));
        // GameObject fireBall = Instantiate(projectile, transform.position + Vector3.Scale(moveVector,distance), Quaternion.Euler(0, 0,rotation));

        fireBall.GetComponent<Rigidbody2D>().velocity = aimVector*speed;
        Debug.Log(rotation);
    }

}
