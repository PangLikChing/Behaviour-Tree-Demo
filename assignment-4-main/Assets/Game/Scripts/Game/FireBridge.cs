using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBridge : MonoBehaviour
{
    bool canDealDamage = true;
    float damageTimer = 0.0f;

    [SerializeField] int fireDamage = 1;
    [SerializeField] float damageCooldown = 1.0f;

    void Update()
    {
        // If the damageTimer is larger than that of the damageCooldown
        if (damageTimer >= damageCooldown)
        {
            // Set canDealDamage to true
            canDealDamage = true;
            // Reset damage timer
            damageTimer = 0.0f;
        }
        else
        {
            // Set canDealDamage to false
            canDealDamage = false;

            // Increament damageTimer
            damageTimer += Time.deltaTime;
        }
    }

    void OnTriggerStay(Collider other)
    {
        // If the gameObject collided with the fire bridge is a castle guard
        if (other.GetComponent<CastleGuard>() != null)
        {
            // If the fire bridge damage comes off cooldown
            if (canDealDamage)
            {
                // Deal damage to the castle guard
                other.GetComponent<CastleGuard>().TakeDamage(fireDamage);
            }
        }
    }
}
