#version 330 core
in vec3 fragColor;
out vec4 color;
in float aPosX, aPosY;
uniform float x, y, k, b;
uniform vec3 aColor;
 
void main()
{
    vec3 color1 = vec3(0.0, 0.0, 1.0);
    vec3 pixel = aColor; 
    if (aPosX + b >= aPosY)
    {
 	pixel = aColor;
    }
    else
    {
	 pixel = color1;
    }
    color = vec4(pixel, 1.0);
} 