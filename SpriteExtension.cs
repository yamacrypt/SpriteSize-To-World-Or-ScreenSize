using UnityEngine;

public static class SpriteExtension{
    public static Vector2 GetSpriteScreenSize(SpriteRenderer sr,Camera camera=null){
        var _camera=camera;
        if(_camera==null){
            _camera=Camera.main;
        }
        var globalSize = GetSpriteWorldSize(sr);
        var screenSizeMax=camera.WorldToScreenPoint(globalSize);
        var screenSizeMin=camera.WorldToScreenPoint(Vector2.zero);
        return screenSizeMax-screenSizeMin;
    }
    public static Vector2 GetSpriteWorldSize(SpriteRenderer sr){
        var baseSize=sr.sprite.bounds.size;
        var scale=sr.transform.localScale;
        return new Vector2(scale.x *baseSize.x,scale.y*baseSize.y);
    }
    public static Vector2 GetGlobalSize(this SpriteRenderer sr){
        return GetSpriteWorldSize(sr);
    }
    public static Vector2 GetScreenSize(this SpriteRenderer sr,Camera camera=null){
        return GetSpriteScreenSize(sr,camera);
    }
}
