using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableItem : MonoBehaviour {

    public Sprite None;
    public Sprite Empty;
    public Sprite Hard;
    public Sprite Health;
    public Sprite Points;
    public Sprite Special;

    public enum Type
    {
        NONE,
        EMPTY,
        HARD,
        HEALTH,
        POINTS,
        SPECIAL
    }

    private SpriteRenderer sprite;
    private Type type;

    public bool destroyed = false;

	void Start()
    {
        type = Type.NONE;
        sprite = GetComponent<SpriteRenderer>();
	}

    public void PoolGenerate(Type t)
    {
        type = t;
        destroyed = false;

        switch (type)
        {
            case Type.NONE:
                sprite.sprite = None;
                break;
            case Type.EMPTY:
                sprite.sprite = Empty;
                break;
            case Type.HARD:
                sprite.sprite = Hard;
                break;
            case Type.HEALTH:
                sprite.sprite = Health;
                break;
            case Type.POINTS:
                sprite.sprite = Points;
                break;
            case Type.SPECIAL:
                sprite.sprite = Special;
                break;
            default:
                sprite.sprite = None;
                type = Type.NONE;
                break;
        }
    }

    public Type PoolReturn()
    {
        sprite.sprite = None;
        return type;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !destroyed)
        {
            sprite.sprite = None;
            //RUN function associated with type
        }
    }
}
