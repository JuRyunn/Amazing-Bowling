using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public LayerMask whatIsProp;

    public ParticleSystem explosionParticle;
    public AudioSource explosionAudio;
    public float maxDamage = 100f;
    public float explosionForce = 1000f;
    public float lifeTime = 10f;
    public float explosionRadius = 20f;

    void Start()
    {
        Destroy(gameObject, lifeTime); // 2ÃÊ µÚ¿¡ ÆÄ±«
    }

    private void OnTriggerEnter(Collider other)
    {
        Collider[] coliders = Physics.OverlapSphere(transform.position, explosionRadius, whatIsProp);

        for (int i = 0; i < coliders.Length; i++)
        {
            Rigidbody targetRigidbody = coliders[i].GetComponent<Rigidbody>();

            targetRigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius);

            Prop targetProp = coliders[i].GetComponent<Prop>();

            float damage = CalculateDamage(coliders[i].transform.position);

            targetProp.TakeDamage(damage);
        }

        explosionParticle.transform.parent = null;
        explosionParticle.Play();
        explosionAudio.Play();

        Destroy(explosionParticle.gameObject, explosionParticle.duration);
        Destroy(gameObject);

    }

    private float CalculateDamage(Vector3 targetPosition)
    {
        Vector3 explosionToTarget = targetPosition - transform.position;

        float distance = explosionToTarget.magnitude;
        float edgeToCenterDistance = explosionRadius - distance;
        float percentage = edgeToCenterDistance / explosionRadius;
        float damage = maxDamage * percentage;

        damage = Mathf.Max(0, damage);

        return damage;
    }
}
