Shader "Custom/XRay"
{
    SubShader
    {
        Tags { "Queue" = "Transparent+1" }
        Pass { Blend One Zero }
    }
}
