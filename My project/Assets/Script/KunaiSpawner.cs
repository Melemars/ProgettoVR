using UnityEngine;
using UnityEngine.InputSystem;
public class KunaiSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;
    [SerializeField]
    private Transform firePoint;
    public InputActionReference shootAction;
    void Update()
    {
        if (shootAction.action.WasPressedThisFrame())
        {
            FireProjectile();
        }
    }
    void FireProjectile()
    {
        GameObject newProjectile = Instantiate(projectilePrefab,
        firePoint.position, firePoint.rotation);
    }
}
