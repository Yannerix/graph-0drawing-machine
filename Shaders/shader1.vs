#version 330 core
layout (location = 0) in vec3 aPos;
out vec3 fragColor;
out float aPosX, aPosY;
uniform mat4 transform; 
void main()
{
    vec4 aPos2 = transform*vec4(aPos, 1.0);
    gl_Position = aPos2;
    //gl_Position = vec4(aPos, 1.0);
    fragColor =vec3(0.0);
    aPosX = aPos.x;
    aPosY = aPos.y;
}