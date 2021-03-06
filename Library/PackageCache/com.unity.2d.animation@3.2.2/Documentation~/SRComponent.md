                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # Sprite Resolver component

The __Sprite Resolver__ component pulls information from the [Sprite Library Asset](SLAsset.md) set in the [Sprite Library component](SLComponent.md) on the same GameObject. It automatically applies the selected Sprite to the [Sprite Renderer](https://docs.unity3d.com/Manual/class-SpriteRenderer.html). This allows you to swap the Sprite Renderer’s Sprite to other ones in the Sprite Library Asset during run time.

The component contains two properties - __Category__ and __Label__ - as well as a visual Variant Selector that displays thumbnails of the Sprites contained in the Sprite Library Asset. 

![Inspector view of Sprite Resolver Component, with visual selector.](images/image_2.png)

| Property     | Function                                                     |
| ------------ | ------------------------------------------------------------ |
| __Category__ | Select which Category you want to use a Sprite from for this GameObject. |
| __Label__    | Select the Lab