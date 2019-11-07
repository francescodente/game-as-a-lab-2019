using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void TakeHit(int damage, Collision collision);

    void TakeDamage(int damage);
}
