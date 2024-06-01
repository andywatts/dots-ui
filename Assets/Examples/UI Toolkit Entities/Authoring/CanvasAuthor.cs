using UnityEngine;
using Unity.Entities;
using UnityEngine.UIElements;

public class CanvasAuthor : MonoBehaviour
{
    public GameObject Prefab;


    class CanvasAuthorBaker : Baker<CanvasAuthor>
    {
        public override void Bake(CanvasAuthor authoring)
        {
            var e = GetEntity(TransformUsageFlags.None);
            AddComponentObject(e, new UI
            {
                Prefab = authoring.Prefab,
            });
        }
    }



}