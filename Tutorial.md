# Post processing glow effect

## Post processing setup

First you need to add the post processing system to your Unity project if it you don't already have it.

You can do this by opening the `Package Manager` from the `Window` menu. In the `Package Manager` window, choose `Packages: Unity Registry` from the pull down menu at the top. `Post Processing` should be one of the options. Click on the `Install` button to add this package to your project.

Make a new layer for the post processing effects by choosing the `Layer` pull down on the `Inspector` window for the `Main Camera` object. Choose `Add Layer...` and type in `PostProcessing` to any free layer slot. Make sure your main camera is in the new `PostProcessing` layer.

Add a new `Post-process Volume` component to your main camera, and also a new `Post-process Layer` component.

On the `Post-process Volume` component, check the `Is Global` checkbox. This makes this volume apply wherever your camera is in the world. (You can have multiple `Post-process Volume` components and have effects which only apply when you enter those volumes.)

In the `Profile` slot, click on the `New` button to create a new effect profile asset. You can name this asset anything you like. I called mine, `Profile`.

For the `Post-process Layer` `Layer` pull down box, choose your new `PostProcessing` layer. If you want anti-aliasing applied, you can choose `Fast Approximate Anti-aliasing (FXAA)` and then tick the `Fast Mode` checkbox.

## Adding the bloom effect

To add the bloom effect, first select your `Profile` asset. Then click on the `Add effect...` button in the inspector window. The bloom effect is in the drop down list.

For the bloom effect to work, it has to be selected, that is it needs its checkbox checked, and it also needs to be turned on. Beware that the `On / Off` box is counter intuitive and looks on when it is off. You can toggle it on and off by clicking either the `On` or `Off` button (they both toggle the state.)

Also check the `Intensity` option. Set the value to something large, like 20 to make sure that it is working, before setting it to a more appropriate value.

## Creating a test scene

Add in any object which you want to glow with the bloom effect. Add a material to this object which has a colour in the emission slot and make the colour value greater than one using the HDR colour.

## Example pulsing glow script

I have included a `Glow.cs` script to demonstrate an animation of the glowing effect. Apply this script to any object on your scene which you want to pulse. In the `Renderer` slot drag in the `MeshRenderer` of the object you want to glow. Set the colour value to the base (non-glowing) colour of your object. Set `Bloom` to the amount you want to brighten your colour. Adjust the `Speed` slot to increase the speed of the pulsing effect.
