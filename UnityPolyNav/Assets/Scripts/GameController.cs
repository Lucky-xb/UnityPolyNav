using PolyNav;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private PolyNavAgent _agent;
    [SerializeField]
    private Camera _camera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 touchDownPos = Input.mousePosition;
            Vector2 worldPos = _camera.ScreenToWorldPoint(touchDownPos);
            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);
            if (hit.collider != null)
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
}
